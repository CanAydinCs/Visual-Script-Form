namespace Visual_Script_Forms
{
    partial class FormFileSelector
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.BtnCreate = new System.Windows.Forms.Button();
            this.BtnOpen = new System.Windows.Forms.Button();
            this.BtnDir = new System.Windows.Forms.Button();
            this.txtDir = new System.Windows.Forms.TextBox();
            this.fileSelector = new System.Windows.Forms.OpenFileDialog();
            this.folderSelector = new System.Windows.Forms.FolderBrowserDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtFile = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // BtnCreate
            // 
            this.BtnCreate.Location = new System.Drawing.Point(148, 159);
            this.BtnCreate.Name = "BtnCreate";
            this.BtnCreate.Size = new System.Drawing.Size(94, 64);
            this.BtnCreate.TabIndex = 0;
            this.BtnCreate.Text = "Create";
            this.BtnCreate.UseVisualStyleBackColor = true;
            this.BtnCreate.Click += new System.EventHandler(this.BtnCreate_Click);
            // 
            // BtnOpen
            // 
            this.BtnOpen.Location = new System.Drawing.Point(749, 159);
            this.BtnOpen.Name = "BtnOpen";
            this.BtnOpen.Size = new System.Drawing.Size(94, 64);
            this.BtnOpen.TabIndex = 1;
            this.BtnOpen.Text = "Open";
            this.BtnOpen.UseVisualStyleBackColor = true;
            this.BtnOpen.Click += new System.EventHandler(this.BtnOpen_Click);
            // 
            // BtnDir
            // 
            this.BtnDir.Location = new System.Drawing.Point(971, 113);
            this.BtnDir.Name = "BtnDir";
            this.BtnDir.Size = new System.Drawing.Size(94, 29);
            this.BtnDir.TabIndex = 2;
            this.BtnDir.Text = "...";
            this.BtnDir.UseVisualStyleBackColor = true;
            this.BtnDir.Click += new System.EventHandler(this.BtnDir_Click);
            // 
            // txtDir
            // 
            this.txtDir.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtDir.Location = new System.Drawing.Point(475, 115);
            this.txtDir.Name = "txtDir";
            this.txtDir.ReadOnly = true;
            this.txtDir.Size = new System.Drawing.Size(490, 27);
            this.txtDir.TabIndex = 3;
            // 
            // fileSelector
            // 
            this.fileSelector.FileName = "New Visual Script Form";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(118, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 35);
            this.label1.TabIndex = 4;
            this.label1.Text = "Create New:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(659, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(172, 35);
            this.label2.TabIndex = 5;
            this.label2.Text = "Open Existing:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Project Name:";
            // 
            // txtFile
            // 
            this.txtFile.Location = new System.Drawing.Point(118, 114);
            this.txtFile.Name = "txtFile";
            this.txtFile.PlaceholderText = "New VSF Project";
            this.txtFile.Size = new System.Drawing.Size(204, 27);
            this.txtFile.TabIndex = 7;
            // 
            // FormFileSelector
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1077, 246);
            this.Controls.Add(this.txtFile);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtDir);
            this.Controls.Add(this.BtnDir);
            this.Controls.Add(this.BtnOpen);
            this.Controls.Add(this.BtnCreate);
            this.Name = "FormFileSelector";
            this.Text = "Visual Script Forms";
            this.Load += new System.EventHandler(this.FormFileSelector_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button BtnCreate;
        private Button BtnOpen;
        private Button BtnDir;
        private TextBox txtDir;
        private OpenFileDialog fileSelector;
        private FolderBrowserDialog folderSelector;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtFile;
    }
}