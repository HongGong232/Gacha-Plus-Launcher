﻿namespace Gacha_Plus_Launcher
{
    partial class GachaPlusForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GachaPlusForm));
            this.start_button = new System.Windows.Forms.Button();
            this.download_progressBar = new System.Windows.Forms.ProgressBar();
            this.download_label = new System.Windows.Forms.Label();
            this.DragPanel = new System.Windows.Forms.Panel();
            this.Exit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // start_button
            // 
            this.start_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.start_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(0)))), ((int)(((byte)(224)))));
            this.start_button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.start_button.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.start_button.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.start_button.Location = new System.Drawing.Point(502, 343);
            this.start_button.Name = "start_button";
            this.start_button.Size = new System.Drawing.Size(242, 55);
            this.start_button.TabIndex = 0;
            this.start_button.Text = "Start";
            this.start_button.UseVisualStyleBackColor = false;
            this.start_button.Click += new System.EventHandler(this.start_button_Click);
            // 
            // download_progressBar
            // 
            this.download_progressBar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.download_progressBar.Location = new System.Drawing.Point(422, 426);
            this.download_progressBar.Name = "download_progressBar";
            this.download_progressBar.Size = new System.Drawing.Size(400, 23);
            this.download_progressBar.Step = 1;
            this.download_progressBar.TabIndex = 1;
            // 
            // download_label
            // 
            this.download_label.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.download_label.BackColor = System.Drawing.Color.Transparent;
            this.download_label.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.download_label.ForeColor = System.Drawing.Color.White;
            this.download_label.Location = new System.Drawing.Point(419, 400);
            this.download_label.Name = "download_label";
            this.download_label.Size = new System.Drawing.Size(403, 23);
            this.download_label.TabIndex = 2;
            this.download_label.Text = "download_label";
            this.download_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DragPanel
            // 
            this.DragPanel.BackColor = System.Drawing.Color.Transparent;
            this.DragPanel.Location = new System.Drawing.Point(-2, -2);
            this.DragPanel.Name = "DragPanel";
            this.DragPanel.Size = new System.Drawing.Size(837, 56);
            this.DragPanel.TabIndex = 3;
            this.DragPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.DragPanel_MouseDown);
            this.DragPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.DragPanel_MouseMove);
            // 
            // Exit
            // 
            this.Exit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(0)))), ((int)(((byte)(224)))));
            this.Exit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Exit.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Bold);
            this.Exit.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.Exit.Location = new System.Drawing.Point(24, 399);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(149, 55);
            this.Exit.TabIndex = 4;
            this.Exit.Text = "Exit";
            this.Exit.UseVisualStyleBackColor = false;
            this.Exit.Click += new System.EventHandler(this.button1_Click);
            // 
            // GachaPlusForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(834, 461);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.DragPanel);
            this.Controls.Add(this.download_label);
            this.Controls.Add(this.download_progressBar);
            this.Controls.Add(this.start_button);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "GachaPlusForm";
            this.Text = "Gacha Plus Launcher";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button start_button;
        private System.Windows.Forms.ProgressBar download_progressBar;
        private System.Windows.Forms.Label download_label;
        private System.Windows.Forms.Panel DragPanel;
        private System.Windows.Forms.Button Exit;
    }
}

