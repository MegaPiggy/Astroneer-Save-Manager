using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Astroneer_Save_Manager.Classes.Data
{
    public class Save
    {
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

        public static Save lastEnabled = null;

        public Save(string saveName, List<string> saveFiles)
        {
            this.saveName = saveName;
            this.saveFiles = saveFiles;
        }

        public Save(string saveName, List<string> saveFiles, bool isEnabled) : this(saveName, saveFiles)
        {
            this.isEnabled = isEnabled;
        }

        public void Disable()
        {
            if (!isEnabled)
                return;

            string pathToDisabledFolder = Path.Combine(FileManager.disabledSavePath, saveName);

            //Make sure the folder we're moving to exists.
            if (!Directory.Exists(pathToDisabledFolder))
            {
                Directory.CreateDirectory(pathToDisabledFolder);
            }

            //Move all the files to the disabled folder.
            foreach (string s in Directory.GetFiles(FileManager.savePath, "*.savegame"))
            {
                string fileName = Path.GetFileName(s);
                if (!fileName.StartsWith(saveName)) continue;
                string previousDirectory = Path.Combine(FileManager.savePath, fileName);
                string newDirectory = Path.Combine(pathToDisabledFolder, fileName);
                File.Move(previousDirectory, newDirectory);
                Console.WriteLine(previousDirectory + "|" + newDirectory);
            }

            //Disable this save.
            isEnabled = false;
            DataManager.enabledSave = null;
            DataManager.disabledSaves[saveName] = this;
        }

        public void Enable()
        {
            if (isEnabled)
                return;

            //Make sure the last save we enabled isn't enabled as well, it would cause problems
            if (lastEnabled != null)
                lastEnabled.Disable();

            string pathToDisabledFolder = Path.Combine(FileManager.disabledSavePath, saveName);

            //Make sure the folder we're moving to exists.
            if (!Directory.Exists(pathToDisabledFolder))
            {
                Directory.CreateDirectory(pathToDisabledFolder);
            }

            //Move all the files over to the enabled folder
            foreach (string s in Directory.GetFiles(pathToDisabledFolder))
            {
                string fileName = Path.GetFileName(s);
                string previousDirectory = Path.Combine(pathToDisabledFolder, fileName);
                string newDirectory = Path.Combine(FileManager.savePath, fileName);
                File.Move(previousDirectory, newDirectory);
                Console.WriteLine(previousDirectory + "|" + newDirectory);
            }

            //Enable this save and set it to the last enabled.
            isEnabled = true;
            lastEnabled = this;
            DataManager.enabledSave = this;
        }


        public void Toggle()
        {
            if (isEnabled)
            {
                Disable();
            }
            else
            {
                Enable();
            }
        }

        public override string ToString()
        {
            return saveName + (isEnabled ? "" : "(DISABLED)");
        }

    }
}
