namespace WriteImageToBlobField
{
    partial class ImageBlobWriter
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tbServer = new System.Windows.Forms.TextBox();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.tbField = new System.Windows.Forms.TextBox();
            this.tbDatabase = new System.Windows.Forms.TextBox();
            this.tbUsername = new System.Windows.Forms.TextBox();
            this.tbTable = new System.Windows.Forms.TextBox();
            this.pbImage = new System.Windows.Forms.PictureBox();
            this.btnSaveSettings = new System.Windows.Forms.Button();
            this.btnOpenImage = new System.Windows.Forms.Button();
            this.btnWriteBlob = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbField = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tbFilePath = new System.Windows.Forms.TextBox();
            this.cbCompress = new System.Windows.Forms.CheckBox();
            this.cbUpdate = new System.Windows.Forms.CheckBox();
            this.lbDistinction = new System.Windows.Forms.Label();
            this.tbDistinction = new System.Windows.Forms.TextBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).BeginInit();
            this.SuspendLayout();
            // 
            // tbServer
            // 
            this.tbServer.Location = new System.Drawing.Point(67, 12);
            this.tbServer.Name = "tbServer";
            this.tbServer.Size = new System.Drawing.Size(100, 20);
            this.tbServer.TabIndex = 0;
            // 
            // tbPassword
            // 
            this.tbPassword.Location = new System.Drawing.Point(288, 38);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.Size = new System.Drawing.Size(100, 20);
            this.tbPassword.TabIndex = 1;
            // 
            // tbField
            // 
            this.tbField.Location = new System.Drawing.Point(288, 90);
            this.tbField.Name = "tbField";
            this.tbField.Size = new System.Drawing.Size(100, 20);
            this.tbField.TabIndex = 2;
            this.tbField.Visible = false;
            this.tbField.MouseMove += new System.Windows.Forms.MouseEventHandler(this.UpdateToolTip);
            // 
            // tbDatabase
            // 
            this.tbDatabase.Location = new System.Drawing.Point(288, 12);
            this.tbDatabase.Name = "tbDatabase";
            this.tbDatabase.Size = new System.Drawing.Size(100, 20);
            this.tbDatabase.TabIndex = 3;
            // 
            // tbUsername
            // 
            this.tbUsername.Location = new System.Drawing.Point(67, 38);
            this.tbUsername.Name = "tbUsername";
            this.tbUsername.Size = new System.Drawing.Size(100, 20);
            this.tbUsername.TabIndex = 4;
            // 
            // tbTable
            // 
            this.tbTable.Location = new System.Drawing.Point(67, 64);
            this.tbTable.Name = "tbTable";
            this.tbTable.Size = new System.Drawing.Size(100, 20);
            this.tbTable.TabIndex = 5;
            // 
            // pbImage
            // 
            this.pbImage.Location = new System.Drawing.Point(12, 116);
            this.pbImage.Name = "pbImage";
            this.pbImage.Size = new System.Drawing.Size(379, 152);
            this.pbImage.TabIndex = 6;
            this.pbImage.TabStop = false;
            // 
            // btnSaveSettings
            // 
            this.btnSaveSettings.Location = new System.Drawing.Point(12, 300);
            this.btnSaveSettings.Name = "btnSaveSettings";
            this.btnSaveSettings.Size = new System.Drawing.Size(75, 23);
            this.btnSaveSettings.TabIndex = 7;
            this.btnSaveSettings.Text = "Save Settings";
            this.btnSaveSettings.UseVisualStyleBackColor = true;
            this.btnSaveSettings.Click += new System.EventHandler(this.BtnSaveSettings_Click);
            // 
            // btnOpenImage
            // 
            this.btnOpenImage.Location = new System.Drawing.Point(167, 300);
            this.btnOpenImage.Name = "btnOpenImage";
            this.btnOpenImage.Size = new System.Drawing.Size(75, 23);
            this.btnOpenImage.TabIndex = 8;
            this.btnOpenImage.Text = "Open Image";
            this.btnOpenImage.UseVisualStyleBackColor = true;
            this.btnOpenImage.Click += new System.EventHandler(this.BtnOpenImage_Click);
            // 
            // btnWriteBlob
            // 
            this.btnWriteBlob.Location = new System.Drawing.Point(316, 300);
            this.btnWriteBlob.Name = "btnWriteBlob";
            this.btnWriteBlob.Size = new System.Drawing.Size(75, 23);
            this.btnWriteBlob.TabIndex = 9;
            this.btnWriteBlob.Text = "Write Blob";
            this.btnWriteBlob.UseVisualStyleBackColor = true;
            this.btnWriteBlob.Click += new System.EventHandler(this.BtnWriteBlob_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Server";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Table";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Username";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(229, 41);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Password";
            // 
            // lbField
            // 
            this.lbField.AutoSize = true;
            this.lbField.Location = new System.Drawing.Point(249, 93);
            this.lbField.Name = "lbField";
            this.lbField.Size = new System.Drawing.Size(33, 13);
            this.lbField.TabIndex = 14;
            this.lbField.Text = "Field*";
            this.lbField.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(229, 15);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Database";
            // 
            // tbFilePath
            // 
            this.tbFilePath.Location = new System.Drawing.Point(12, 274);
            this.tbFilePath.Name = "tbFilePath";
            this.tbFilePath.Size = new System.Drawing.Size(273, 20);
            this.tbFilePath.TabIndex = 16;
            this.tbFilePath.TextChanged += new System.EventHandler(this.TbFilePath_TextChanged);
            // 
            // cbCompress
            // 
            this.cbCompress.AutoSize = true;
            this.cbCompress.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cbCompress.Location = new System.Drawing.Point(310, 276);
            this.cbCompress.Name = "cbCompress";
            this.cbCompress.Size = new System.Drawing.Size(78, 17);
            this.cbCompress.TabIndex = 17;
            this.cbCompress.Text = "Compress?";
            this.cbCompress.UseVisualStyleBackColor = true;
            // 
            // cbUpdate
            // 
            this.cbUpdate.AutoSize = true;
            this.cbUpdate.Location = new System.Drawing.Point(67, 93);
            this.cbUpdate.Name = "cbUpdate";
            this.cbUpdate.Size = new System.Drawing.Size(67, 17);
            this.cbUpdate.TabIndex = 18;
            this.cbUpdate.Text = "Update?";
            this.cbUpdate.UseVisualStyleBackColor = true;
            this.cbUpdate.CheckedChanged += new System.EventHandler(this.CbUpdate_CheckedChanged);
            // 
            // lbDistinction
            // 
            this.lbDistinction.AutoSize = true;
            this.lbDistinction.Location = new System.Drawing.Point(222, 67);
            this.lbDistinction.Name = "lbDistinction";
            this.lbDistinction.Size = new System.Drawing.Size(60, 13);
            this.lbDistinction.TabIndex = 19;
            this.lbDistinction.Text = "Distinction*";
            this.lbDistinction.Visible = false;
            this.lbDistinction.MouseMove += new System.Windows.Forms.MouseEventHandler(this.OptionalToolTip);
            // 
            // tbDistinction
            // 
            this.tbDistinction.Location = new System.Drawing.Point(288, 64);
            this.tbDistinction.Name = "tbDistinction";
            this.tbDistinction.Size = new System.Drawing.Size(100, 20);
            this.tbDistinction.TabIndex = 20;
            this.tbDistinction.Visible = false;
            this.tbDistinction.MouseMove += new System.Windows.Forms.MouseEventHandler(this.OptionalToolTip);
            // 
            // ImageBlobWriter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(397, 334);
            this.Controls.Add(this.tbDistinction);
            this.Controls.Add(this.lbDistinction);
            this.Controls.Add(this.cbUpdate);
            this.Controls.Add(this.cbCompress);
            this.Controls.Add(this.tbFilePath);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lbField);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnWriteBlob);
            this.Controls.Add(this.btnOpenImage);
            this.Controls.Add(this.btnSaveSettings);
            this.Controls.Add(this.pbImage);
            this.Controls.Add(this.tbTable);
            this.Controls.Add(this.tbUsername);
            this.Controls.Add(this.tbDatabase);
            this.Controls.Add(this.tbField);
            this.Controls.Add(this.tbPassword);
            this.Controls.Add(this.tbServer);
            this.Name = "ImageBlobWriter";
            this.Text = "Image Blob Writer";
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbServer;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.TextBox tbField;
        private System.Windows.Forms.TextBox tbDatabase;
        private System.Windows.Forms.TextBox tbUsername;
        private System.Windows.Forms.TextBox tbTable;
        private System.Windows.Forms.PictureBox pbImage;
        private System.Windows.Forms.Button btnSaveSettings;
        private System.Windows.Forms.Button btnOpenImage;
        private System.Windows.Forms.Button btnWriteBlob;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbField;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbFilePath;
        private System.Windows.Forms.CheckBox cbCompress;
        private System.Windows.Forms.CheckBox cbUpdate;
        private System.Windows.Forms.Label lbDistinction;
        private System.Windows.Forms.TextBox tbDistinction;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}

