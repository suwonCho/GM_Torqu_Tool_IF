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
			this.btnTest = new System.Windows.Forms.Button();
			this.lstMoniLog = new System.Windows.Forms.ListView();
			this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.label1 = new System.Windows.Forms.Label();
			this.tabSearching = new System.Windows.Forms.TabPage();
			this.pnlStatus.SuspendLayout();
			this.tabControl1.SuspendLayout();
			this.tabMonitoring.SuspendLayout();
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
			this.btnSetting.Location = new System.Drawing.Point(1301, 28);
			this.btnSetting.Margin = new System.Windows.Forms.Padding(4);
			this.btnSetting.Name = "btnSetting";
			this.btnSetting.Size = new System.Drawing.Size(112, 34);
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
			this.pnlStatus.Location = new System.Drawing.Point(0, 68);
			this.pnlStatus.Margin = new System.Windows.Forms.Padding(4);
			this.pnlStatus.Name = "pnlStatus";
			this.pnlStatus.Size = new System.Drawing.Size(1419, 67);
			this.pnlStatus.TabIndex = 3;
			// 
			// tabControl1
			// 
			this.tabControl1.Alignment = System.Windows.Forms.TabAlignment.Bottom;
			this.tabControl1.Controls.Add(this.tabMonitoring);
			this.tabControl1.Controls.Add(this.tabSearching);
			this.tabControl1.Location = new System.Drawing.Point(477, 297);
			this.tabControl1.Margin = new System.Windows.Forms.Padding(4);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(942, 546);
			this.tabControl1.TabIndex = 4;
			this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
			// 
			// tabMonitoring
			// 
			this.tabMonitoring.BackColor = System.Drawing.SystemColors.Control;
			this.tabMonitoring.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.tabMonitoring.Controls.Add(this.btnTest);
			this.tabMonitoring.Controls.Add(this.lstMoniLog);
			this.tabMonitoring.Controls.Add(this.label1);
			this.tabMonitoring.Location = new System.Drawing.Point(4, 4);
			this.tabMonitoring.Margin = new System.Windows.Forms.Padding(4);
			this.tabMonitoring.Name = "tabMonitoring";
			this.tabMonitoring.Padding = new System.Windows.Forms.Padding(4);
			this.tabMonitoring.Size = new System.Drawing.Size(934, 517);
			this.tabMonitoring.TabIndex = 0;
			this.tabMonitoring.Text = "모니터링";
			// 
			// btnTest
			// 
			this.btnTest.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnTest.Location = new System.Drawing.Point(850, 485);
			this.btnTest.Name = "btnTest";
			this.btnTest.Size = new System.Drawing.Size(75, 23);
			this.btnTest.TabIndex = 5;
			this.btnTest.Text = "테스트";
			this.btnTest.UseVisualStyleBackColor = true;
			this.btnTest.Click += new System.EventHandler(this.btnTest_Click);
			// 
			// lstMoniLog
			// 
			this.lstMoniLog.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader4,
            this.columnHeader3});
			this.lstMoniLog.FullRowSelect = true;
			this.lstMoniLog.GridLines = true;
			this.lstMoniLog.Location = new System.Drawing.Point(193, 156);
			this.lstMoniLog.MultiSelect = false;
			this.lstMoniLog.Name = "lstMoniLog";
			this.lstMoniLog.Size = new System.Drawing.Size(384, 178);
			this.lstMoniLog.TabIndex = 4;
			this.lstMoniLog.UseCompatibleStateImageBehavior = false;
			this.lstMoniLog.View = System.Windows.Forms.View.Details;
			// 
			// columnHeader1
			// 
			this.columnHeader1.Width = 0;
			// 
			// columnHeader2
			// 
			this.columnHeader2.Text = "처리 시간";
			this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.columnHeader2.Width = 131;
			// 
			// columnHeader4
			// 
			this.columnHeader4.Text = "처리구분";
			this.columnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.columnHeader4.Width = 81;
			// 
			// columnHeader3
			// 
			this.columnHeader3.Text = "내 용";
			this.columnHeader3.Width = 1235;
			// 
			// label1
			// 
			this.label1.BackColor = System.Drawing.Color.DarkGray;
			this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.label1.Dock = System.Windows.Forms.DockStyle.Top;
			this.label1.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.label1.ForeColor = System.Drawing.Color.White;
			this.label1.Location = new System.Drawing.Point(4, 4);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(924, 28);
			this.label1.TabIndex = 3;
			this.label1.Text = "Torque 모니터링";
			// 
			// tabSearching
			// 
			this.tabSearching.BackColor = System.Drawing.SystemColors.Control;
			this.tabSearching.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.tabSearching.Location = new System.Drawing.Point(4, 4);
			this.tabSearching.Margin = new System.Windows.Forms.Padding(4);
			this.tabSearching.Name = "tabSearching";
			this.tabSearching.Padding = new System.Windows.Forms.Padding(4);
			this.tabSearching.Size = new System.Drawing.Size(1411, 679);
			this.tabSearching.TabIndex = 1;
			this.tabSearching.Text = "조 회";
			// 
			// frmMain
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1419, 869);
			this.Controls.Add(this.tabControl1);
			this.Controls.Add(this.pnlStatus);
			this.isUseFormInit = true;
			this.Margin = new System.Windows.Forms.Padding(5);
			this.Name = "frmMain";
			this.Notifyicon_Visible = true;
			this.PromptQuitPgm = true;
			this.SaveConfigFileType = Function.form.enConfigFileType.ConfigXml;
			this.SavePosition = true;
			this.Text = "TorqueTool";
			this.Title_Label = "Torque Tool";
			this.SizeChanged += new System.EventHandler(this.frmMain_SizeChanged);
			this.Controls.SetChildIndex(this.pnlStatus, 0);
			this.Controls.SetChildIndex(this.tabControl1, 0);
			this.pnlStatus.ResumeLayout(false);
			this.tabControl1.ResumeLayout(false);
			this.tabMonitoring.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btnSetting;
		private System.Windows.Forms.Panel pnlStatus;
		private System.Windows.Forms.TabControl tabControl1;
		private System.Windows.Forms.TabPage tabMonitoring;
		private System.Windows.Forms.TabPage tabSearching;
		private System.Windows.Forms.Button btnTest;
		private System.Windows.Forms.ColumnHeader columnHeader1;
		private System.Windows.Forms.ColumnHeader columnHeader2;
		private System.Windows.Forms.ColumnHeader columnHeader3;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ColumnHeader columnHeader4;
		public System.Windows.Forms.ListView lstMoniLog;
	}
}

