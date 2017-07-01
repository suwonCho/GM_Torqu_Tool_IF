namespace GM_Torqu_Tool_IF
{
	partial class popTest
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
			this.inpInterval = new Function.form.usrInputBox();
			this.inpSeq = new Function.form.usrInputBox();
			this.inpWorkCnt = new Function.form.usrInputBox();
			this.btnRun = new System.Windows.Forms.Button();
			this.inpID = new Function.form.usrInputBox();
			this.SuspendLayout();
			// 
			// inpInterval
			// 
			this.inpInterval.BackColor = System.Drawing.SystemColors.Control;
			this.inpInterval.ChangeMark_Visable = false;
			this.inpInterval.ComboBoxDataSource = null;
			this.inpInterval.ComboBoxDisplayMember = "";
			this.inpInterval.ComboBoxDropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.inpInterval.ComboBoxSelectedValue = null;
			this.inpInterval.ComboBoxSelectIndex = -1;
			this.inpInterval.ComboBoxSelectItem = null;
			this.inpInterval.ComboBoxValueMember = "";
			this.inpInterval.DLabel_BackColor = System.Drawing.Color.Transparent;
			this.inpInterval.DLabel_Blink = Function.form.usrInputBox.enBlinkType.None;
			this.inpInterval.DLabel_BlinkColor = System.Drawing.Color.White;
			this.inpInterval.DLabel_BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.inpInterval.DLabel_Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.inpInterval.DLabel_FontAutoSize = false;
			this.inpInterval.DLabel_ForeColor = System.Drawing.SystemColors.ControlText;
			this.inpInterval.DLabel_TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.inpInterval.InputType = Function.form.usrInputBox.enInputType.TEXTBOX;
			this.inpInterval.Label_BackColor = System.Drawing.Color.Transparent;
			this.inpInterval.Label_BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.inpInterval.Label_Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.inpInterval.Label_ForeColor = System.Drawing.SystemColors.ControlText;
			this.inpInterval.Label_Text = "작업 인터벌(ms)";
			this.inpInterval.Label_TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.inpInterval.Label_Visable = true;
			this.inpInterval.LabelWidth = -1;
			this.inpInterval.Location = new System.Drawing.Point(3, 6);
			this.inpInterval.Multiline = false;
			this.inpInterval.Name = "inpInterval";
			this.inpInterval.Orientation = System.Windows.Forms.Orientation.Vertical;
			this.inpInterval.Size = new System.Drawing.Size(248, 24);
			this.inpInterval.TabIndex = 0;
			this.inpInterval.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.inpInterval.TextBox_AcceptsTab = false;
			this.inpInterval.TextBox_MaxLength = 32767;
			this.inpInterval.TextBox_PasswordChar = '\0';
			this.inpInterval.TextBox_TabStopsLength = 8;
			this.inpInterval.TextType = Function.form.usrInputBox.enTextType.All;
			this.inpInterval.Value = "1000";
			// 
			// inpSeq
			// 
			this.inpSeq.BackColor = System.Drawing.SystemColors.Control;
			this.inpSeq.ChangeMark_Visable = false;
			this.inpSeq.ComboBoxDataSource = null;
			this.inpSeq.ComboBoxDisplayMember = "";
			this.inpSeq.ComboBoxDropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.inpSeq.ComboBoxSelectedValue = null;
			this.inpSeq.ComboBoxSelectIndex = -1;
			this.inpSeq.ComboBoxSelectItem = null;
			this.inpSeq.ComboBoxValueMember = "";
			this.inpSeq.DLabel_BackColor = System.Drawing.Color.Transparent;
			this.inpSeq.DLabel_Blink = Function.form.usrInputBox.enBlinkType.None;
			this.inpSeq.DLabel_BlinkColor = System.Drawing.Color.White;
			this.inpSeq.DLabel_BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.inpSeq.DLabel_Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.inpSeq.DLabel_FontAutoSize = false;
			this.inpSeq.DLabel_ForeColor = System.Drawing.SystemColors.ControlText;
			this.inpSeq.DLabel_TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.inpSeq.InputType = Function.form.usrInputBox.enInputType.TEXTBOX;
			this.inpSeq.Label_BackColor = System.Drawing.Color.Transparent;
			this.inpSeq.Label_BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.inpSeq.Label_Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.inpSeq.Label_ForeColor = System.Drawing.SystemColors.ControlText;
			this.inpSeq.Label_Text = "작업 Seq";
			this.inpSeq.Label_TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.inpSeq.Label_Visable = true;
			this.inpSeq.LabelWidth = -1;
			this.inpSeq.Location = new System.Drawing.Point(3, 34);
			this.inpSeq.Multiline = false;
			this.inpSeq.Name = "inpSeq";
			this.inpSeq.Orientation = System.Windows.Forms.Orientation.Vertical;
			this.inpSeq.Size = new System.Drawing.Size(248, 24);
			this.inpSeq.TabIndex = 1;
			this.inpSeq.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.inpSeq.TextBox_AcceptsTab = false;
			this.inpSeq.TextBox_MaxLength = 4;
			this.inpSeq.TextBox_PasswordChar = '\0';
			this.inpSeq.TextBox_TabStopsLength = 8;
			this.inpSeq.TextType = Function.form.usrInputBox.enTextType.All;
			this.inpSeq.Value = "0";
			// 
			// inpWorkCnt
			// 
			this.inpWorkCnt.BackColor = System.Drawing.SystemColors.Control;
			this.inpWorkCnt.ChangeMark_Visable = false;
			this.inpWorkCnt.ComboBoxDataSource = null;
			this.inpWorkCnt.ComboBoxDisplayMember = "";
			this.inpWorkCnt.ComboBoxDropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.inpWorkCnt.ComboBoxSelectedValue = null;
			this.inpWorkCnt.ComboBoxSelectIndex = -1;
			this.inpWorkCnt.ComboBoxSelectItem = null;
			this.inpWorkCnt.ComboBoxValueMember = "";
			this.inpWorkCnt.DLabel_BackColor = System.Drawing.Color.Transparent;
			this.inpWorkCnt.DLabel_Blink = Function.form.usrInputBox.enBlinkType.None;
			this.inpWorkCnt.DLabel_BlinkColor = System.Drawing.Color.White;
			this.inpWorkCnt.DLabel_BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.inpWorkCnt.DLabel_Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.inpWorkCnt.DLabel_FontAutoSize = false;
			this.inpWorkCnt.DLabel_ForeColor = System.Drawing.SystemColors.ControlText;
			this.inpWorkCnt.DLabel_TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.inpWorkCnt.InputType = Function.form.usrInputBox.enInputType.TEXTBOX;
			this.inpWorkCnt.Label_BackColor = System.Drawing.Color.Transparent;
			this.inpWorkCnt.Label_BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.inpWorkCnt.Label_Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.inpWorkCnt.Label_ForeColor = System.Drawing.SystemColors.ControlText;
			this.inpWorkCnt.Label_Text = "테스트 횟수(0:무제한)";
			this.inpWorkCnt.Label_TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.inpWorkCnt.Label_Visable = true;
			this.inpWorkCnt.LabelWidth = -1;
			this.inpWorkCnt.Location = new System.Drawing.Point(3, 64);
			this.inpWorkCnt.Multiline = false;
			this.inpWorkCnt.Name = "inpWorkCnt";
			this.inpWorkCnt.Orientation = System.Windows.Forms.Orientation.Vertical;
			this.inpWorkCnt.Size = new System.Drawing.Size(248, 24);
			this.inpWorkCnt.TabIndex = 2;
			this.inpWorkCnt.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.inpWorkCnt.TextBox_AcceptsTab = false;
			this.inpWorkCnt.TextBox_MaxLength = 32767;
			this.inpWorkCnt.TextBox_PasswordChar = '\0';
			this.inpWorkCnt.TextBox_TabStopsLength = 8;
			this.inpWorkCnt.TextType = Function.form.usrInputBox.enTextType.All;
			this.inpWorkCnt.Value = "0";
			// 
			// btnRun
			// 
			this.btnRun.Location = new System.Drawing.Point(229, 94);
			this.btnRun.Name = "btnRun";
			this.btnRun.Size = new System.Drawing.Size(42, 23);
			this.btnRun.TabIndex = 3;
			this.btnRun.Text = "수 행";
			this.btnRun.UseVisualStyleBackColor = true;
			this.btnRun.Click += new System.EventHandler(this.btnRun_Click);
			// 
			// inpID
			// 
			this.inpID.BackColor = System.Drawing.SystemColors.Control;
			this.inpID.ChangeMark_Visable = false;
			this.inpID.ComboBoxDataSource = null;
			this.inpID.ComboBoxDisplayMember = "";
			this.inpID.ComboBoxDropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.inpID.ComboBoxSelectedValue = null;
			this.inpID.ComboBoxSelectIndex = -1;
			this.inpID.ComboBoxSelectItem = null;
			this.inpID.ComboBoxValueMember = "";
			this.inpID.DLabel_BackColor = System.Drawing.Color.Transparent;
			this.inpID.DLabel_Blink = Function.form.usrInputBox.enBlinkType.None;
			this.inpID.DLabel_BlinkColor = System.Drawing.Color.White;
			this.inpID.DLabel_BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.inpID.DLabel_Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.inpID.DLabel_FontAutoSize = false;
			this.inpID.DLabel_ForeColor = System.Drawing.SystemColors.ControlText;
			this.inpID.DLabel_TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.inpID.InputType = Function.form.usrInputBox.enInputType.LABEL;
			this.inpID.Label_BackColor = System.Drawing.Color.Transparent;
			this.inpID.Label_BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.inpID.Label_Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.inpID.Label_ForeColor = System.Drawing.SystemColors.ControlText;
			this.inpID.Label_Text = "Trigger / Ack ID";
			this.inpID.Label_TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.inpID.Label_Visable = true;
			this.inpID.LabelWidth = -1;
			this.inpID.Location = new System.Drawing.Point(3, 93);
			this.inpID.Multiline = false;
			this.inpID.Name = "inpID";
			this.inpID.Orientation = System.Windows.Forms.Orientation.Vertical;
			this.inpID.Size = new System.Drawing.Size(220, 23);
			this.inpID.TabIndex = 4;
			this.inpID.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.inpID.TextBox_AcceptsTab = false;
			this.inpID.TextBox_MaxLength = 4;
			this.inpID.TextBox_PasswordChar = '\0';
			this.inpID.TextBox_TabStopsLength = 8;
			this.inpID.TextType = Function.form.usrInputBox.enTextType.All;
			this.inpID.Value = "0 / 0";
			// 
			// popTest
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(274, 123);
			this.Controls.Add(this.inpID);
			this.Controls.Add(this.btnRun);
			this.Controls.Add(this.inpWorkCnt);
			this.Controls.Add(this.inpSeq);
			this.Controls.Add(this.inpInterval);
			this.Name = "popTest";
			this.Text = "Torque Test";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.popTest_FormClosing);
			this.Load += new System.EventHandler(this.popTest_Load);
			this.ResumeLayout(false);

		}

		#endregion

		private Function.form.usrInputBox inpInterval;
		private Function.form.usrInputBox inpSeq;
		private Function.form.usrInputBox inpWorkCnt;
		private System.Windows.Forms.Button btnRun;
		private Function.form.usrInputBox inpID;
	}
}