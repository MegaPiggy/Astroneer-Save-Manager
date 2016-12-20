using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Astroneer_Save_Manager.Classes;
using Astroneer_Save_Manager.Classes.Data;

namespace Astroneer_Save_Manager {
    public partial class MainWindow : Form {

        public static MainWindow mainForm;
        public static BackupRestoreForm backupRestoreForm;
        public static BackupCreateForm backupCreateForm;

        public MainWindow() {
            mainForm = this;
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) {
            FileManager.Init();

            backupRestoreForm = new BackupRestoreForm();
            backupRestoreForm.Visible = false;

            backupCreateForm = new BackupCreateForm();
            backupCreateForm.Visible = false;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e) {

        }

        private void saveSlotList_SelectedIndexChanged(object sender, EventArgs e) {
            UIManager.UpdateSaveProperties();
        }

        private void backupSlotList_SelectedIndexChanged(object sender, EventArgs e) {

        }

        private void textBox1_TextChanged(object sender, EventArgs e) {
            if (saveSlotList.SelectedItem == null)
                return;

            DataManager.RenameSave((Save)saveSlotList.SelectedItem, saveNameInput.Text);
        }

        private void backupSaveNameInput_TextChanged(object sender, EventArgs e) {

        }

        private void restoreBackupButton_Click(object sender, EventArgs e) {

        }

        private void backupSaveButton_Click(object sender, EventArgs e) {

        }

        private void button1_Click(object sender, EventArgs e) {
            saveSlotList.DisplayMember = "";
            saveSlotList.DisplayMember = "Name";
        }

        private void button2_Click(object sender, EventArgs e) {
            saveSlotList.DisplayMember = "";
            saveSlotList.DisplayMember = "Name";
        }

        private void button3_Click(object sender, EventArgs e) {
            if (saveSlotList.SelectedItem == null)
                return;

            ((Save)saveSlotList.SelectedItem).Enable();
        }
    }
}
