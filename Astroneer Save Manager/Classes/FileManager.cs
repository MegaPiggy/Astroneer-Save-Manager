using System;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using Astroneer_Save_Manager.Classes.Data;
using System.Windows.Forms;
using System.Globalization;

namespace Astroneer_Save_Manager.Classes
{
    public class FileManager
    {
        public static string gamePath;
        public static string savePath;
        public static string disabledSavePath;
        public static string backupSavePath;
        public static string appDataPath;

        public static void Init()
        {
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

        public static void SetupIfNeeded()
        {
            //Inital setup proccess, disable all saves except for save 0.
            {

                Dictionary<DateTime, Save> saveSlotsDictionary = new Dictionary<DateTime, Save>();
                string[] getFiles = Directory.GetFiles(savePath, "*.savegame");

                //Loop through all the files in the save folder
                for (int i = 0; i < getFiles.Length; i++)
                {
                    //Get the save name and the index of the save according to the game.
                    string fileName = Path.GetFileNameWithoutExtension(getFiles[i]);

                    string saveName = fileName.Substring(0, fileName.IndexOf('$'));
                    MessageBox.Show(fileName.Substring(fileName.IndexOf('$') + 1));
                    DateTime date = DateTime.ParseExact(fileName.Substring(fileName.IndexOf('$') + 1), "yyyy.MM.dd-HH.mm.ss", CultureInfo.InvariantCulture);

                    //Create the save class if needed
                    if (!saveSlotsDictionary.ContainsKey(date))
                    {
                        saveSlotsDictionary[date] = new Save(saveName, new List<string>());
                    }

                    //Add this save file to the class
                    saveSlotsDictionary[date].saveFiles.Add(fileName);
                }

                string[] getDisabledFiles = Directory.GetFiles(disabledSavePath, "*.savegame", SearchOption.AllDirectories);

                //Loop through all the files in the save folder
                for (int i = 0; i < getDisabledFiles.Length; i++)
                {
                    //Get the save name and the index of the save according to the game.
                    string fileName = Path.GetFileNameWithoutExtension(getDisabledFiles[i]);

                    string saveName = fileName.Substring(0, fileName.IndexOf('$'));
                    MessageBox.Show(fileName.Substring(fileName.IndexOf('$') + 1));
                    DateTime date = DateTime.ParseExact(fileName.Substring(fileName.IndexOf('$') + 1), "yyyy.MM.dd-HH.mm.ss", CultureInfo.InvariantCulture);

                    //Create the save class if needed
                    if (!saveSlotsDictionary.ContainsKey(date))
                    {
                        saveSlotsDictionary[date] = new Save(saveName, new List<string>(), true);
                    }

                    //Add this save file to the class
                    saveSlotsDictionary[date].saveFiles.Add(fileName);
                }

                //Disable all saves except the first one.
                if (saveSlotsDictionary.Count > 0)
                {
                    var first = saveSlotsDictionary.FirstOrDefault();
                    var firstSaveKey = first.Key;

                    foreach (var s in saveSlotsDictionary)
                    {
                        if (s.Key != firstSaveKey)
                        {
                            s.Value.isEnabled = true;
                            s.Value.Disable();
                        }
                    }

                    first.Value.isEnabled = false;
                    first.Value.Enable();
                }
            }
        }

        public static void UpdateSaveInfoFile(Save update, string oldName = "")
        {
            if (update.isEnabled)
            {
                string saveInfoPath = Path.Combine(FileManager.savePath, "saveInfo.savinf");
                StreamWriter sw = File.CreateText(saveInfoPath);
                sw.Write(update.saveName);
                sw.Close();
            }
            else
            {
                string saveInfoPath = Path.Combine(FileManager.disabledSavePath, oldName, "saveInfo.savinf");
                StreamWriter sw = File.CreateText(saveInfoPath);
                sw.Write(update.saveName);
                sw.Close();
            }
        }

        public static void UpdateBackupInfoFile(BackupSave update)
        {

            string saveInfoPath = Path.Combine(FileManager.backupSavePath, update.saveName, "saveInfo.savinf");
            StreamWriter sw = File.CreateText(saveInfoPath);
            sw.Write(update.saveName);
            sw.Close();
        }
    }
}
