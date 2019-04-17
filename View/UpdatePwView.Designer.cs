namespace BibliotechDB.View
{
    partial class UpdatePwView
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
            this.txt_newpw = new System.Windows.Forms.TextBox();
            this.btn_newpwsend = new System.Windows.Forms.Button();
            this.btn_newpwcancel = new System.Windows.Forms.Button();
            this.lbl_NewPassword = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txt_newpw
            // 
            this.txt_newpw.Location = new System.Drawing.Point(112, 40);
            this.txt_newpw.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_newpw.Name = "txt_newpw";
            this.txt_newpw.Size = new System.Drawing.Size(122, 20);
            this.txt_newpw.TabIndex = 0;
            // 
            // btn_newpwsend
            // 
            this.btn_newpwsend.Location = new System.Drawing.Point(149, 81);
            this.btn_newpwsend.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_newpwsend.Name = "btn_newpwsend";
            this.btn_newpwsend.Size = new System.Drawing.Size(85, 21);
            this.btn_newpwsend.TabIndex = 2;
            this.btn_newpwsend.Text = "Byt lösenord";
            this.btn_newpwsend.UseVisualStyleBackColor = true;
            this.btn_newpwsend.Click += new System.EventHandler(this.btn_newpwsend_Click);
            // 
            // btn_newpwcancel
            // 
            this.btn_newpwcancel.Location = new System.Drawing.Point(178, 117);
            this.btn_newpwcancel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_newpwcancel.Name = "btn_newpwcancel";
            this.btn_newpwcancel.Size = new System.Drawing.Size(56, 19);
            this.btn_newpwcancel.TabIndex = 3;
            this.btn_newpwcancel.Text = "Avbryt";
            this.btn_newpwcancel.UseVisualStyleBackColor = true;
            this.btn_newpwcancel.Click += new System.EventHandler(this.btn_newpwcancel_Click);
            // 
            // lbl_NewPassword
            // 
            this.lbl_NewPassword.AutoSize = true;
            this.lbl_NewPassword.Location = new System.Drawing.Point(12, 40);
            this.lbl_NewPassword.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_NewPassword.Name = "lbl_NewPassword";
            this.lbl_NewPassword.Size = new System.Drawing.Size(95, 13);
            this.lbl_NewPassword.TabIndex = 4;
            this.lbl_NewPassword.Text = "Ange nytt lösenord";
            // 
            // UpdatePwView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Snow;
            this.ClientSize = new System.Drawing.Size(250, 158);
            this.Controls.Add(this.lbl_NewPassword);
            this.Controls.Add(this.btn_newpwcancel);
            this.Controls.Add(this.btn_newpwsend);
            this.Controls.Add(this.txt_newpw);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "UpdatePwView";
            this.Text = "Ändra lösenord";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_newpw;
        private System.Windows.Forms.Button btn_newpwsend;
        private System.Windows.Forms.Button btn_newpwcancel;
        private System.Windows.Forms.Label lbl_NewPassword;
    }
}