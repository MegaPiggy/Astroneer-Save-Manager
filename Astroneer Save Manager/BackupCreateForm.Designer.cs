namespace Astroneer_Save_Manager {
    partial class BackupCreateForm {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BackupCreateForm));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.lastSaveDate = new System.Windows.Forms.Label();
            this.newNameLabel = new System.Windows.Forms.Label();
            this.newName = new System.Windows.Forms.TextBox();
            this.keepBackup = new System.Windows.Forms.CheckBox();
            this.copyName = new System.Windows.Forms.CheckBox();
            this.deleteSaves = new System.Windows.Forms.CheckBox();
            this.confirmBackup = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.backupSaveDate = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.Controls.Add(this.backupSaveDate);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.lastSaveDate);
            this.splitContainer1.Panel2.Controls.Add(this.newNameLabel);
            this.splitContainer1.Panel2.Controls.Add(this.newName);
            this.splitContainer1.Panel2.Controls.Add(this.label2);
            this.splitContainer1.Panel2.Controls.Add(this.keepBackup);
            this.splitContainer1.Panel2.Controls.Add(this.confirmBackup);
            this.splitContainer1.Panel2.Controls.Add(this.copyName);
            this.splitContainer1.Panel2.Controls.Add(this.deleteSaves);
            this.splitContainer1.Size = new System.Drawing.Size(600, 248);
            this.splitContainer1.SplitterDistance = 250;
            this.splitContainer1.SplitterWidth = 50;
            this.splitContainer1.TabIndex = 0;
            // 
            // lastSaveDate
            // 
            this.lastSaveDate.AutoSize = true;
            this.lastSaveDate.Location = new System.Drawing.Point(12, 101);
            this.lastSaveDate.Name = "lastSaveDate";
            this.lastSaveDate.Size = new System.Drawing.Size(88, 13);
            this.lastSaveDate.TabIndex = 7;
            this.lastSaveDate.Text = "Late Save Date :";
            // 
            // newNameLabel
            // 
            this.newNameLabel.AutoSize = true;
            this.newNameLabel.Location = new System.Drawing.Point(12, 120);
            this.newNameLabel.Name = "newNameLabel";
            this.newNameLabel.Size = new System.Drawing.Size(66, 13);
            this.newNameLabel.TabIndex = 6;
            this.newNameLabel.Text = "New Name :";
            // 
            // newName
            // 
            this.newName.Location = new System.Drawing.Point(84, 117);
            this.newName.Name = "newName";
            this.newName.Size = new System.Drawing.Size(163, 20);
            this.newName.TabIndex = 5;
            // 
            // keepBackup
            // 
            this.keepBackup.AutoSize = true;
            this.keepBackup.Location = new System.Drawing.Point(15, 81);
            this.keepBackup.Name = "keepBackup";
            this.keepBackup.Size = new System.Drawing.Size(91, 17);
            this.keepBackup.TabIndex = 4;
            this.keepBackup.Text = "Keep Backup";
            this.keepBackup.UseVisualStyleBackColor = true;
            // 
            // copyName
            // 
            this.copyName.AutoSize = true;
            this.copyName.Checked = true;
            this.copyName.CheckState = System.Windows.Forms.CheckState.Checked;
            this.copyName.Location = new System.Drawing.Point(15, 58);
            this.copyName.Name = "copyName";
            this.copyName.Size = new System.Drawing.Size(81, 17);
            this.copyName.TabIndex = 3;
            this.copyName.Text = "Copy Name";
            this.copyName.UseVisualStyleBackColor = true;
            // 
            // deleteSaves
            // 
            this.deleteSaves.AutoSize = true;
            this.deleteSaves.Checked = true;
            this.deleteSaves.CheckState = System.Windows.Forms.CheckState.Checked;
            this.deleteSaves.Location = new System.Drawing.Point(15, 35);
            this.deleteSaves.Name = "deleteSaves";
            this.deleteSaves.Size = new System.Drawing.Size(134, 17);
            this.deleteSaves.TabIndex = 2;
            this.deleteSaves.Text = "Delete Previous Saves";
            this.deleteSaves.UseVisualStyleBackColor = true;
            // 
            // confirmBackup
            // 
            this.confirmBackup.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.confirmBackup.Location = new System.Drawing.Point(6, 222);
            this.confirmBackup.Name = "confirmBackup";
            this.confirmBackup.Size = new System.Drawing.Size(291, 23);
            this.confirmBackup.TabIndex = 1;
            this.confirmBackup.Text = "Confirm Backup";
            this.confirmBackup.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.Cursor = System.Windows.Forms.Cursors.Default;
            this.label1.Location = new System.Drawing.Point(3, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(244, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Save Options";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // backupSaveDate
            // 
            this.backupSaveDate.AutoSize = true;
            this.backupSaveDate.Location = new System.Drawing.Point(12, 36);
            this.backupSaveDate.Name = "backupSaveDate";
            this.backupSaveDate.Size = new System.Drawing.Size(87, 13);
            this.backupSaveDate.TabIndex = 2;
            this.backupSaveDate.Text = "Last Save Date :";
            // 
            // label2
            // 
            this.label2.Cursor = System.Windows.Forms.Cursors.Default;
            this.label2.Location = new System.Drawing.Point(3, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(294, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Backup Options";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BackupCreateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 248);
            this.Controls.Add(this.splitContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "BackupCreateForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Backup Restore";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label newNameLabel;
        private System.Windows.Forms.TextBox newName;
        private System.Windows.Forms.CheckBox keepBackup;
        private System.Windows.Forms.CheckBox copyName;
        public System.Windows.Forms.CheckBox deleteSaves;
        private System.Windows.Forms.Button confirmBackup;
        public System.Windows.Forms.Label lastSaveDate;
        public System.Windows.Forms.Label backupSaveDate;
    }
}