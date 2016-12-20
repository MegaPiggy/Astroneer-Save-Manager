using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Astroneer_Save_Manager.Classes.Data;

namespace Astroneer_Save_Manager.Classes {
    class DataManager {

        public static Save enabledSave;
        public static Dictionary<string, Save> disabledSaves = new Dictionary<string, Save>();
        public static Dictionary<string, BackupSave> backupSlotDictionary = new Dictionary<string, BackupSave>();

        public static void Init() {

            ReadAllSaves();

            UIManager.FillOutLists();

        }

        public static void ReadAllSaves() {

            //Read the enabled save
            {
                string[] files = Directory.GetFiles(FileManager.savePath, "*.sav");

                string saveInfoPath = Path.Combine(FileManager.savePath, "saveInfo.savinf");
                string saveName = File.Exists(saveInfoPath) ? File.ReadAllText(saveInfoPath) : "Active Save";

                Save enabledSave = new Save(saveName, new List<string>(files));
                enabledSave.isEnabled = true;
                Save.lastEnabled = enabledSave;
                DataManager.enabledSave = enabledSave;
            }

            //Read disabled saves
            {
                string[] subfolders = Directory.GetDirectories(FileManager.disabledSavePath);
                int index = 0;

                foreach (string s in subfolders) {

                    string[] files = Directory.GetFiles(s, "*.sav");

                    string saveInfoPath = Path.Combine(s, "saveInfo.savinf");
                    string saveName = File.Exists(saveInfoPath) ? File.ReadAllText(saveInfoPath) : index.ToString();

                    Save disabledSave = new Save(saveName, new List<string>(files));
                    disabledSave.isEnabled = false;
                    disabledSaves.Add(saveName, disabledSave);
                    index++;
                }
            }


        }

        public static void ReadAllBackups() {

        }

        public static void RenameSave(Save toRename, string newName) {

            if (newName.Length == 0)
                return;

            if (toRename == enabledSave) {

                toRename.saveName = newName;
                FileManager.UpdateSaveInfoFile(toRename);

            } else if (disabledSaves.ContainsKey(toRename.saveName) && !disabledSaves.ContainsKey(newName)) {

                string oldName = toRename.saveName;

                disabledSaves.Remove(toRename.saveName);
                toRename.saveName = newName;
                disabledSaves.Add(newName, toRename);

                string oldPath = Path.Combine(FileManager.disabledSavePath, oldName);
                string newPath = Path.Combine(FileManager.disabledSavePath, newName);

                if (newPath.Trim() != oldPath.Trim()) {
                    Directory.Move(oldPath, newPath);

                    FileManager.UpdateSaveInfoFile(toRename, newName);
                }
            } else {

            }

        }

    }
}
