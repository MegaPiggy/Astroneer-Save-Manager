using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Astroneer_Save_Manager.Classes.Data {
    public class BackupSave {

        /// <summary>
        /// The custom name of the save.
        /// </summary>
        public string saveName;
        /// <summary>
        /// All the files used by this save.
        /// </summary>
        public List<string> saveFiles;
        /// <summary>
        /// Is the save enabled?
        /// </summary>
        public bool isEnabled = false;

        public BackupSave(string name, List<string> saveFiles) {
            this.saveName = name;
            this.saveFiles = saveFiles;
        }

        public void Disable() {
            if (!isEnabled)
                return;

            //Do stuff

            isEnabled = false;
        }

        public void Enable() {
            if (isEnabled)
                return;

            //Do stuff

            isEnabled = true;
        }

        public override string ToString() {
            return saveName;
        }

    }
}
