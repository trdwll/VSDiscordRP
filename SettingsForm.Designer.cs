
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
            this.txtHiddenMessageLine1 = new System.Windows.Forms.TextBox();
            this.cbShowLangImage = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtIdleMessage = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPrefixes = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cbEnabledProject = new System.Windows.Forms.CheckBox();
            this.cbDisplayBuilding = new System.Windows.Forms.CheckBox();
            this.cbShowSolutionName = new System.Windows.Forms.CheckBox();
            this.cbShowFileName = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbHiddenMode = new System.Windows.Forms.CheckBox();
            this.txtProjectHiddenMessageLine1 = new System.Windows.Forms.TextBox();
            this.cbResetTime = new System.Windows.Forms.CheckBox();
            this.cbShowTime = new System.Windows.Forms.CheckBox();
            this.btnSettingsLocation = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtProjectHiddenMessageLine2 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtHiddenMessageLine2 = new System.Windows.Forms.TextBox();
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
            // txtHiddenMessageLine1
            // 
            this.txtHiddenMessageLine1.Location = new System.Drawing.Point(6, 109);
            this.txtHiddenMessageLine1.MaxLength = 100;
            this.txtHiddenMessageLine1.Name = "txtHiddenMessageLine1";
            this.txtHiddenMessageLine1.Size = new System.Drawing.Size(272, 20);
            this.txtHiddenMessageLine1.TabIndex = 4;
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
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtHiddenMessageLine2);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtIdleMessage);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtPrefixes);
            this.groupBox1.Controls.Add(this.cbEnabled);
            this.groupBox1.Controls.Add(this.txtHiddenMessageLine1);
            this.groupBox1.Controls.Add(this.cbShowLangImage);
            this.groupBox1.Controls.Add(this.cbHideUE4);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(284, 250);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Global Settings";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Enabled = false;
            this.label4.Location = new System.Drawing.Point(7, 207);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Idle Message";
            // 
            // txtIdleMessage
            // 
            this.txtIdleMessage.Enabled = false;
            this.txtIdleMessage.Location = new System.Drawing.Point(7, 223);
            this.txtIdleMessage.MaxLength = 500;
            this.txtIdleMessage.Name = "txtIdleMessage";
            this.txtIdleMessage.Size = new System.Drawing.Size(272, 20);
            this.txtIdleMessage.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 168);
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
            this.label1.Size = new System.Drawing.Size(125, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Hidden Message (Line 1)";
            // 
            // txtPrefixes
            // 
            this.txtPrefixes.Location = new System.Drawing.Point(7, 184);
            this.txtPrefixes.MaxLength = 500;
            this.txtPrefixes.Name = "txtPrefixes";
            this.txtPrefixes.Size = new System.Drawing.Size(272, 20);
            this.txtPrefixes.TabIndex = 11;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.txtProjectHiddenMessageLine2);
            this.groupBox2.Controls.Add(this.cbEnabledProject);
            this.groupBox2.Controls.Add(this.cbDisplayBuilding);
            this.groupBox2.Controls.Add(this.cbShowSolutionName);
            this.groupBox2.Controls.Add(this.cbShowFileName);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.cbHiddenMode);
            this.groupBox2.Controls.Add(this.txtProjectHiddenMessageLine1);
            this.groupBox2.Controls.Add(this.cbResetTime);
            this.groupBox2.Controls.Add(this.cbShowTime);
            this.groupBox2.Location = new System.Drawing.Point(12, 268);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(284, 243);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Project Settings";
            // 
            // cbEnabledProject
            // 
            this.cbEnabledProject.AutoSize = true;
            this.cbEnabledProject.Location = new System.Drawing.Point(9, 19);
            this.cbEnabledProject.Name = "cbEnabledProject";
            this.cbEnabledProject.Size = new System.Drawing.Size(138, 17);
            this.cbEnabledProject.TabIndex = 11;
            this.cbEnabledProject.Text = "Rich Presence Enabled";
            this.cbEnabledProject.UseVisualStyleBackColor = true;
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
            this.cbShowSolutionName.Location = new System.Drawing.Point(9, 134);
            this.cbShowSolutionName.Name = "cbShowSolutionName";
            this.cbShowSolutionName.Size = new System.Drawing.Size(125, 17);
            this.cbShowSolutionName.TabIndex = 9;
            this.cbShowSolutionName.Text = "Show Solution Name";
            this.cbShowSolutionName.UseVisualStyleBackColor = true;
            // 
            // cbShowFileName
            // 
            this.cbShowFileName.AutoSize = true;
            this.cbShowFileName.Location = new System.Drawing.Point(9, 111);
            this.cbShowFileName.Name = "cbShowFileName";
            this.cbShowFileName.Size = new System.Drawing.Size(103, 17);
            this.cbShowFileName.TabIndex = 8;
            this.cbShowFileName.Text = "Show File Name";
            this.cbShowFileName.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 157);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Hidden Message (Line 1)";
            // 
            // cbHiddenMode
            // 
            this.cbHiddenMode.AutoSize = true;
            this.cbHiddenMode.Location = new System.Drawing.Point(9, 42);
            this.cbHiddenMode.Name = "cbHiddenMode";
            this.cbHiddenMode.Size = new System.Drawing.Size(90, 17);
            this.cbHiddenMode.TabIndex = 2;
            this.cbHiddenMode.Text = "Hidden Mode";
            this.cbHiddenMode.UseVisualStyleBackColor = true;
            // 
            // txtProjectHiddenMessageLine1
            // 
            this.txtProjectHiddenMessageLine1.Location = new System.Drawing.Point(9, 173);
            this.txtProjectHiddenMessageLine1.MaxLength = 100;
            this.txtProjectHiddenMessageLine1.Name = "txtProjectHiddenMessageLine1";
            this.txtProjectHiddenMessageLine1.Size = new System.Drawing.Size(272, 20);
            this.txtProjectHiddenMessageLine1.TabIndex = 4;
            // 
            // cbResetTime
            // 
            this.cbResetTime.AutoSize = true;
            this.cbResetTime.Location = new System.Drawing.Point(9, 88);
            this.cbResetTime.Name = "cbResetTime";
            this.cbResetTime.Size = new System.Drawing.Size(154, 17);
            this.cbResetTime.TabIndex = 5;
            this.cbResetTime.Text = "Reset Time on File Change";
            this.cbResetTime.UseVisualStyleBackColor = true;
            // 
            // cbShowTime
            // 
            this.cbShowTime.AutoSize = true;
            this.cbShowTime.Location = new System.Drawing.Point(9, 65);
            this.cbShowTime.Name = "cbShowTime";
            this.cbShowTime.Size = new System.Drawing.Size(79, 17);
            this.cbShowTime.TabIndex = 3;
            this.cbShowTime.Text = "Show Time";
            this.cbShowTime.UseVisualStyleBackColor = true;
            // 
            // btnSettingsLocation
            // 
            this.btnSettingsLocation.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSettingsLocation.Location = new System.Drawing.Point(201, 517);
            this.btnSettingsLocation.Name = "btnSettingsLocation";
            this.btnSettingsLocation.Size = new System.Drawing.Size(95, 20);
            this.btnSettingsLocation.TabIndex = 8;
            this.btnSettingsLocation.Text = "Open Settings Location";
            this.btnSettingsLocation.UseVisualStyleBackColor = true;
            this.btnSettingsLocation.Click += new System.EventHandler(this.btnSettingsLocation_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 196);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(125, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Hidden Message (Line 2)";
            // 
            // txtProjectHiddenMessageLine2
            // 
            this.txtProjectHiddenMessageLine2.Location = new System.Drawing.Point(9, 212);
            this.txtProjectHiddenMessageLine2.MaxLength = 100;
            this.txtProjectHiddenMessageLine2.Name = "txtProjectHiddenMessageLine2";
            this.txtProjectHiddenMessageLine2.Size = new System.Drawing.Size(272, 20);
            this.txtProjectHiddenMessageLine2.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 132);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(125, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Hidden Message (Line 2)";
            // 
            // txtHiddenMessageLine2
            // 
            this.txtHiddenMessageLine2.Location = new System.Drawing.Point(6, 148);
            this.txtHiddenMessageLine2.MaxLength = 100;
            this.txtHiddenMessageLine2.Name = "txtHiddenMessageLine2";
            this.txtHiddenMessageLine2.Size = new System.Drawing.Size(272, 20);
            this.txtHiddenMessageLine2.TabIndex = 15;
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(308, 549);
            this.Controls.Add(this.btnSettingsLocation);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SettingsForm";
            this.ShowIcon = false;
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
        private System.Windows.Forms.TextBox txtHiddenMessageLine1;
        private System.Windows.Forms.CheckBox cbShowLangImage;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox cbHiddenMode;
        private System.Windows.Forms.TextBox txtProjectHiddenMessageLine1;
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
        private System.Windows.Forms.CheckBox cbEnabledProject;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtProjectHiddenMessageLine2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtHiddenMessageLine2;
    }
}