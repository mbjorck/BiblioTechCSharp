namespace BibliotechDB.View
{
    partial class BibliotechCustView
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BibliotechCustView));
            this.lbl_Hej = new System.Windows.Forms.Label();
            this.lbl_username = new System.Windows.Forms.Label();
            this.lbl_debt = new System.Windows.Forms.Label();
            this.txt_title = new System.Windows.Forms.TextBox();
            this.txt_author = new System.Windows.Forms.TextBox();
            this.txt_isbn = new System.Windows.Forms.TextBox();
            this.btn_search = new System.Windows.Forms.Button();
            this.lbl_Title = new System.Windows.Forms.Label();
            this.lbl_Author = new System.Windows.Forms.Label();
            this.lbl_ISBN = new System.Windows.Forms.Label();
            this.grid_results = new System.Windows.Forms.DataGridView();
            this.bibliotechDBDataSet = new BibliotechDB.BibliotechDBDataSet();
            this.bibliotechDBDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.booksBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.booksTableAdapter = new BibliotechDB.BooksTableAdapter();
            this.booksBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.authorsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.authorsTableAdapter = new BibliotechDB.AuthorsTableAdapter();
            this.txt_temp = new System.Windows.Forms.TextBox();
            this.grp_search = new System.Windows.Forms.GroupBox();
            this.btn_allbooksuser = new System.Windows.Forms.Button();
            this.btn_seeallloans = new System.Windows.Forms.Button();
            this.btn_editmyinfo = new System.Windows.Forms.Button();
            this.btn_userloan = new System.Windows.Forms.Button();
            this.btn_userreturn = new System.Windows.Forms.Button();
            this.btn_Exit = new System.Windows.Forms.Button();
            this.btn_Logout = new System.Windows.Forms.Button();
            this.pictureBiblioTech = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.grid_results)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bibliotechDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bibliotechDBDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.booksBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.booksBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.authorsBindingSource)).BeginInit();
            this.grp_search.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBiblioTech)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_Hej
            // 
            this.lbl_Hej.AutoSize = true;
            this.lbl_Hej.Font = new System.Drawing.Font("Franklin Gothic Book", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Hej.Location = new System.Drawing.Point(28, 98);
            this.lbl_Hej.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_Hej.Name = "lbl_Hej";
            this.lbl_Hej.Size = new System.Drawing.Size(42, 28);
            this.lbl_Hej.TabIndex = 0;
            this.lbl_Hej.Text = "Hej";
            // 
            // lbl_username
            // 
            this.lbl_username.AutoSize = true;
            this.lbl_username.Font = new System.Drawing.Font("Franklin Gothic Book", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_username.Location = new System.Drawing.Point(65, 98);
            this.lbl_username.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_username.Name = "lbl_username";
            this.lbl_username.Size = new System.Drawing.Size(48, 28);
            this.lbl_username.TabIndex = 2;
            this.lbl_username.Text = "Hej!";
            // 
            // lbl_debt
            // 
            this.lbl_debt.AutoSize = true;
            this.lbl_debt.Font = new System.Drawing.Font("Franklin Gothic Book", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_debt.ForeColor = System.Drawing.Color.Maroon;
            this.lbl_debt.Location = new System.Drawing.Point(200, 60);
            this.lbl_debt.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_debt.Name = "lbl_debt";
            this.lbl_debt.Size = new System.Drawing.Size(0, 18);
            this.lbl_debt.TabIndex = 4;
            // 
            // txt_title
            // 
            this.txt_title.Location = new System.Drawing.Point(67, 33);
            this.txt_title.Margin = new System.Windows.Forms.Padding(2);
            this.txt_title.Name = "txt_title";
            this.txt_title.Size = new System.Drawing.Size(167, 20);
            this.txt_title.TabIndex = 7;
            // 
            // txt_author
            // 
            this.txt_author.Location = new System.Drawing.Point(67, 56);
            this.txt_author.Margin = new System.Windows.Forms.Padding(2);
            this.txt_author.Name = "txt_author";
            this.txt_author.Size = new System.Drawing.Size(167, 20);
            this.txt_author.TabIndex = 8;
            // 
            // txt_isbn
            // 
            this.txt_isbn.Location = new System.Drawing.Point(67, 79);
            this.txt_isbn.Margin = new System.Windows.Forms.Padding(2);
            this.txt_isbn.Name = "txt_isbn";
            this.txt_isbn.Size = new System.Drawing.Size(167, 20);
            this.txt_isbn.TabIndex = 9;
            // 
            // btn_search
            // 
            this.btn_search.Location = new System.Drawing.Point(176, 110);
            this.btn_search.Margin = new System.Windows.Forms.Padding(2);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(56, 19);
            this.btn_search.TabIndex = 10;
            this.btn_search.Text = "Sök";
            this.btn_search.UseVisualStyleBackColor = true;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // lbl_Title
            // 
            this.lbl_Title.AutoSize = true;
            this.lbl_Title.Location = new System.Drawing.Point(8, 33);
            this.lbl_Title.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_Title.Name = "lbl_Title";
            this.lbl_Title.Size = new System.Drawing.Size(27, 13);
            this.lbl_Title.TabIndex = 12;
            this.lbl_Title.Text = "Titel";
            // 
            // lbl_Author
            // 
            this.lbl_Author.AutoSize = true;
            this.lbl_Author.Location = new System.Drawing.Point(8, 60);
            this.lbl_Author.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_Author.Name = "lbl_Author";
            this.lbl_Author.Size = new System.Drawing.Size(52, 13);
            this.lbl_Author.TabIndex = 13;
            this.lbl_Author.Text = "Författare";
            // 
            // lbl_ISBN
            // 
            this.lbl_ISBN.AutoSize = true;
            this.lbl_ISBN.Location = new System.Drawing.Point(8, 82);
            this.lbl_ISBN.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_ISBN.Name = "lbl_ISBN";
            this.lbl_ISBN.Size = new System.Drawing.Size(32, 13);
            this.lbl_ISBN.TabIndex = 14;
            this.lbl_ISBN.Text = "ISBN";
            // 
            // grid_results
            // 
            this.grid_results.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grid_results.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_results.Location = new System.Drawing.Point(32, 134);
            this.grid_results.Margin = new System.Windows.Forms.Padding(2);
            this.grid_results.Name = "grid_results";
            this.grid_results.ReadOnly = true;
            this.grid_results.RowHeadersVisible = false;
            this.grid_results.RowTemplate.Height = 24;
            this.grid_results.Size = new System.Drawing.Size(884, 184);
            this.grid_results.TabIndex = 15;
            // 
            // bibliotechDBDataSet
            // 
            this.bibliotechDBDataSet.DataSetName = "BibliotechDBDataSet";
            this.bibliotechDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bibliotechDBDataSetBindingSource
            // 
            this.bibliotechDBDataSetBindingSource.DataSource = this.bibliotechDBDataSet;
            this.bibliotechDBDataSetBindingSource.Position = 0;
            // 
            // booksBindingSource
            // 
            this.booksBindingSource.DataMember = "Books";
            this.booksBindingSource.DataSource = this.bibliotechDBDataSetBindingSource;
            // 
            // booksTableAdapter
            // 
            this.booksTableAdapter.ClearBeforeFill = true;
            // 
            // booksBindingSource1
            // 
            this.booksBindingSource1.DataMember = "Books";
            this.booksBindingSource1.DataSource = this.bibliotechDBDataSetBindingSource;
            // 
            // authorsBindingSource
            // 
            this.authorsBindingSource.DataMember = "Authors";
            this.authorsBindingSource.DataSource = this.bibliotechDBDataSetBindingSource;
            // 
            // authorsTableAdapter
            // 
            this.authorsTableAdapter.ClearBeforeFill = true;
            // 
            // txt_temp
            // 
            this.txt_temp.Location = new System.Drawing.Point(0, 0);
            this.txt_temp.Name = "txt_temp";
            this.txt_temp.Size = new System.Drawing.Size(100, 20);
            this.txt_temp.TabIndex = 0;
            // 
            // grp_search
            // 
            this.grp_search.Controls.Add(this.txt_title);
            this.grp_search.Controls.Add(this.txt_author);
            this.grp_search.Controls.Add(this.lbl_ISBN);
            this.grp_search.Controls.Add(this.txt_isbn);
            this.grp_search.Controls.Add(this.lbl_Author);
            this.grp_search.Controls.Add(this.btn_search);
            this.grp_search.Controls.Add(this.lbl_Title);
            this.grp_search.Location = new System.Drawing.Point(348, 336);
            this.grp_search.Margin = new System.Windows.Forms.Padding(2);
            this.grp_search.Name = "grp_search";
            this.grp_search.Padding = new System.Windows.Forms.Padding(2);
            this.grp_search.Size = new System.Drawing.Size(261, 146);
            this.grp_search.TabIndex = 16;
            this.grp_search.TabStop = false;
            this.grp_search.Text = "Katalogsök";
            // 
            // btn_allbooksuser
            // 
            this.btn_allbooksuser.Location = new System.Drawing.Point(709, 98);
            this.btn_allbooksuser.Margin = new System.Windows.Forms.Padding(2);
            this.btn_allbooksuser.Name = "btn_allbooksuser";
            this.btn_allbooksuser.Size = new System.Drawing.Size(83, 32);
            this.btn_allbooksuser.TabIndex = 17;
            this.btn_allbooksuser.Text = "Se alla böcker";
            this.btn_allbooksuser.UseVisualStyleBackColor = true;
            this.btn_allbooksuser.Click += new System.EventHandler(this.btn_allbooksuser_Click);
            // 
            // btn_seeallloans
            // 
            this.btn_seeallloans.Location = new System.Drawing.Point(622, 98);
            this.btn_seeallloans.Margin = new System.Windows.Forms.Padding(2);
            this.btn_seeallloans.Name = "btn_seeallloans";
            this.btn_seeallloans.Size = new System.Drawing.Size(82, 32);
            this.btn_seeallloans.TabIndex = 18;
            this.btn_seeallloans.Text = "Se mina lån";
            this.btn_seeallloans.UseVisualStyleBackColor = true;
            this.btn_seeallloans.Click += new System.EventHandler(this.btn_seeallloans_Click);
            // 
            // btn_editmyinfo
            // 
            this.btn_editmyinfo.Location = new System.Drawing.Point(815, 98);
            this.btn_editmyinfo.Margin = new System.Windows.Forms.Padding(2);
            this.btn_editmyinfo.Name = "btn_editmyinfo";
            this.btn_editmyinfo.Size = new System.Drawing.Size(100, 32);
            this.btn_editmyinfo.TabIndex = 19;
            this.btn_editmyinfo.Text = "Byt lösenord";
            this.btn_editmyinfo.UseVisualStyleBackColor = true;
            this.btn_editmyinfo.Click += new System.EventHandler(this.btn_editmyinfo_Click);
            // 
            // btn_userloan
            // 
            this.btn_userloan.Location = new System.Drawing.Point(509, 98);
            this.btn_userloan.Margin = new System.Windows.Forms.Padding(2);
            this.btn_userloan.Name = "btn_userloan";
            this.btn_userloan.Size = new System.Drawing.Size(71, 32);
            this.btn_userloan.TabIndex = 20;
            this.btn_userloan.Text = "Låna";
            this.btn_userloan.UseVisualStyleBackColor = true;
            this.btn_userloan.Click += new System.EventHandler(this.btn_userloan_Click);
            // 
            // btn_userreturn
            // 
            this.btn_userreturn.Location = new System.Drawing.Point(415, 98);
            this.btn_userreturn.Margin = new System.Windows.Forms.Padding(2);
            this.btn_userreturn.Name = "btn_userreturn";
            this.btn_userreturn.Size = new System.Drawing.Size(85, 32);
            this.btn_userreturn.TabIndex = 21;
            this.btn_userreturn.Text = "Lämna tillbaka";
            this.btn_userreturn.UseVisualStyleBackColor = true;
            this.btn_userreturn.Click += new System.EventHandler(this.btn_userreturn_Click);
            // 
            // btn_Exit
            // 
            this.btn_Exit.Image = ((System.Drawing.Image)(resources.GetObject("btn_Exit.Image")));
            this.btn_Exit.Location = new System.Drawing.Point(866, 12);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(49, 23);
            this.btn_Exit.TabIndex = 22;
            this.btn_Exit.UseVisualStyleBackColor = true;
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // btn_Logout
            // 
            this.btn_Logout.Location = new System.Drawing.Point(841, 462);
            this.btn_Logout.Name = "btn_Logout";
            this.btn_Logout.Size = new System.Drawing.Size(75, 23);
            this.btn_Logout.TabIndex = 23;
            this.btn_Logout.Text = "Logga ut";
            this.btn_Logout.UseVisualStyleBackColor = true;
            this.btn_Logout.Click += new System.EventHandler(this.btn_Logout_Click);
            // 
            // pictureBiblioTech
            // 
            this.pictureBiblioTech.Image = ((System.Drawing.Image)(resources.GetObject("pictureBiblioTech.Image")));
            this.pictureBiblioTech.Location = new System.Drawing.Point(12, 6);
            this.pictureBiblioTech.Name = "pictureBiblioTech";
            this.pictureBiblioTech.Size = new System.Drawing.Size(160, 89);
            this.pictureBiblioTech.TabIndex = 67;
            this.pictureBiblioTech.TabStop = false;
            // 
            // BibliotechCustView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Snow;
            this.ClientSize = new System.Drawing.Size(944, 497);
            this.Controls.Add(this.pictureBiblioTech);
            this.Controls.Add(this.btn_Logout);
            this.Controls.Add(this.btn_Exit);
            this.Controls.Add(this.btn_userreturn);
            this.Controls.Add(this.btn_userloan);
            this.Controls.Add(this.btn_editmyinfo);
            this.Controls.Add(this.btn_seeallloans);
            this.Controls.Add(this.btn_allbooksuser);
            this.Controls.Add(this.grp_search);
            this.Controls.Add(this.grid_results);
            this.Controls.Add(this.lbl_debt);
            this.Controls.Add(this.lbl_username);
            this.Controls.Add(this.lbl_Hej);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "BibliotechCustView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bibliotech";
            ((System.ComponentModel.ISupportInitialize)(this.grid_results)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bibliotechDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bibliotechDBDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.booksBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.booksBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.authorsBindingSource)).EndInit();
            this.grp_search.ResumeLayout(false);
            this.grp_search.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBiblioTech)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Hej;
        private System.Windows.Forms.Label lbl_username;
        private System.Windows.Forms.Label lbl_debt;
        private System.Windows.Forms.TextBox txt_title;
        private System.Windows.Forms.TextBox txt_author;
        private System.Windows.Forms.TextBox txt_isbn;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.Label lbl_Title;
        private System.Windows.Forms.Label lbl_Author;
        private System.Windows.Forms.Label lbl_ISBN;
        private System.Windows.Forms.DataGridView grid_results;
        private BibliotechDBDataSet bibliotechDBDataSet;
        private System.Windows.Forms.BindingSource bibliotechDBDataSetBindingSource;
        private System.Windows.Forms.BindingSource booksBindingSource;
        private BooksTableAdapter booksTableAdapter;
        private System.Windows.Forms.BindingSource booksBindingSource1;
        private System.Windows.Forms.BindingSource authorsBindingSource;
        private AuthorsTableAdapter authorsTableAdapter;
        private System.Windows.Forms.TextBox txt_temp;
        private System.Windows.Forms.GroupBox grp_search;
        private System.Windows.Forms.Button btn_allbooksuser;
        private System.Windows.Forms.Button btn_seeallloans;
        private System.Windows.Forms.Button btn_editmyinfo;
        private System.Windows.Forms.Button btn_userloan;
        private System.Windows.Forms.Button btn_userreturn;
        private System.Windows.Forms.Button btn_Exit;
        private System.Windows.Forms.Button btn_Logout;
        private System.Windows.Forms.PictureBox pictureBiblioTech;
    }
}