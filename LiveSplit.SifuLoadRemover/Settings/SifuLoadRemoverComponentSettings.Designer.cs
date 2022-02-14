﻿namespace LiveSplit.SifuLoadRemover
{
	partial class SifuLoadRemoverSettings
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

		#region Component Designer generated code

		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            this.lblVersion = new System.Windows.Forms.Label();
            this.processListComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.previewPictureBox = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.croppedPreviewPictureBox = new System.Windows.Forms.PictureBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.updatePreviewButton = new System.Windows.Forms.Button();
            this.scalingLabel = new System.Windows.Forms.Label();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.label5 = new System.Windows.Forms.Label();
            this.gameLanguageComboBox = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.picActualPreview = new System.Windows.Forms.PictureBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.chkAutoSplitterDisableOnSkip = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.autoSplitNameLbl = new System.Windows.Forms.Label();
            this.autoSplitCategoryLbl = new System.Windows.Forms.Label();
            this.enableAutoSplitterChk = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.previewPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.croppedPreviewPictureBox)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picActualPreview)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblVersion
            // 
            this.lblVersion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblVersion.AutoSize = true;
            this.lblVersion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVersion.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lblVersion.Location = new System.Drawing.Point(387, 548);
            this.lblVersion.Name = "lblVersion";
            this.lblVersion.Size = new System.Drawing.Size(37, 13);
            this.lblVersion.TabIndex = 21;
            this.lblVersion.Text = "v0.0.0";
            this.lblVersion.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // processListComboBox
            // 
            this.processListComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.processListComboBox.FormattingEnabled = true;
            this.processListComboBox.Items.AddRange(new object[] {
            "Full Display (Primary)"});
            this.processListComboBox.Location = new System.Drawing.Point(86, 6);
            this.processListComboBox.Name = "processListComboBox";
            this.processListComboBox.Size = new System.Drawing.Size(345, 21);
            this.processListComboBox.TabIndex = 22;
            this.processListComboBox.DropDown += new System.EventHandler(this.processListComboBox_DropDown);
            this.processListComboBox.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 23;
            this.label1.Text = "Capture:";
            // 
            // previewPictureBox
            // 
            this.previewPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.previewPictureBox.Location = new System.Drawing.Point(24, 164);
            this.previewPictureBox.Name = "previewPictureBox";
            this.previewPictureBox.Size = new System.Drawing.Size(400, 180);
            this.previewPictureBox.TabIndex = 24;
            this.previewPictureBox.TabStop = false;
            this.previewPictureBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.previewPictureBox_MouseClick);
            this.previewPictureBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.previewPictureBox_MouseDown);
            this.previewPictureBox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.previewPictureBox_MouseMove);
            this.previewPictureBox.MouseUp += new System.Windows.Forms.MouseEventHandler(this.previewPictureBox_MouseUp);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(20, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 16);
            this.label2.TabIndex = 25;
            this.label2.Text = "Capture Preview";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(21, 149);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(304, 12);
            this.label11.TabIndex = 28;
            this.label11.Text = "Left Click sets top-left corner, right click sets bottom-right corner of region";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(20, 347);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(184, 16);
            this.label4.TabIndex = 30;
            this.label4.Text = "Cropped Capture Preview";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // croppedPreviewPictureBox
            // 
            this.croppedPreviewPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.croppedPreviewPictureBox.Location = new System.Drawing.Point(24, 365);
            this.croppedPreviewPictureBox.Name = "croppedPreviewPictureBox";
            this.croppedPreviewPictureBox.Size = new System.Drawing.Size(400, 180);
            this.croppedPreviewPictureBox.TabIndex = 29;
            this.croppedPreviewPictureBox.TabStop = false;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(476, 746);
            this.tabControl1.TabIndex = 38;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage1.Controls.Add(this.panel1);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.gameLanguageComboBox);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.picActualPreview);
            this.tabPage1.Controls.Add(this.lblVersion);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.croppedPreviewPictureBox);
            this.tabPage1.Controls.Add(this.processListComboBox);
            this.tabPage1.Controls.Add(this.label11);
            this.tabPage1.Controls.Add(this.previewPictureBox);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(468, 720);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Setup";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.updatePreviewButton);
            this.panel1.Controls.Add(this.scalingLabel);
            this.panel1.Controls.Add(this.trackBar1);
            this.panel1.Location = new System.Drawing.Point(24, 71);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(237, 52);
            this.panel1.TabIndex = 43;
            // 
            // updatePreviewButton
            // 
            this.updatePreviewButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updatePreviewButton.Location = new System.Drawing.Point(106, 9);
            this.updatePreviewButton.Name = "updatePreviewButton";
            this.updatePreviewButton.Size = new System.Drawing.Size(65, 33);
            this.updatePreviewButton.TabIndex = 37;
            this.updatePreviewButton.Text = "Update Preview";
            this.updatePreviewButton.UseVisualStyleBackColor = true;
            this.updatePreviewButton.Click += new System.EventHandler(this.updatePreviewButton_Click);
            // 
            // scalingLabel
            // 
            this.scalingLabel.AutoSize = true;
            this.scalingLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scalingLabel.Location = new System.Drawing.Point(9, 3);
            this.scalingLabel.Name = "scalingLabel";
            this.scalingLabel.Size = new System.Drawing.Size(91, 16);
            this.scalingLabel.TabIndex = 32;
            this.scalingLabel.Text = "Scaling: 100%";
            // 
            // trackBar1
            // 
            this.trackBar1.LargeChange = 25;
            this.trackBar1.Location = new System.Drawing.Point(-5, 20);
            this.trackBar1.Margin = new System.Windows.Forms.Padding(2);
            this.trackBar1.Maximum = 201;
            this.trackBar1.Minimum = 100;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(106, 45);
            this.trackBar1.SmallChange = 25;
            this.trackBar1.TabIndex = 31;
            this.trackBar1.TickFrequency = 25;
            this.trackBar1.Value = 100;
            this.trackBar1.ValueChanged += new System.EventHandler(this.trackBar1_ValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(28, 47);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 13);
            this.label5.TabIndex = 42;
            this.label5.Text = "Game Language:";
            // 
            // gameLanguageComboBox
            // 
            this.gameLanguageComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.gameLanguageComboBox.FormattingEnabled = true;
            this.gameLanguageComboBox.Items.AddRange(new object[] {
            "Full Display (Primary)"});
            this.gameLanguageComboBox.Location = new System.Drawing.Point(123, 44);
            this.gameLanguageComboBox.Name = "gameLanguageComboBox";
            this.gameLanguageComboBox.Size = new System.Drawing.Size(308, 21);
            this.gameLanguageComboBox.TabIndex = 41;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(19, 555);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(167, 16);
            this.label7.TabIndex = 40;
            this.label7.Text = "Actual Capture Preview";
            this.label7.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // picActualPreview
            // 
            this.picActualPreview.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picActualPreview.Location = new System.Drawing.Point(23, 573);
            this.picActualPreview.Name = "picActualPreview";
            this.picActualPreview.Size = new System.Drawing.Size(300, 100);
            this.picActualPreview.TabIndex = 39;
            this.picActualPreview.TabStop = false;
            // 
            // tabPage2
            // 
            this.tabPage2.AutoScroll = true;
            this.tabPage2.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage2.Controls.Add(this.chkAutoSplitterDisableOnSkip);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.autoSplitNameLbl);
            this.tabPage2.Controls.Add(this.autoSplitCategoryLbl);
            this.tabPage2.Controls.Add(this.enableAutoSplitterChk);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(468, 720);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "AutoSplitter";
            // 
            // chkAutoSplitterDisableOnSkip
            // 
            this.chkAutoSplitterDisableOnSkip.AutoSize = true;
            this.chkAutoSplitterDisableOnSkip.Location = new System.Drawing.Point(150, 9);
            this.chkAutoSplitterDisableOnSkip.Name = "chkAutoSplitterDisableOnSkip";
            this.chkAutoSplitterDisableOnSkip.Size = new System.Drawing.Size(239, 17);
            this.chkAutoSplitterDisableOnSkip.TabIndex = 43;
            this.chkAutoSplitterDisableOnSkip.Text = "Disable AutoSplitter on Skip until manual Split";
            this.chkAutoSplitterDisableOnSkip.UseVisualStyleBackColor = true;
            this.chkAutoSplitterDisableOnSkip.CheckedChanged += new System.EventHandler(this.chkAutoSplitterDisableOnSkip_CheckedChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(251, 75);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(187, 16);
            this.label6.TabIndex = 42;
            this.label6.Text = "Number of Loads per Split";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(25, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 16);
            this.label3.TabIndex = 41;
            this.label3.Text = "Splits:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // autoSplitNameLbl
            // 
            this.autoSplitNameLbl.AutoSize = true;
            this.autoSplitNameLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.autoSplitNameLbl.Location = new System.Drawing.Point(24, 29);
            this.autoSplitNameLbl.Name = "autoSplitNameLbl";
            this.autoSplitNameLbl.Size = new System.Drawing.Size(48, 16);
            this.autoSplitNameLbl.TabIndex = 40;
            this.autoSplitNameLbl.Text = "Name";
            this.autoSplitNameLbl.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // autoSplitCategoryLbl
            // 
            this.autoSplitCategoryLbl.AutoSize = true;
            this.autoSplitCategoryLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.autoSplitCategoryLbl.Location = new System.Drawing.Point(24, 49);
            this.autoSplitCategoryLbl.Name = "autoSplitCategoryLbl";
            this.autoSplitCategoryLbl.Size = new System.Drawing.Size(70, 16);
            this.autoSplitCategoryLbl.TabIndex = 39;
            this.autoSplitCategoryLbl.Text = "Category";
            this.autoSplitCategoryLbl.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // enableAutoSplitterChk
            // 
            this.enableAutoSplitterChk.AutoSize = true;
            this.enableAutoSplitterChk.Location = new System.Drawing.Point(28, 9);
            this.enableAutoSplitterChk.Name = "enableAutoSplitterChk";
            this.enableAutoSplitterChk.Size = new System.Drawing.Size(116, 17);
            this.enableAutoSplitterChk.TabIndex = 0;
            this.enableAutoSplitterChk.Text = "Enable AutoSplitter";
            this.enableAutoSplitterChk.UseVisualStyleBackColor = true;
            this.enableAutoSplitterChk.CheckedChanged += new System.EventHandler(this.enableAutoSplitterChk_CheckedChanged);
            // 
            // SifuLoadRemoverSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tabControl1);
            this.Name = "SifuLoadRemoverSettings";
            this.Padding = new System.Windows.Forms.Padding(7);
            this.Size = new System.Drawing.Size(443, 710);
            ((System.ComponentModel.ISupportInitialize)(this.previewPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.croppedPreviewPictureBox)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picActualPreview)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.Label lblVersion;
		private System.Windows.Forms.ComboBox processListComboBox;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.PictureBox previewPictureBox;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.PictureBox croppedPreviewPictureBox;
		private System.Windows.Forms.TabControl tabControl1;
		private System.Windows.Forms.TabPage tabPage1;
		private System.Windows.Forms.TabPage tabPage2;
		private System.Windows.Forms.CheckBox enableAutoSplitterChk;
		private System.Windows.Forms.Label autoSplitCategoryLbl;
		private System.Windows.Forms.Label autoSplitNameLbl;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.CheckBox chkAutoSplitterDisableOnSkip;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox picActualPreview;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox gameLanguageComboBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button updatePreviewButton;
        private System.Windows.Forms.Label scalingLabel;
        private System.Windows.Forms.TrackBar trackBar1;
    }
}
