namespace BibliotechDB.View
{
    partial class EditUserView
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
            this.txt_editfname = new System.Windows.Forms.TextBox();
            this.txt_editlname = new System.Windows.Forms.TextBox();
            this.txt_editpw = new System.Windows.Forms.TextBox();
            this.txt_editdebt = new System.Windows.Forms.TextBox();
            this.lbl_FirstName = new System.Windows.Forms.Label();
            this.lbl_LastName = new System.Windows.Forms.Label();
            this.lbl_Password = new System.Windows.Forms.Label();
            this.lbl_Debt = new System.Windows.Forms.Label();
            this.lbl_Header = new System.Windows.Forms.Label();
            this.lbl_Admin = new System.Windows.Forms.Label();
            this.cmb_admin = new System.Windows.Forms.ComboBox();
            this.btn_Update = new System.Windows.Forms.Button();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt_editfname
            // 
            this.txt_editfname.Location = new System.Drawing.Point(130, 37);
            this.txt_editfname.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_editfname.Name = "txt_editfname";
            this.txt_editfname.Size = new System.Drawing.Size(126, 20);
            this.txt_editfname.TabIndex = 2;
            // 
            // txt_editlname
            // 
            this.txt_editlname.Location = new System.Drawing.Point(130, 59);
            this.txt_editlname.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_editlname.Name = "txt_editlname";
            this.txt_editlname.Size = new System.Drawing.Size(126, 20);
            this.txt_editlname.TabIndex = 3;
            // 
            // txt_editpw
            // 
            this.txt_editpw.Location = new System.Drawing.Point(130, 82);
            this.txt_editpw.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_editpw.Name = "txt_editpw";
            this.txt_editpw.Size = new System.Drawing.Size(126, 20);
            this.txt_editpw.TabIndex = 4;
            // 
            // txt_editdebt
            // 
            this.txt_editdebt.Location = new System.Drawing.Point(130, 105);
            this.txt_editdebt.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_editdebt.Name = "txt_editdebt";
            this.txt_editdebt.Size = new System.Drawing.Size(126, 20);
            this.txt_editdebt.TabIndex = 5;
            // 
            // lbl_FirstName
            // 
            this.lbl_FirstName.AutoSize = true;
            this.lbl_FirstName.Location = new System.Drawing.Point(65, 39);
            this.lbl_FirstName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_FirstName.Name = "lbl_FirstName";
            this.lbl_FirstName.Size = new System.Drawing.Size(48, 13);
            this.lbl_FirstName.TabIndex = 6;
            this.lbl_FirstName.Text = "Förnamn";
            // 
            // lbl_LastName
            // 
            this.lbl_LastName.AutoSize = true;
            this.lbl_LastName.Location = new System.Drawing.Point(65, 59);
            this.lbl_LastName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_LastName.Name = "lbl_LastName";
            this.lbl_LastName.Size = new System.Drawing.Size(55, 13);
            this.lbl_LastName.TabIndex = 7;
            this.lbl_LastName.Text = "Efternamn";
            // 
            // lbl_Password
            // 
            this.lbl_Password.AutoSize = true;
            this.lbl_Password.Location = new System.Drawing.Point(65, 82);
            this.lbl_Password.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_Password.Name = "lbl_Password";
            this.lbl_Password.Size = new System.Drawing.Size(51, 13);
            this.lbl_Password.TabIndex = 8;
            this.lbl_Password.Text = "Lösenord";
            // 
            // lbl_Debt
            // 
            this.lbl_Debt.AutoSize = true;
            this.lbl_Debt.Location = new System.Drawing.Point(65, 107);
            this.lbl_Debt.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_Debt.Name = "lbl_Debt";
            this.lbl_Debt.Size = new System.Drawing.Size(34, 13);
            this.lbl_Debt.TabIndex = 9;
            this.lbl_Debt.Text = "Skuld";
            // 
            // lbl_Header
            // 
            this.lbl_Header.AutoSize = true;
            this.lbl_Header.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Header.Location = new System.Drawing.Point(65, 9);
            this.lbl_Header.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_Header.Name = "lbl_Header";
            this.lbl_Header.Size = new System.Drawing.Size(173, 13);
            this.lbl_Header.TabIndex = 10;
            this.lbl_Header.Text = "Uppdatera användaruppgifter";
            // 
            // lbl_Admin
            // 
            this.lbl_Admin.AutoSize = true;
            this.lbl_Admin.Location = new System.Drawing.Point(65, 130);
            this.lbl_Admin.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_Admin.Name = "lbl_Admin";
            this.lbl_Admin.Size = new System.Drawing.Size(42, 13);
            this.lbl_Admin.TabIndex = 12;
            this.lbl_Admin.Text = "Admin?";
            // 
            // cmb_admin
            // 
            this.cmb_admin.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_admin.FormattingEnabled = true;
            this.cmb_admin.Items.AddRange(new object[] {
            "TRUE",
            "FALSE"});
            this.cmb_admin.Location = new System.Drawing.Point(164, 130);
            this.cmb_admin.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmb_admin.Name = "cmb_admin";
            this.cmb_admin.Size = new System.Drawing.Size(92, 21);
            this.cmb_admin.TabIndex = 13;
            // 
            // btn_Update
            // 
            this.btn_Update.Location = new System.Drawing.Point(131, 155);
            this.btn_Update.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Update.Name = "btn_Update";
            this.btn_Update.Size = new System.Drawing.Size(125, 25);
            this.btn_Update.TabIndex = 14;
            this.btn_Update.Text = "Uppdatera uppgifter";
            this.btn_Update.UseVisualStyleBackColor = true;
            this.btn_Update.Click += new System.EventHandler(this.btn_Update_Click);
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.Location = new System.Drawing.Point(200, 197);
            this.btn_Cancel.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(56, 19);
            this.btn_Cancel.TabIndex = 15;
            this.btn_Cancel.Text = "Avbryt";
            this.btn_Cancel.UseVisualStyleBackColor = true;
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // EditUserView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Snow;
            this.ClientSize = new System.Drawing.Size(322, 246);
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.btn_Update);
            this.Controls.Add(this.cmb_admin);
            this.Controls.Add(this.lbl_Admin);
            this.Controls.Add(this.lbl_Header);
            this.Controls.Add(this.lbl_Debt);
            this.Controls.Add(this.lbl_Password);
            this.Controls.Add(this.lbl_LastName);
            this.Controls.Add(this.lbl_FirstName);
            this.Controls.Add(this.txt_editdebt);
            this.Controls.Add(this.txt_editpw);
            this.Controls.Add(this.txt_editlname);
            this.Controls.Add(this.txt_editfname);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "EditUserView";
            this.Text = "Ändra användare";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txt_editfname;
        private System.Windows.Forms.TextBox txt_editlname;
        private System.Windows.Forms.TextBox txt_editpw;
        private System.Windows.Forms.TextBox txt_editdebt;
        private System.Windows.Forms.Label lbl_FirstName;
        private System.Windows.Forms.Label lbl_LastName;
        private System.Windows.Forms.Label lbl_Password;
        private System.Windows.Forms.Label lbl_Debt;
        private System.Windows.Forms.Label lbl_Header;
        private System.Windows.Forms.Label lbl_Admin;
        private System.Windows.Forms.ComboBox cmb_admin;
        private System.Windows.Forms.Button btn_Update;
        private System.Windows.Forms.Button btn_Cancel;
    }
}