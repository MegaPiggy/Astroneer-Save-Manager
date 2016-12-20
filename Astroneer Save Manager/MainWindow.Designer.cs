namespace Astroneer_Save_Manager {
    partial class MainWindow {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.saveSlotList = new System.Windows.Forms.ListBox();
            this.saveSlotLabel = new System.Windows.Forms.Label();
            this.backupSlotListLabel = new System.Windows.Forms.Label();
            this.backupSlotList = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.backupSaveButton = new System.Windows.Forms.Button();
            this.saveNameInput = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.saveSlotIndex = new System.Windows.Forms.Label();
            this.savePropsLabel = new System.Windows.Forms.Label();
            this.backupSavePropsLabel = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.restoreBackupButton = new System.Windows.Forms.Button();
            this.backupSaveNameInput = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.EnabledSave = new System.Windows.Forms.GroupBox();
            this.enabledSaveName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.EnabledSave.SuspendLayout();
            this.SuspendLayout();
            // 
            // saveSlotList
            // 
            this.saveSlotList.FormattingEnabled = true;
            this.saveSlotList.Location = new System.Drawing.Point(12, 39);
            this.saveSlotList.Name = "saveSlotList";
            this.saveSlotList.Size = new System.Drawing.Size(191, 563);
            this.saveSlotList.TabIndex = 0;
            this.saveSlotList.SelectedIndexChanged += new System.EventHandler(this.saveSlotList_SelectedIndexChanged);
            // 
            // saveSlotLabel
            // 
            this.saveSlotLabel.BackColor = System.Drawing.Color.White;
            this.saveSlotLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveSlotLabel.Location = new System.Drawing.Point(12, 9);
            this.saveSlotLabel.Name = "saveSlotLabel";
            this.saveSlotLabel.Size = new System.Drawing.Size(191, 27);
            this.saveSlotLabel.TabIndex = 1;
            this.saveSlotLabel.Text = "Save Slots";
            this.saveSlotLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // backupSlotListLabel
            // 
            this.backupSlotListLabel.BackColor = System.Drawing.Color.White;
            this.backupSlotListLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backupSlotListLabel.Location = new System.Drawing.Point(311, 9);
            this.backupSlotListLabel.Name = "backupSlotListLabel";
            this.backupSlotListLabel.Size = new System.Drawing.Size(191, 27);
            this.backupSlotListLabel.TabIndex = 3;
            this.backupSlotListLabel.Text = "Backup Saves";
            this.backupSlotListLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // backupSlotList
            // 
            this.backupSlotList.FormattingEnabled = true;
            this.backupSlotList.Location = new System.Drawing.Point(311, 39);
            this.backupSlotList.Name = "backupSlotList";
            this.backupSlotList.Size = new System.Drawing.Size(191, 563);
            this.backupSlotList.TabIndex = 2;
            this.backupSlotList.SelectedIndexChanged += new System.EventHandler(this.backupSlotList_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.backupSaveButton);
            this.groupBox1.Controls.Add(this.saveNameInput);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.saveSlotIndex);
            this.groupBox1.Location = new System.Drawing.Point(509, 39);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(279, 563);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            // 
            // backupSaveButton
            // 
            this.backupSaveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backupSaveButton.Location = new System.Drawing.Point(6, 284);
            this.backupSaveButton.Name = "backupSaveButton";
            this.backupSaveButton.Size = new System.Drawing.Size(267, 29);
            this.backupSaveButton.TabIndex = 3;
            this.backupSaveButton.Text = "Backup Save";
            this.backupSaveButton.UseVisualStyleBackColor = true;
            this.backupSaveButton.Click += new System.EventHandler(this.backupSaveButton_Click);
            // 
            // saveNameInput
            // 
            this.saveNameInput.Location = new System.Drawing.Point(72, 29);
            this.saveNameInput.Name = "saveNameInput";
            this.saveNameInput.Size = new System.Drawing.Size(201, 20);
            this.saveNameInput.TabIndex = 2;
            this.saveNameInput.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Save Name :";
            // 
            // saveSlotIndex
            // 
            this.saveSlotIndex.AutoSize = true;
            this.saveSlotIndex.Location = new System.Drawing.Point(6, 16);
            this.saveSlotIndex.Name = "saveSlotIndex";
            this.saveSlotIndex.Size = new System.Drawing.Size(68, 13);
            this.saveSlotIndex.TabIndex = 0;
            this.saveSlotIndex.Text = "Save Slot : 0";
            // 
            // savePropsLabel
            // 
            this.savePropsLabel.BackColor = System.Drawing.Color.White;
            this.savePropsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.savePropsLabel.Location = new System.Drawing.Point(508, 9);
            this.savePropsLabel.Name = "savePropsLabel";
            this.savePropsLabel.Size = new System.Drawing.Size(280, 27);
            this.savePropsLabel.TabIndex = 5;
            this.savePropsLabel.Text = "Save Properties";
            this.savePropsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // backupSavePropsLabel
            // 
            this.backupSavePropsLabel.BackColor = System.Drawing.Color.White;
            this.backupSavePropsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backupSavePropsLabel.Location = new System.Drawing.Point(794, 9);
            this.backupSavePropsLabel.Name = "backupSavePropsLabel";
            this.backupSavePropsLabel.Size = new System.Drawing.Size(280, 27);
            this.backupSavePropsLabel.TabIndex = 7;
            this.backupSavePropsLabel.Text = "Backup Save Properties";
            this.backupSavePropsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.White;
            this.groupBox2.Controls.Add(this.restoreBackupButton);
            this.groupBox2.Controls.Add(this.backupSaveNameInput);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(795, 39);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(279, 563);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            // 
            // restoreBackupButton
            // 
            this.restoreBackupButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.restoreBackupButton.Location = new System.Drawing.Point(6, 250);
            this.restoreBackupButton.Name = "restoreBackupButton";
            this.restoreBackupButton.Size = new System.Drawing.Size(267, 29);
            this.restoreBackupButton.TabIndex = 4;
            this.restoreBackupButton.Text = "Restore Backup";
            this.restoreBackupButton.UseVisualStyleBackColor = true;
            this.restoreBackupButton.Click += new System.EventHandler(this.restoreBackupButton_Click);
            // 
            // backupSaveNameInput
            // 
            this.backupSaveNameInput.Location = new System.Drawing.Point(72, 13);
            this.backupSaveNameInput.Name = "backupSaveNameInput";
            this.backupSaveNameInput.Size = new System.Drawing.Size(201, 20);
            this.backupSaveNameInput.TabIndex = 2;
            this.backupSaveNameInput.TextChanged += new System.EventHandler(this.backupSaveNameInput_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Save Name :";
            // 
            // EnabledSave
            // 
            this.EnabledSave.BackColor = System.Drawing.SystemColors.Window;
            this.EnabledSave.Controls.Add(this.enabledSaveName);
            this.EnabledSave.Controls.Add(this.label1);
            this.EnabledSave.Location = new System.Drawing.Point(210, 175);
            this.EnabledSave.Name = "EnabledSave";
            this.EnabledSave.Size = new System.Drawing.Size(95, 143);
            this.EnabledSave.TabIndex = 8;
            this.EnabledSave.TabStop = false;
            this.EnabledSave.Text = "Enabled Save";
            // 
            // enabledSaveName
            // 
            this.enabledSaveName.Location = new System.Drawing.Point(6, 42);
            this.enabledSaveName.Name = "enabledSaveName";
            this.enabledSaveName.Size = new System.Drawing.Size(83, 20);
            this.enabledSaveName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(0, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Save Name :";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(138, 579);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(65, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "Refresh";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(311, 579);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 10;
            this.button2.Text = "Refresh";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(6, 250);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(267, 29);
            this.button3.TabIndex = 4;
            this.button3.Text = "Enable Save";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(1086, 611);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.EnabledSave);
            this.Controls.Add(this.backupSavePropsLabel);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.savePropsLabel);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.backupSlotListLabel);
            this.Controls.Add(this.backupSlotList);
            this.Controls.Add(this.saveSlotLabel);
            this.Controls.Add(this.saveSlotList);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Astroneer Save Manager";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.EnabledSave.ResumeLayout(false);
            this.EnabledSave.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label saveSlotLabel;
        public System.Windows.Forms.ListBox saveSlotList;
        private System.Windows.Forms.Label backupSlotListLabel;
        public System.Windows.Forms.ListBox backupSlotList;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label savePropsLabel;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox saveNameInput;
        public System.Windows.Forms.Label saveSlotIndex;
        private System.Windows.Forms.Label backupSavePropsLabel;
        private System.Windows.Forms.GroupBox groupBox2;
        public System.Windows.Forms.TextBox backupSaveNameInput;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button backupSaveButton;
        private System.Windows.Forms.Button restoreBackupButton;
        private System.Windows.Forms.GroupBox EnabledSave;
        public System.Windows.Forms.TextBox enabledSaveName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}

