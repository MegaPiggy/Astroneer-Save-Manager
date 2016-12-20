using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Astroneer_Save_Manager.Classes.Data;

namespace Astroneer_Save_Manager.Classes {
    class UIManager {

        public static void Init() {

        }

        public static void FillOutLists() {

            MainWindow.mainForm.saveSlotList.Items.Clear();
            MainWindow.mainForm.backupSlotList.Items.Clear();

            MainWindow.mainForm.saveSlotList.Items.Add(DataManager.enabledSave);
            foreach (Save s in DataManager.disabledSaves.Values) {
                MainWindow.mainForm.saveSlotList.Items.Add(s);
            }

            foreach (BackupSave s in DataManager.backupSlotDictionary.Values) {
                MainWindow.mainForm.backupSlotList.Items.Add(s);
            }
        }

        public static void UpdateSaveProperties() {

            if (MainWindow.mainForm.saveSlotList.SelectedItem == null)
                return;

            Save selectedSave = (Save)MainWindow.mainForm.saveSlotList.SelectedItem;

            MainWindow.mainForm.saveSlotIndex.Text = "Save Slot : " + MainWindow.mainForm.saveSlotList.SelectedIndex;
            MainWindow.mainForm.saveNameInput.Text = selectedSave.saveName;

        }

        public static void UpdateBackupProperties() {
            if (MainWindow.mainForm.backupSlotList.SelectedItem == null)
                return;

            BackupSave selectedSave = (BackupSave)MainWindow.mainForm.backupSlotList.SelectedItem;

            MainWindow.mainForm.backupSaveNameInput.Text = selectedSave.saveName;
        }

    }
}
