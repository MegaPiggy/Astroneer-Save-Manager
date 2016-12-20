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
    public partial class BackupRestoreForm : Form {
        public BackupRestoreForm() {
            InitializeComponent();
        }

        public static BackupSave pickedSave;

        private void confirmRestore_Click(object sender, EventArgs e) {
            this.Close();
        }
    }
}
