﻿namespace MapleShark2.UI {
	partial class SessionInformation {
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
			this.label1 = new System.Windows.Forms.Label();
			this.txtVersion = new System.Windows.Forms.TextBox();
			this.txtLocale = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.txtAdditionalInfo = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.button1 = new System.Windows.Forms.Button();
			this.SuspendLayout();
			//
			// label1
			//
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(16, 21);
			this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(128, 16);
			this.label1.TabIndex = 0;
			this.label1.Text = "MapleStory Version:";
			//
			// txtVersion
			//
			this.txtVersion.Location = new System.Drawing.Point(225, 15);
			this.txtVersion.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.txtVersion.Name = "txtVersion";
			this.txtVersion.ReadOnly = true;
			this.txtVersion.Size = new System.Drawing.Size(132, 22);
			this.txtVersion.TabIndex = 2;
			//
			// txtLocale
			//
			this.txtLocale.Location = new System.Drawing.Point(225, 48);
			this.txtLocale.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.txtLocale.Name = "txtLocale";
			this.txtLocale.ReadOnly = true;
			this.txtLocale.Size = new System.Drawing.Size(132, 22);
			this.txtLocale.TabIndex = 5;
			//
			// label3
			//
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(16, 54);
			this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(123, 16);
			this.label3.TabIndex = 4;
			this.label3.Text = "MapleStory Locale:";
			//
			// txtAdditionalInfo
			//
			this.txtAdditionalInfo.Location = new System.Drawing.Point(20, 106);
			this.txtAdditionalInfo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.txtAdditionalInfo.Multiline = true;
			this.txtAdditionalInfo.Name = "txtAdditionalInfo";
			this.txtAdditionalInfo.ReadOnly = true;
			this.txtAdditionalInfo.ScrollBars = System.Windows.Forms.ScrollBars.Both;
			this.txtAdditionalInfo.Size = new System.Drawing.Size(337, 158);
			this.txtAdditionalInfo.TabIndex = 7;
			//
			// label4
			//
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(16, 86);
			this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(138, 16);
			this.label4.TabIndex = 6;
			this.label4.Text = "Additional Information:";
			//
			// button1
			//
			this.button1.Location = new System.Drawing.Point(20, 272);
			this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(339, 37);
			this.button1.TabIndex = 8;
			this.button1.Text = "Close";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			//
			// SessionInformation
			//
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(368, 324);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.txtAdditionalInfo);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.txtLocale);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.txtVersion);
			this.Controls.Add(this.label1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.Name = "SessionInformation";
			this.Text = "Session Information";
			this.Load += new System.EventHandler(this.SessionInformation_Load);
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Button button1;
		public System.Windows.Forms.TextBox txtVersion;
		public System.Windows.Forms.TextBox txtLocale;
		public System.Windows.Forms.TextBox txtAdditionalInfo;
	}
}