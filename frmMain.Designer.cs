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
			this.SuspendLayout();
			// 
			// Notifyicon
			// 
			this.Notifyicon.Visible = true;
			// 
			// btnSetting
			// 
			this.btnSetting.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnSetting.Location = new System.Drawing.Point(658, 60);
			this.btnSetting.Name = "btnSetting";
			this.btnSetting.Size = new System.Drawing.Size(75, 23);
			this.btnSetting.TabIndex = 2;
			this.btnSetting.Text = "환경설정";
			this.btnSetting.UseVisualStyleBackColor = true;
			this.btnSetting.Click += new System.EventHandler(this.btnSetting_Click);
			// 
			// frmMain
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(745, 440);
			this.Controls.Add(this.btnSetting);
			this.Name = "frmMain";
			this.Notifyicon_Visible = true;
			this.PromptQuitPgm = true;
			this.SaveConfigFileType = Function.form.enConfigFileType.ConfigXml;
			this.SavePosition = true;
			this.Text = "TorqueTool";
			this.Title_Label = "Torque Tool";
			this.Controls.SetChildIndex(this.btnSetting, 0);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btnSetting;
	}
}

