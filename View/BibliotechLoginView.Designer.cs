namespace BibliotechDB.View
{
    partial class BibliotechLoginView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BibliotechLoginView));
            this.lbl_UserID = new System.Windows.Forms.Label();
            this.lbl_Password = new System.Windows.Forms.Label();
            this.txt_UserName = new System.Windows.Forms.TextBox();
            this.txt_Password = new System.Windows.Forms.TextBox();
            this.panelLogin = new System.Windows.Forms.Panel();
            this.btn_Login = new System.Windows.Forms.Button();
            this.lbl_Divider2 = new System.Windows.Forms.Label();
            this.pictureBiblioTech = new System.Windows.Forms.PictureBox();
            this.btn_Exit = new System.Windows.Forms.Button();
            this.lbl_Divider = new System.Windows.Forms.Label();
            this.panelLogin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBiblioTech)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_UserID
            // 
            this.lbl_UserID.AutoSize = true;
            this.lbl_UserID.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_UserID.Location = new System.Drawing.Point(16, 14);
            this.lbl_UserID.Name = "lbl_UserID";
            this.lbl_UserID.Size = new System.Drawing.Size(125, 21);
            this.lbl_UserID.TabIndex = 0;
            this.lbl_UserID.Text = "Personnummer";
            // 
            // lbl_Password
            // 
            this.lbl_Password.AutoSize = true;
            this.lbl_Password.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Password.Location = new System.Drawing.Point(32, 67);
            this.lbl_Password.Name = "lbl_Password";
            this.lbl_Password.Size = new System.Drawing.Size(79, 21);
            this.lbl_Password.TabIndex = 1;
            this.lbl_Password.Text = "Lösenord";
            // 
            // txt_UserName
            // 
            this.txt_UserName.BackColor = System.Drawing.Color.Snow;
            this.txt_UserName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_UserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_UserName.Location = new System.Drawing.Point(20, 37);
            this.txt_UserName.Name = "txt_UserName";
            this.txt_UserName.Size = new System.Drawing.Size(111, 16);
            this.txt_UserName.TabIndex = 1;
            // 
            // txt_Password
            // 
            this.txt_Password.BackColor = System.Drawing.Color.Snow;
            this.txt_Password.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_Password.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Password.Location = new System.Drawing.Point(20, 90);
            this.txt_Password.Name = "txt_Password";
            this.txt_Password.PasswordChar = '*';
            this.txt_Password.Size = new System.Drawing.Size(111, 16);
            this.txt_Password.TabIndex = 2;
            // 
            // panelLogin
            // 
            this.panelLogin.BackColor = System.Drawing.Color.Snow;
            this.panelLogin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelLogin.Controls.Add(this.lbl_Divider);
            this.panelLogin.Controls.Add(this.btn_Login);
            this.panelLogin.Controls.Add(this.lbl_Divider2);
            this.panelLogin.Controls.Add(this.txt_Password);
            this.panelLogin.Controls.Add(this.lbl_UserID);
            this.panelLogin.Controls.Add(this.lbl_Password);
            this.panelLogin.Controls.Add(this.txt_UserName);
            this.panelLogin.Location = new System.Drawing.Point(35, 110);
            this.panelLogin.Name = "panelLogin";
            this.panelLogin.Size = new System.Drawing.Size(148, 177);
            this.panelLogin.TabIndex = 6;
            // 
            // btn_Login
            // 
            this.btn_Login.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Login.Location = new System.Drawing.Point(33, 125);
            this.btn_Login.Name = "btn_Login";
            this.btn_Login.Size = new System.Drawing.Size(85, 34);
            this.btn_Login.TabIndex = 10;
            this.btn_Login.Text = "Logga in";
            this.btn_Login.UseVisualStyleBackColor = true;
            this.btn_Login.Click += new System.EventHandler(this.btn_Login_Click);
            // 
            // lbl_Divider2
            // 
            this.lbl_Divider2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_Divider2.Location = new System.Drawing.Point(20, 109);
            this.lbl_Divider2.Name = "lbl_Divider2";
            this.lbl_Divider2.Size = new System.Drawing.Size(111, 2);
            this.lbl_Divider2.TabIndex = 9;
            // 
            // pictureBiblioTech
            // 
            this.pictureBiblioTech.Image = ((System.Drawing.Image)(resources.GetObject("pictureBiblioTech.Image")));
            this.pictureBiblioTech.Location = new System.Drawing.Point(35, 12);
            this.pictureBiblioTech.Name = "pictureBiblioTech";
            this.pictureBiblioTech.Size = new System.Drawing.Size(148, 92);
            this.pictureBiblioTech.TabIndex = 7;
            this.pictureBiblioTech.TabStop = false;
            // 
            // btn_Exit
            // 
            this.btn_Exit.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Exit.Location = new System.Drawing.Point(69, 301);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(85, 26);
            this.btn_Exit.TabIndex = 8;
            this.btn_Exit.Text = "Avsluta";
            this.btn_Exit.UseVisualStyleBackColor = true;
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // lbl_Divider
            // 
            this.lbl_Divider.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_Divider.Location = new System.Drawing.Point(20, 56);
            this.lbl_Divider.Name = "lbl_Divider";
            this.lbl_Divider.Size = new System.Drawing.Size(111, 2);
            this.lbl_Divider.TabIndex = 11;
            // 
            // BibliotechLoginView
            // 
            this.BackColor = System.Drawing.Color.Snow;
            this.ClientSize = new System.Drawing.Size(224, 339);
            this.Controls.Add(this.btn_Exit);
            this.Controls.Add(this.pictureBiblioTech);
            this.Controls.Add(this.panelLogin);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "BibliotechLoginView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BiblioTech";
            this.panelLogin.ResumeLayout(false);
            this.panelLogin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBiblioTech)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbl_UserID;
        private System.Windows.Forms.Label lbl_Password;
        private System.Windows.Forms.TextBox txt_UserName;
        private System.Windows.Forms.TextBox txt_Password;
        private System.Windows.Forms.Panel panelLogin;
        private System.Windows.Forms.PictureBox pictureBiblioTech;
        private System.Windows.Forms.Label lbl_Divider2;
        private System.Windows.Forms.Button btn_Login;
        private System.Windows.Forms.Button btn_Exit;
        private System.Windows.Forms.Label lbl_Divider;
    }
}