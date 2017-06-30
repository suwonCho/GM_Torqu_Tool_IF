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
			this.usrInputBox1 = new Function.form.usrInputBox();
			this.btnRun = new System.Windows.Forms.Button();
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
			// usrInputBox1
			// 
			this.usrInputBox1.BackColor = System.Drawing.SystemColors.Control;
			this.usrInputBox1.ChangeMark_Visable = false;
			this.usrInputBox1.ComboBoxDataSource = null;
			this.usrInputBox1.ComboBoxDisplayMember = "";
			this.usrInputBox1.ComboBoxDropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.usrInputBox1.ComboBoxSelectedValue = null;
			this.usrInputBox1.ComboBoxSelectIndex = -1;
			this.usrInputBox1.ComboBoxSelectItem = null;
			this.usrInputBox1.ComboBoxValueMember = "";
			this.usrInputBox1.DLabel_BackColor = System.Drawing.Color.Transparent;
			this.usrInputBox1.DLabel_Blink = Function.form.usrInputBox.enBlinkType.None;
			this.usrInputBox1.DLabel_BlinkColor = System.Drawing.Color.White;
			this.usrInputBox1.DLabel_BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.usrInputBox1.DLabel_Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.usrInputBox1.DLabel_FontAutoSize = false;
			this.usrInputBox1.DLabel_ForeColor = System.Drawing.SystemColors.ControlText;
			this.usrInputBox1.DLabel_TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.usrInputBox1.InputType = Function.form.usrInputBox.enInputType.TEXTBOX;
			this.usrInputBox1.Label_BackColor = System.Drawing.Color.Transparent;
			this.usrInputBox1.Label_BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.usrInputBox1.Label_Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.usrInputBox1.Label_ForeColor = System.Drawing.SystemColors.ControlText;
			this.usrInputBox1.Label_Text = "테스트 횟수(0:무제한)";
			this.usrInputBox1.Label_TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.usrInputBox1.Label_Visable = true;
			this.usrInputBox1.LabelWidth = -1;
			this.usrInputBox1.Location = new System.Drawing.Point(3, 64);
			this.usrInputBox1.Multiline = false;
			this.usrInputBox1.Name = "usrInputBox1";
			this.usrInputBox1.Orientation = System.Windows.Forms.Orientation.Vertical;
			this.usrInputBox1.Size = new System.Drawing.Size(248, 24);
			this.usrInputBox1.TabIndex = 2;
			this.usrInputBox1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.usrInputBox1.TextBox_AcceptsTab = false;
			this.usrInputBox1.TextBox_MaxLength = 32767;
			this.usrInputBox1.TextBox_PasswordChar = '\0';
			this.usrInputBox1.TextBox_TabStopsLength = 8;
			this.usrInputBox1.TextType = Function.form.usrInputBox.enTextType.All;
			this.usrInputBox1.Value = "0";
			// 
			// btnRun
			// 
			this.btnRun.Location = new System.Drawing.Point(196, 94);
			this.btnRun.Name = "btnRun";
			this.btnRun.Size = new System.Drawing.Size(75, 23);
			this.btnRun.TabIndex = 3;
			this.btnRun.Text = "수 행";
			this.btnRun.UseVisualStyleBackColor = true;
			this.btnRun.Click += new System.EventHandler(this.btnRun_Click);
			// 
			// popTest
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(274, 123);
			this.Controls.Add(this.btnRun);
			this.Controls.Add(this.usrInputBox1);
			this.Controls.Add(this.inpSeq);
			this.Controls.Add(this.inpInterval);
			this.Name = "popTest";
			this.Text = "Torque Test";
			this.Load += new System.EventHandler(this.popTest_Load);
			this.ResumeLayout(false);

		}

		#endregion

		private Function.form.usrInputBox inpInterval;
		private Function.form.usrInputBox inpSeq;
		private Function.form.usrInputBox usrInputBox1;
		private System.Windows.Forms.Button btnRun;
	}
}