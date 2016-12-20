using System;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using Astroneer_Save_Manager.Classes.Data;

namespace Astroneer_Save_Manager.Classes {
    class FileManager {

        public static string gamePath;
        public static string savePath;
        public static string disabledSavePath;
        public static string backupSavePath;
        public static string appDataPath;

        public static void Init() {

            //Create all the path variables.
            gamePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "Astro", "Saved");
            savePath = Path.Combine(gamePath, "SaveGames");
            disabledSavePath = Path.Combine(gamePath, "DisabledSaves");
            backupSavePath = Path.Combine(gamePath, "BackupSaves");
            appDataPath = Path.Combine(gamePath, "SaveManagerData");

            //Make sure the backup and save manager data folders exist.
            if (!Directory.Exists(backupSavePath))
                Directory.CreateDirectory(backupSavePath);
            if (!Directory.Exists(appDataPath))
                Directory.CreateDirectory(appDataPath);
            if (!Directory.Exists(disabledSavePath))
                Directory.CreateDirectory(disabledSavePath);

            SetupIfNeeded();

            UIManager.Init();
            DataManager.Init();

        }

        public static void SetupIfNeeded() {

            if (File.Exists(Path.Combine(appDataPath, "setupFile.sf"))) {
                return;
            }

            //File.Create(Path.Combine(appDataPath, "setupFile.sf"));

            //Inital setup proccess, disable all saves except for save 0.
            {

                Dictionary<int, Save> saveSlotsDictionary = new Dictionary<int, Save>();
                string[] getFiles = Directory.GetFiles(savePath, "*.sav");

                //Loop through all the files in the save folder
                for (int i = 0; i < getFiles.Length; i++) {

                    //Get the save name and the index of the save according to the game.
                    string fileName = Path.GetFileNameWithoutExtension(getFiles[i]);
                    int index = int.Parse(fileName[9].ToString());

                    //Create the save class if needed
                    if (!saveSlotsDictionary.ContainsKey(index)) {
                        saveSlotsDictionary[index] = new Save(index.ToString(), new List<string>());
                    }

                    //Add this save file to the class
                    saveSlotsDictionary[index].saveFiles.Add(fileName);
                }

                //Disable all saves except the first one.
                if (saveSlotsDictionary.Count > 0) {
                    int firstSaveKey = saveSlotsDictionary.First().Key;

                    foreach (KeyValuePair<int, Save> s in saveSlotsDictionary) {
                        if (s.Key != firstSaveKey) {
                            s.Value.isEnabled = true;
                            s.Value.Disable();
                        }
                    }
                }

                saveSlotsDictionary.First().Value.isEnabled = false;
                saveSlotsDictionary.First().Value.Enable();

            }

        }

        public static void UpdateSaveInfoFile(Save update, string oldName = "") {

            if (update.isEnabled) {
                string saveInfoPath = Path.Combine(FileManager.savePath, "saveInfo.savinf");
                StreamWriter sw = File.CreateText(saveInfoPath);
                sw.Write(update.saveName);
                sw.Close();
            } else {
                string saveInfoPath = Path.Combine(FileManager.disabledSavePath, oldName, "saveInfo.savinf");
                StreamWriter sw = File.CreateText(saveInfoPath);
                sw.Write(update.saveName);
                sw.Close();
            }

        }

        public static void UpdateBackupInfoFile(BackupSave update) {

            string saveInfoPath = Path.Combine(FileManager.backupSavePath, update.saveName, "saveInfo.savinf");
            StreamWriter sw = File.CreateText(saveInfoPath);
            sw.Write(update.saveName);
            sw.Close();

        }
    }
}
