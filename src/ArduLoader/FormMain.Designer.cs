﻿namespace ArduLoader
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.backgroundWorkerUploader = new System.ComponentModel.BackgroundWorker();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.tableLayoutPanelContents = new System.Windows.Forms.TableLayoutPanel();
            this.pictureBoxStatus = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanelContents.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxStatus)).BeginInit();
            this.SuspendLayout();
            // 
            // backgroundWorkerUploader
            // 
            this.backgroundWorkerUploader.WorkerReportsProgress = true;
            this.backgroundWorkerUploader.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorkerUploader_DoWork);
            this.backgroundWorkerUploader.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorkerUploader_ProgressChanged);
            this.backgroundWorkerUploader.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorkerUploader_RunWorkerCompleted);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.buttonCancel.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlText;
            this.buttonCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCancel.Location = new System.Drawing.Point(89, 147);
            this.buttonCancel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(102, 30);
            this.buttonCancel.TabIndex = 0;
            this.buttonCancel.TabStop = false;
            this.buttonCancel.Text = "&Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // tableLayoutPanelContents
            // 
            this.tableLayoutPanelContents.ColumnCount = 1;
            this.tableLayoutPanelContents.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelContents.Controls.Add(this.pictureBoxStatus, 0, 0);
            this.tableLayoutPanelContents.Controls.Add(this.buttonCancel, 0, 1);
            this.tableLayoutPanelContents.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelContents.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanelContents.Name = "tableLayoutPanelContents";
            this.tableLayoutPanelContents.RowCount = 3;
            this.tableLayoutPanelContents.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelContents.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelContents.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableLayoutPanelContents.Size = new System.Drawing.Size(280, 191);
            this.tableLayoutPanelContents.TabIndex = 2;
            // 
            // pictureBoxStatus
            // 
            this.pictureBoxStatus.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.pictureBoxStatus.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxStatus.Image = global::ArduLoader.Properties.Resources.searching;
            this.pictureBoxStatus.Location = new System.Drawing.Point(12, 13);
            this.pictureBoxStatus.Name = "pictureBoxStatus";
            this.pictureBoxStatus.Size = new System.Drawing.Size(256, 127);
            this.pictureBoxStatus.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBoxStatus.TabIndex = 1;
            this.pictureBoxStatus.TabStop = false;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(280, 191);
            this.ControlBox = false;
            this.Controls.Add(this.tableLayoutPanelContents);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Arduboy Upload";
            this.tableLayoutPanelContents.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxStatus)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.ComponentModel.BackgroundWorker backgroundWorkerUploader;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.PictureBox pictureBoxStatus;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelContents;
    }
}
