namespace GM_Torqu_Tool_IF
{
	partial class frmMain
	{
		/// <summary>
		/// 필수 디자이너 변수입니다.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// 사용 중인 모든 리소스를 정리합니다.
		/// </summary>
		/// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form 디자이너에서 생성한 코드

		/// <summary>
		/// 디자이너 지원에 필요한 메서드입니다. 
		/// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
		/// </summary>
		private void InitializeComponent()
		{
			this.btnSetting = new System.Windows.Forms.Button();
			this.pnlStatus = new System.Windows.Forms.Panel();
			this.tabControl1 = new System.Windows.Forms.TabControl();
			this.tabMonitoring = new System.Windows.Forms.TabPage();
			this.tabSearching = new System.Windows.Forms.TabPage();
			this.pnlStatus.SuspendLayout();
			this.tabControl1.SuspendLayout();
			this.SuspendLayout();
			// 
			// Notifyicon
			// 
			this.Notifyicon.Visible = true;
			// 
			// btnSetting
			// 
			this.btnSetting.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnSetting.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnSetting.Location = new System.Drawing.Point(975, 22);
			this.btnSetting.Name = "btnSetting";
			this.btnSetting.Size = new System.Drawing.Size(84, 27);
			this.btnSetting.TabIndex = 2;
			this.btnSetting.Text = "   환경설정";
			this.btnSetting.UseVisualStyleBackColor = true;
			this.btnSetting.Click += new System.EventHandler(this.btnSetting_Click);
			// 
			// pnlStatus
			// 
			this.pnlStatus.BackColor = System.Drawing.Color.White;
			this.pnlStatus.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.pnlStatus.Controls.Add(this.btnSetting);
			this.pnlStatus.Dock = System.Windows.Forms.DockStyle.Top;
			this.pnlStatus.Location = new System.Drawing.Point(0, 54);
			this.pnlStatus.Name = "pnlStatus";
			this.pnlStatus.Size = new System.Drawing.Size(1064, 54);
			this.pnlStatus.TabIndex = 3;
			// 
			// tabControl1
			// 
			this.tabControl1.Alignment = System.Windows.Forms.TabAlignment.Bottom;
			this.tabControl1.Appearance = System.Windows.Forms.TabAppearance.Buttons;
			this.tabControl1.Controls.Add(this.tabMonitoring);
			this.tabControl1.Controls.Add(this.tabSearching);
			this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tabControl1.Location = new System.Drawing.Point(0, 108);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(1064, 565);
			this.tabControl1.TabIndex = 4;
			// 
			// tabMonitoring
			// 
			this.tabMonitoring.Location = new System.Drawing.Point(4, 4);
			this.tabMonitoring.Name = "tabMonitoring";
			this.tabMonitoring.Padding = new System.Windows.Forms.Padding(3);
			this.tabMonitoring.Size = new System.Drawing.Size(1056, 0);
			this.tabMonitoring.TabIndex = 0;
			this.tabMonitoring.Text = "모니터링";
			this.tabMonitoring.UseVisualStyleBackColor = true;
			// 
			// tabSearching
			// 
			this.tabSearching.Location = new System.Drawing.Point(4, 4);
			this.tabSearching.Name = "tabSearching";
			this.tabSearching.Padding = new System.Windows.Forms.Padding(3);
			this.tabSearching.Size = new System.Drawing.Size(1056, 0);
			this.tabSearching.TabIndex = 1;
			this.tabSearching.Text = "조 회";
			this.tabSearching.UseVisualStyleBackColor = true;
			// 
			// frmMain
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1064, 695);
			this.Controls.Add(this.tabControl1);
			this.Controls.Add(this.pnlStatus);
			this.isUseFormInit = true;
			this.Name = "frmMain";
			this.Notifyicon_Visible = true;
			this.PromptQuitPgm = true;
			this.SaveConfigFileType = Function.form.enConfigFileType.ConfigXml;
			this.SavePosition = true;
			this.Text = "TorqueTool";
			this.Title_Label = "Torque Tool";
			this.Controls.SetChildIndex(this.pnlStatus, 0);
			this.Controls.SetChildIndex(this.tabControl1, 0);
			this.pnlStatus.ResumeLayout(false);
			this.tabControl1.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btnSetting;
		private System.Windows.Forms.Panel pnlStatus;
		private System.Windows.Forms.TabControl tabControl1;
		private System.Windows.Forms.TabPage tabMonitoring;
		private System.Windows.Forms.TabPage tabSearching;
	}
}

