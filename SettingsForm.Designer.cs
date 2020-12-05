﻿
namespace VSDiscordRP
{
    partial class SettingsForm
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
            this.cbEnabled = new System.Windows.Forms.CheckBox();
            this.cbHideUE4 = new System.Windows.Forms.CheckBox();
            this.txtHiddenMessage = new System.Windows.Forms.TextBox();
            this.cbShowLangImage = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPrefixes = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cbDisplayBuilding = new System.Windows.Forms.CheckBox();
            this.cbShowSolutionName = new System.Windows.Forms.CheckBox();
            this.cbShowFileName = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbHiddenMode = new System.Windows.Forms.CheckBox();
            this.txtProjectHiddenMessage = new System.Windows.Forms.TextBox();
            this.cbResetTime = new System.Windows.Forms.CheckBox();
            this.cbShowTime = new System.Windows.Forms.CheckBox();
            this.btnSettingsLocation = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtIdleMessage = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbEnabled
            // 
            this.cbEnabled.AutoSize = true;
            this.cbEnabled.Location = new System.Drawing.Point(6, 19);
            this.cbEnabled.Name = "cbEnabled";
            this.cbEnabled.Size = new System.Drawing.Size(138, 17);
            this.cbEnabled.TabIndex = 2;
            this.cbEnabled.Text = "Rich Presence Enabled";
            this.cbEnabled.UseVisualStyleBackColor = true;
            // 
            // cbHideUE4
            // 
            this.cbHideUE4.AutoSize = true;
            this.cbHideUE4.Enabled = false;
            this.cbHideUE4.Location = new System.Drawing.Point(6, 42);
            this.cbHideUE4.Name = "cbHideUE4";
            this.cbHideUE4.Size = new System.Drawing.Size(113, 17);
            this.cbHideUE4.TabIndex = 3;
            this.cbHideUE4.Text = "Hide UE4 Projects";
            this.cbHideUE4.UseVisualStyleBackColor = true;
            // 
            // txtHiddenMessage
            // 
            this.txtHiddenMessage.Location = new System.Drawing.Point(6, 109);
            this.txtHiddenMessage.MaxLength = 100;
            this.txtHiddenMessage.Name = "txtHiddenMessage";
            this.txtHiddenMessage.Size = new System.Drawing.Size(272, 20);
            this.txtHiddenMessage.TabIndex = 4;
            // 
            // cbShowLangImage
            // 
            this.cbShowLangImage.AutoSize = true;
            this.cbShowLangImage.Location = new System.Drawing.Point(6, 65);
            this.cbShowLangImage.Name = "cbShowLangImage";
            this.cbShowLangImage.Size = new System.Drawing.Size(136, 17);
            this.cbShowLangImage.TabIndex = 5;
            this.cbShowLangImage.Text = "Show Language Image";
            this.cbShowLangImage.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtIdleMessage);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtPrefixes);
            this.groupBox1.Controls.Add(this.cbEnabled);
            this.groupBox1.Controls.Add(this.txtHiddenMessage);
            this.groupBox1.Controls.Add(this.cbShowLangImage);
            this.groupBox1.Controls.Add(this.cbHideUE4);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(284, 213);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Global Settings";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(137, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Prefixes (comma separated)";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Hidden Message";
            // 
            // txtPrefixes
            // 
            this.txtPrefixes.Location = new System.Drawing.Point(6, 148);
            this.txtPrefixes.MaxLength = 500;
            this.txtPrefixes.Name = "txtPrefixes";
            this.txtPrefixes.Size = new System.Drawing.Size(272, 20);
            this.txtPrefixes.TabIndex = 11;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cbDisplayBuilding);
            this.groupBox2.Controls.Add(this.cbShowSolutionName);
            this.groupBox2.Controls.Add(this.cbShowFileName);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.cbHiddenMode);
            this.groupBox2.Controls.Add(this.txtProjectHiddenMessage);
            this.groupBox2.Controls.Add(this.cbResetTime);
            this.groupBox2.Controls.Add(this.cbShowTime);
            this.groupBox2.Location = new System.Drawing.Point(12, 231);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(284, 182);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Project Settings";
            // 
            // cbDisplayBuilding
            // 
            this.cbDisplayBuilding.AutoSize = true;
            this.cbDisplayBuilding.Location = new System.Drawing.Point(152, 19);
            this.cbDisplayBuilding.Name = "cbDisplayBuilding";
            this.cbDisplayBuilding.Size = new System.Drawing.Size(126, 17);
            this.cbDisplayBuilding.TabIndex = 10;
            this.cbDisplayBuilding.Text = "Show Building Status";
            this.cbDisplayBuilding.UseVisualStyleBackColor = true;
            // 
            // cbShowSolutionName
            // 
            this.cbShowSolutionName.AutoSize = true;
            this.cbShowSolutionName.Location = new System.Drawing.Point(6, 111);
            this.cbShowSolutionName.Name = "cbShowSolutionName";
            this.cbShowSolutionName.Size = new System.Drawing.Size(125, 17);
            this.cbShowSolutionName.TabIndex = 9;
            this.cbShowSolutionName.Text = "Show Solution Name";
            this.cbShowSolutionName.UseVisualStyleBackColor = true;
            // 
            // cbShowFileName
            // 
            this.cbShowFileName.AutoSize = true;
            this.cbShowFileName.Location = new System.Drawing.Point(6, 88);
            this.cbShowFileName.Name = "cbShowFileName";
            this.cbShowFileName.Size = new System.Drawing.Size(103, 17);
            this.cbShowFileName.TabIndex = 8;
            this.cbShowFileName.Text = "Show File Name";
            this.cbShowFileName.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Hidden Message";
            // 
            // cbHiddenMode
            // 
            this.cbHiddenMode.AutoSize = true;
            this.cbHiddenMode.Location = new System.Drawing.Point(6, 19);
            this.cbHiddenMode.Name = "cbHiddenMode";
            this.cbHiddenMode.Size = new System.Drawing.Size(90, 17);
            this.cbHiddenMode.TabIndex = 2;
            this.cbHiddenMode.Text = "Hidden Mode";
            this.cbHiddenMode.UseVisualStyleBackColor = true;
            // 
            // txtProjectHiddenMessage
            // 
            this.txtProjectHiddenMessage.Location = new System.Drawing.Point(6, 150);
            this.txtProjectHiddenMessage.MaxLength = 100;
            this.txtProjectHiddenMessage.Name = "txtProjectHiddenMessage";
            this.txtProjectHiddenMessage.Size = new System.Drawing.Size(272, 20);
            this.txtProjectHiddenMessage.TabIndex = 4;
            // 
            // cbResetTime
            // 
            this.cbResetTime.AutoSize = true;
            this.cbResetTime.Location = new System.Drawing.Point(6, 65);
            this.cbResetTime.Name = "cbResetTime";
            this.cbResetTime.Size = new System.Drawing.Size(154, 17);
            this.cbResetTime.TabIndex = 5;
            this.cbResetTime.Text = "Reset Time on File Change";
            this.cbResetTime.UseVisualStyleBackColor = true;
            // 
            // cbShowTime
            // 
            this.cbShowTime.AutoSize = true;
            this.cbShowTime.Location = new System.Drawing.Point(6, 42);
            this.cbShowTime.Name = "cbShowTime";
            this.cbShowTime.Size = new System.Drawing.Size(79, 17);
            this.cbShowTime.TabIndex = 3;
            this.cbShowTime.Text = "Show Time";
            this.cbShowTime.UseVisualStyleBackColor = true;
            // 
            // btnSettingsLocation
            // 
            this.btnSettingsLocation.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSettingsLocation.Location = new System.Drawing.Point(201, 443);
            this.btnSettingsLocation.Name = "btnSettingsLocation";
            this.btnSettingsLocation.Size = new System.Drawing.Size(95, 20);
            this.btnSettingsLocation.TabIndex = 8;
            this.btnSettingsLocation.Text = "Open Settings Location";
            this.btnSettingsLocation.UseVisualStyleBackColor = true;
            this.btnSettingsLocation.Click += new System.EventHandler(this.btnSettingsLocation_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Enabled = false;
            this.label4.Location = new System.Drawing.Point(6, 171);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Idle Message";
            // 
            // txtIdleMessage
            // 
            this.txtIdleMessage.Enabled = false;
            this.txtIdleMessage.Location = new System.Drawing.Point(6, 187);
            this.txtIdleMessage.MaxLength = 500;
            this.txtIdleMessage.Name = "txtIdleMessage";
            this.txtIdleMessage.Size = new System.Drawing.Size(272, 20);
            this.txtIdleMessage.TabIndex = 13;
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(308, 475);
            this.Controls.Add(this.btnSettingsLocation);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SettingsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Settings";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SettingsForm_FormClosing);
            this.Load += new System.EventHandler(this.SettingsForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.CheckBox cbEnabled;
        private System.Windows.Forms.CheckBox cbHideUE4;
        private System.Windows.Forms.TextBox txtHiddenMessage;
        private System.Windows.Forms.CheckBox cbShowLangImage;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox cbHiddenMode;
        private System.Windows.Forms.TextBox txtProjectHiddenMessage;
        private System.Windows.Forms.CheckBox cbResetTime;
        private System.Windows.Forms.CheckBox cbShowTime;
        private System.Windows.Forms.CheckBox cbShowSolutionName;
        private System.Windows.Forms.CheckBox cbShowFileName;
        private System.Windows.Forms.CheckBox cbDisplayBuilding;
        private System.Windows.Forms.Button btnSettingsLocation;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPrefixes;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtIdleMessage;
    }
}