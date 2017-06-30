namespace GM_Torqu_Tool_IF
{
	partial class popToolMng
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
			this.label1 = new System.Windows.Forms.Label();
			this.panel1 = new System.Windows.Forms.Panel();
			this.lstToolName = new System.Windows.Forms.ListView();
			this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.inpTool_No = new Function.form.usrInputBox();
			this.inpTool_Name = new Function.form.usrInputBox();
			this.btnTool_Save = new System.Windows.Forms.Button();
			this.panel2 = new System.Windows.Forms.Panel();
			this.btnRst_Save = new System.Windows.Forms.Button();
			this.inpRst_Name = new Function.form.usrInputBox();
			this.inpRst_No = new Function.form.usrInputBox();
			this.lstRst = new System.Windows.Forms.ListView();
			this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.label2 = new System.Windows.Forms.Label();
			this.btnSave = new System.Windows.Forms.Button();
			this.btnCancel = new System.Windows.Forms.Button();
			this.panel1.SuspendLayout();
			this.panel2.SuspendLayout();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.label1.BackColor = System.Drawing.Color.RoyalBlue;
			this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.label1.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.label1.ForeColor = System.Drawing.Color.White;
			this.label1.Location = new System.Drawing.Point(3, 5);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(335, 23);
			this.label1.TabIndex = 2;
			this.label1.Text = "Tool 이름 관리";
			// 
			// panel1
			// 
			this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel1.Controls.Add(this.btnTool_Save);
			this.panel1.Controls.Add(this.inpTool_Name);
			this.panel1.Controls.Add(this.inpTool_No);
			this.panel1.Controls.Add(this.lstToolName);
			this.panel1.Location = new System.Drawing.Point(3, 28);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(335, 239);
			this.panel1.TabIndex = 4;
			// 
			// lstToolName
			// 
			this.lstToolName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.lstToolName.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
			this.lstToolName.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.lstToolName.FullRowSelect = true;
			this.lstToolName.GridLines = true;
			this.lstToolName.Location = new System.Drawing.Point(3, 3);
			this.lstToolName.MultiSelect = false;
			this.lstToolName.Name = "lstToolName";
			this.lstToolName.Size = new System.Drawing.Size(327, 197);
			this.lstToolName.TabIndex = 3;
			this.lstToolName.UseCompatibleStateImageBehavior = false;
			this.lstToolName.View = System.Windows.Forms.View.Details;
			this.lstToolName.SelectedIndexChanged += new System.EventHandler(this.lstToolName_SelectedIndexChanged);
			// 
			// columnHeader1
			// 
			this.columnHeader1.Width = 0;
			// 
			// columnHeader2
			// 
			this.columnHeader2.Text = "No.";
			this.columnHeader2.Width = 50;
			// 
			// columnHeader3
			// 
			this.columnHeader3.Text = "Tool Name";
			this.columnHeader3.Width = 250;
			// 
			// inpTool_No
			// 
			this.inpTool_No.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.inpTool_No.BackColor = System.Drawing.SystemColors.Control;
			this.inpTool_No.ChangeMark_Visable = false;
			this.inpTool_No.ComboBoxDataSource = null;
			this.inpTool_No.ComboBoxDisplayMember = "";
			this.inpTool_No.ComboBoxDropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.inpTool_No.ComboBoxSelectedValue = null;
			this.inpTool_No.ComboBoxSelectIndex = -1;
			this.inpTool_No.ComboBoxSelectItem = null;
			this.inpTool_No.ComboBoxValueMember = "";
			this.inpTool_No.DLabel_BackColor = System.Drawing.SystemColors.ButtonFace;
			this.inpTool_No.DLabel_Blink = Function.form.usrInputBox.enBlinkType.None;
			this.inpTool_No.DLabel_BlinkColor = System.Drawing.Color.White;
			this.inpTool_No.DLabel_BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.inpTool_No.DLabel_Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.inpTool_No.DLabel_FontAutoSize = false;
			this.inpTool_No.DLabel_ForeColor = System.Drawing.SystemColors.ControlText;
			this.inpTool_No.DLabel_TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.inpTool_No.InputType = Function.form.usrInputBox.enInputType.LABEL;
			this.inpTool_No.Label_BackColor = System.Drawing.Color.Transparent;
			this.inpTool_No.Label_BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.inpTool_No.Label_Font = new System.Drawing.Font("굴림", 9F);
			this.inpTool_No.Label_ForeColor = System.Drawing.SystemColors.ControlText;
			this.inpTool_No.Label_Text = "No";
			this.inpTool_No.Label_TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.inpTool_No.Label_Visable = true;
			this.inpTool_No.LabelWidth = 22;
			this.inpTool_No.Location = new System.Drawing.Point(3, 206);
			this.inpTool_No.Multiline = false;
			this.inpTool_No.Name = "inpTool_No";
			this.inpTool_No.Orientation = System.Windows.Forms.Orientation.Vertical;
			this.inpTool_No.Size = new System.Drawing.Size(68, 23);
			this.inpTool_No.TabIndex = 4;
			this.inpTool_No.Text = "";
			this.inpTool_No.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.inpTool_No.TextBox_AcceptsTab = false;
			this.inpTool_No.TextBox_PasswordChar = '\0';
			this.inpTool_No.TextBox_TabStopsLength = 8;
			this.inpTool_No.TextType = Function.form.usrInputBox.enTextType.All;
			this.inpTool_No.Value = "";
			// 
			// inpTool_Name
			// 
			this.inpTool_Name.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.inpTool_Name.BackColor = System.Drawing.SystemColors.Control;
			this.inpTool_Name.ChangeMark_Visable = true;
			this.inpTool_Name.ComboBoxDataSource = null;
			this.inpTool_Name.ComboBoxDisplayMember = "";
			this.inpTool_Name.ComboBoxDropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.inpTool_Name.ComboBoxSelectedValue = null;
			this.inpTool_Name.ComboBoxSelectIndex = -1;
			this.inpTool_Name.ComboBoxSelectItem = null;
			this.inpTool_Name.ComboBoxValueMember = "";
			this.inpTool_Name.DLabel_BackColor = System.Drawing.SystemColors.ButtonFace;
			this.inpTool_Name.DLabel_Blink = Function.form.usrInputBox.enBlinkType.None;
			this.inpTool_Name.DLabel_BlinkColor = System.Drawing.Color.White;
			this.inpTool_Name.DLabel_BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.inpTool_Name.DLabel_Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.inpTool_Name.DLabel_FontAutoSize = false;
			this.inpTool_Name.DLabel_ForeColor = System.Drawing.SystemColors.ControlText;
			this.inpTool_Name.DLabel_TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.inpTool_Name.InputType = Function.form.usrInputBox.enInputType.TEXTBOX;
			this.inpTool_Name.Label_BackColor = System.Drawing.Color.Transparent;
			this.inpTool_Name.Label_BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.inpTool_Name.Label_Font = new System.Drawing.Font("굴림", 9F);
			this.inpTool_Name.Label_ForeColor = System.Drawing.SystemColors.ControlText;
			this.inpTool_Name.Label_Text = "이름";
			this.inpTool_Name.Label_TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.inpTool_Name.Label_Visable = true;
			this.inpTool_Name.LabelWidth = 30;
			this.inpTool_Name.Location = new System.Drawing.Point(77, 206);
			this.inpTool_Name.Multiline = false;
			this.inpTool_Name.Name = "inpTool_Name";
			this.inpTool_Name.Orientation = System.Windows.Forms.Orientation.Vertical;
			this.inpTool_Name.Size = new System.Drawing.Size(203, 23);
			this.inpTool_Name.TabIndex = 5;
			this.inpTool_Name.Text = "";
			this.inpTool_Name.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.inpTool_Name.TextBox_AcceptsTab = false;
			this.inpTool_Name.TextBox_PasswordChar = '\0';
			this.inpTool_Name.TextBox_TabStopsLength = 8;
			this.inpTool_Name.TextType = Function.form.usrInputBox.enTextType.All;
			this.inpTool_Name.Value = "";
			// 
			// btnTool_Save
			// 
			this.btnTool_Save.Location = new System.Drawing.Point(296, 206);
			this.btnTool_Save.Name = "btnTool_Save";
			this.btnTool_Save.Size = new System.Drawing.Size(32, 23);
			this.btnTool_Save.TabIndex = 6;
			this.btnTool_Save.UseVisualStyleBackColor = true;
			this.btnTool_Save.Click += new System.EventHandler(this.btnTool_Save_Click);
			// 
			// panel2
			// 
			this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel2.Controls.Add(this.btnRst_Save);
			this.panel2.Controls.Add(this.inpRst_Name);
			this.panel2.Controls.Add(this.inpRst_No);
			this.panel2.Controls.Add(this.lstRst);
			this.panel2.Location = new System.Drawing.Point(3, 293);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(335, 130);
			this.panel2.TabIndex = 6;
			// 
			// btnRst_Save
			// 
			this.btnRst_Save.Location = new System.Drawing.Point(296, 98);
			this.btnRst_Save.Name = "btnRst_Save";
			this.btnRst_Save.Size = new System.Drawing.Size(32, 23);
			this.btnRst_Save.TabIndex = 6;
			this.btnRst_Save.UseVisualStyleBackColor = true;
			this.btnRst_Save.Click += new System.EventHandler(this.btnRst_Save_Click);
			// 
			// inpRst_Name
			// 
			this.inpRst_Name.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.inpRst_Name.BackColor = System.Drawing.SystemColors.Control;
			this.inpRst_Name.ChangeMark_Visable = true;
			this.inpRst_Name.ComboBoxDataSource = null;
			this.inpRst_Name.ComboBoxDisplayMember = "";
			this.inpRst_Name.ComboBoxDropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.inpRst_Name.ComboBoxSelectedValue = null;
			this.inpRst_Name.ComboBoxSelectIndex = -1;
			this.inpRst_Name.ComboBoxSelectItem = null;
			this.inpRst_Name.ComboBoxValueMember = "";
			this.inpRst_Name.DLabel_BackColor = System.Drawing.SystemColors.ButtonFace;
			this.inpRst_Name.DLabel_Blink = Function.form.usrInputBox.enBlinkType.None;
			this.inpRst_Name.DLabel_BlinkColor = System.Drawing.Color.White;
			this.inpRst_Name.DLabel_BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.inpRst_Name.DLabel_Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.inpRst_Name.DLabel_FontAutoSize = false;
			this.inpRst_Name.DLabel_ForeColor = System.Drawing.SystemColors.ControlText;
			this.inpRst_Name.DLabel_TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.inpRst_Name.InputType = Function.form.usrInputBox.enInputType.TEXTBOX;
			this.inpRst_Name.Label_BackColor = System.Drawing.Color.Transparent;
			this.inpRst_Name.Label_BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.inpRst_Name.Label_Font = new System.Drawing.Font("굴림", 9F);
			this.inpRst_Name.Label_ForeColor = System.Drawing.SystemColors.ControlText;
			this.inpRst_Name.Label_Text = "이름";
			this.inpRst_Name.Label_TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.inpRst_Name.Label_Visable = true;
			this.inpRst_Name.LabelWidth = 30;
			this.inpRst_Name.Location = new System.Drawing.Point(77, 98);
			this.inpRst_Name.Multiline = false;
			this.inpRst_Name.Name = "inpRst_Name";
			this.inpRst_Name.Orientation = System.Windows.Forms.Orientation.Vertical;
			this.inpRst_Name.Size = new System.Drawing.Size(203, 23);
			this.inpRst_Name.TabIndex = 5;
			this.inpRst_Name.Text = "";
			this.inpRst_Name.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.inpRst_Name.TextBox_AcceptsTab = false;
			this.inpRst_Name.TextBox_PasswordChar = '\0';
			this.inpRst_Name.TextBox_TabStopsLength = 8;
			this.inpRst_Name.TextType = Function.form.usrInputBox.enTextType.All;
			this.inpRst_Name.Value = "";
			// 
			// inpRst_No
			// 
			this.inpRst_No.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.inpRst_No.BackColor = System.Drawing.SystemColors.Control;
			this.inpRst_No.ChangeMark_Visable = false;
			this.inpRst_No.ComboBoxDataSource = null;
			this.inpRst_No.ComboBoxDisplayMember = "";
			this.inpRst_No.ComboBoxDropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.inpRst_No.ComboBoxSelectedValue = null;
			this.inpRst_No.ComboBoxSelectIndex = -1;
			this.inpRst_No.ComboBoxSelectItem = null;
			this.inpRst_No.ComboBoxValueMember = "";
			this.inpRst_No.DLabel_BackColor = System.Drawing.SystemColors.ButtonFace;
			this.inpRst_No.DLabel_Blink = Function.form.usrInputBox.enBlinkType.None;
			this.inpRst_No.DLabel_BlinkColor = System.Drawing.Color.White;
			this.inpRst_No.DLabel_BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.inpRst_No.DLabel_Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.inpRst_No.DLabel_FontAutoSize = false;
			this.inpRst_No.DLabel_ForeColor = System.Drawing.SystemColors.ControlText;
			this.inpRst_No.DLabel_TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.inpRst_No.InputType = Function.form.usrInputBox.enInputType.LABEL;
			this.inpRst_No.Label_BackColor = System.Drawing.Color.Transparent;
			this.inpRst_No.Label_BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.inpRst_No.Label_Font = new System.Drawing.Font("굴림", 9F);
			this.inpRst_No.Label_ForeColor = System.Drawing.SystemColors.ControlText;
			this.inpRst_No.Label_Text = "No";
			this.inpRst_No.Label_TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.inpRst_No.Label_Visable = true;
			this.inpRst_No.LabelWidth = 22;
			this.inpRst_No.Location = new System.Drawing.Point(3, 98);
			this.inpRst_No.Multiline = false;
			this.inpRst_No.Name = "inpRst_No";
			this.inpRst_No.Orientation = System.Windows.Forms.Orientation.Vertical;
			this.inpRst_No.Size = new System.Drawing.Size(68, 23);
			this.inpRst_No.TabIndex = 4;
			this.inpRst_No.Text = "";
			this.inpRst_No.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.inpRst_No.TextBox_AcceptsTab = false;
			this.inpRst_No.TextBox_PasswordChar = '\0';
			this.inpRst_No.TextBox_TabStopsLength = 8;
			this.inpRst_No.TextType = Function.form.usrInputBox.enTextType.All;
			this.inpRst_No.Value = "";
			// 
			// lstRst
			// 
			this.lstRst.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.lstRst.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
			this.lstRst.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.lstRst.FullRowSelect = true;
			this.lstRst.GridLines = true;
			this.lstRst.Location = new System.Drawing.Point(3, 3);
			this.lstRst.MultiSelect = false;
			this.lstRst.Name = "lstRst";
			this.lstRst.Size = new System.Drawing.Size(327, 89);
			this.lstRst.TabIndex = 3;
			this.lstRst.UseCompatibleStateImageBehavior = false;
			this.lstRst.View = System.Windows.Forms.View.Details;
			this.lstRst.SelectedIndexChanged += new System.EventHandler(this.lstRst_SelectedIndexChanged);
			// 
			// columnHeader4
			// 
			this.columnHeader4.Width = 0;
			// 
			// columnHeader5
			// 
			this.columnHeader5.Text = "No.";
			this.columnHeader5.Width = 50;
			// 
			// columnHeader6
			// 
			this.columnHeader6.Text = "결과 이름";
			this.columnHeader6.Width = 250;
			// 
			// label2
			// 
			this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.label2.BackColor = System.Drawing.Color.RoyalBlue;
			this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.label2.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.label2.ForeColor = System.Drawing.Color.White;
			this.label2.Location = new System.Drawing.Point(3, 270);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(335, 23);
			this.label2.TabIndex = 5;
			this.label2.Text = "결과 이름 관리";
			// 
			// btnSave
			// 
			this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnSave.Location = new System.Drawing.Point(268, 425);
			this.btnSave.Name = "btnSave";
			this.btnSave.Size = new System.Drawing.Size(64, 23);
			this.btnSave.TabIndex = 7;
			this.btnSave.Text = "    저 장";
			this.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnSave.UseVisualStyleBackColor = true;
			this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
			// 
			// btnCancel
			// 
			this.btnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnCancel.Location = new System.Drawing.Point(198, 425);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new System.Drawing.Size(64, 23);
			this.btnCancel.TabIndex = 8;
			this.btnCancel.Text = "    취 소";
			this.btnCancel.UseVisualStyleBackColor = true;
			this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
			// 
			// popToolMng
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(340, 452);
			this.Controls.Add(this.btnCancel);
			this.Controls.Add(this.btnSave);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.label1);
			this.isUseFormInit = true;
			this.Name = "popToolMng";
			this.ShowInTaskbar = false;
			this.Text = "Tool 이름 관리";
			this.panel1.ResumeLayout(false);
			this.panel2.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.ListView lstToolName;
		private System.Windows.Forms.ColumnHeader columnHeader1;
		private System.Windows.Forms.ColumnHeader columnHeader2;
		private System.Windows.Forms.ColumnHeader columnHeader3;
		private System.Windows.Forms.Button btnTool_Save;
		private Function.form.usrInputBox inpTool_Name;
		private Function.form.usrInputBox inpTool_No;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Button btnRst_Save;
		private Function.form.usrInputBox inpRst_Name;
		private Function.form.usrInputBox inpRst_No;
		private System.Windows.Forms.ListView lstRst;
		private System.Windows.Forms.ColumnHeader columnHeader4;
		private System.Windows.Forms.ColumnHeader columnHeader5;
		private System.Windows.Forms.ColumnHeader columnHeader6;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button btnSave;
		private System.Windows.Forms.Button btnCancel;
	}
}