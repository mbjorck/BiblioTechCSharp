namespace BibliotechDB.View
{
    partial class BibliotechAdminView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BibliotechAdminView));
            this.lbl_SearchISBN = new System.Windows.Forms.Label();
            this.lbl_SearchAuthor = new System.Windows.Forms.Label();
            this.lbl_SearchTitle = new System.Windows.Forms.Label();
            this.btn_search = new System.Windows.Forms.Button();
            this.txt_isbn = new System.Windows.Forms.TextBox();
            this.txt_author = new System.Windows.Forms.TextBox();
            this.txt_title = new System.Windows.Forms.TextBox();
            this.grid_results_adm = new System.Windows.Forms.DataGridView();
            this.lbl_username = new System.Windows.Forms.Label();
            this.lbl_Hej = new System.Windows.Forms.Label();
            this.box_admin = new System.Windows.Forms.GroupBox();
            this.txt_admTrue = new System.Windows.Forms.RadioButton();
            this.txt_admFalse = new System.Windows.Forms.RadioButton();
            this.btn_register = new System.Windows.Forms.Button();
            this.txt_lname = new System.Windows.Forms.TextBox();
            this.txt_pword = new System.Windows.Forms.TextBox();
            this.txt_fname = new System.Windows.Forms.TextBox();
            this.txt_pnr = new System.Windows.Forms.TextBox();
            this.lbl_Author = new System.Windows.Forms.Label();
            this.cmb_authors = new System.Windows.Forms.ComboBox();
            this.lbl_ISBN = new System.Windows.Forms.Label();
            this.lbl_Title = new System.Windows.Forms.Label();
            this.txt_addisbn = new System.Windows.Forms.TextBox();
            this.txt_addtitle = new System.Windows.Forms.TextBox();
            this.txt_newAuthorName = new System.Windows.Forms.TextBox();
            this.lbl_AuthorName = new System.Windows.Forms.Label();
            this.btn_listallAuthors = new System.Windows.Forms.Button();
            this.btn_allusers = new System.Windows.Forms.Button();
            this.btn_allBooks = new System.Windows.Forms.Button();
            this.btn_allLoans = new System.Windows.Forms.Button();
            this.grp_AddUser = new System.Windows.Forms.GroupBox();
            this.lbl_Password = new System.Windows.Forms.Label();
            this.lbl_LastName = new System.Windows.Forms.Label();
            this.lbl_FirstName = new System.Windows.Forms.Label();
            this.lbl_UserID = new System.Windows.Forms.Label();
            this.grp_AddBook = new System.Windows.Forms.GroupBox();
            this.btn_AddAuthor = new System.Windows.Forms.Button();
            this.grp_Search = new System.Windows.Forms.GroupBox();
            this.btn_loan = new System.Windows.Forms.Button();
            this.btn_returnbook = new System.Windows.Forms.Button();
            this.btn_delbook = new System.Windows.Forms.Button();
            this.btn_edituser = new System.Windows.Forms.Button();
            this.btn_deluser = new System.Windows.Forms.Button();
            this.btn_deleteauthor = new System.Windows.Forms.Button();
            this.btn_editauthor = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.pictureBiblioTech = new System.Windows.Forms.PictureBox();
            this.btn_exit = new System.Windows.Forms.Button();
            this.btn_Logout = new System.Windows.Forms.Button();
            this.btn_AddBook = new System.Windows.Forms.Button();
            this.btn_LoanHistory = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grid_results_adm)).BeginInit();
            this.box_admin.SuspendLayout();
            this.grp_AddUser.SuspendLayout();
            this.grp_AddBook.SuspendLayout();
            this.grp_Search.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBiblioTech)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_SearchISBN
            // 
            this.lbl_SearchISBN.AutoSize = true;
            this.lbl_SearchISBN.Location = new System.Drawing.Point(6, 81);
            this.lbl_SearchISBN.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_SearchISBN.Name = "lbl_SearchISBN";
            this.lbl_SearchISBN.Size = new System.Drawing.Size(32, 13);
            this.lbl_SearchISBN.TabIndex = 21;
            this.lbl_SearchISBN.Text = "ISBN";
            // 
            // lbl_SearchAuthor
            // 
            this.lbl_SearchAuthor.AutoSize = true;
            this.lbl_SearchAuthor.Location = new System.Drawing.Point(6, 59);
            this.lbl_SearchAuthor.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_SearchAuthor.Name = "lbl_SearchAuthor";
            this.lbl_SearchAuthor.Size = new System.Drawing.Size(52, 13);
            this.lbl_SearchAuthor.TabIndex = 20;
            this.lbl_SearchAuthor.Text = "Författare";
            // 
            // lbl_SearchTitle
            // 
            this.lbl_SearchTitle.AutoSize = true;
            this.lbl_SearchTitle.Location = new System.Drawing.Point(6, 32);
            this.lbl_SearchTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_SearchTitle.Name = "lbl_SearchTitle";
            this.lbl_SearchTitle.Size = new System.Drawing.Size(27, 13);
            this.lbl_SearchTitle.TabIndex = 19;
            this.lbl_SearchTitle.Text = "Titel";
            // 
            // btn_search
            // 
            this.btn_search.Location = new System.Drawing.Point(174, 110);
            this.btn_search.Margin = new System.Windows.Forms.Padding(2);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(56, 19);
            this.btn_search.TabIndex = 18;
            this.btn_search.Text = "Sök";
            this.btn_search.UseVisualStyleBackColor = true;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // txt_isbn
            // 
            this.txt_isbn.Location = new System.Drawing.Point(64, 78);
            this.txt_isbn.Margin = new System.Windows.Forms.Padding(2);
            this.txt_isbn.Name = "txt_isbn";
            this.txt_isbn.Size = new System.Drawing.Size(167, 20);
            this.txt_isbn.TabIndex = 17;
            // 
            // txt_author
            // 
            this.txt_author.Location = new System.Drawing.Point(64, 55);
            this.txt_author.Margin = new System.Windows.Forms.Padding(2);
            this.txt_author.Name = "txt_author";
            this.txt_author.Size = new System.Drawing.Size(167, 20);
            this.txt_author.TabIndex = 16;
            // 
            // txt_title
            // 
            this.txt_title.Location = new System.Drawing.Point(64, 32);
            this.txt_title.Margin = new System.Windows.Forms.Padding(2);
            this.txt_title.Name = "txt_title";
            this.txt_title.Size = new System.Drawing.Size(167, 20);
            this.txt_title.TabIndex = 15;
            // 
            // grid_results_adm
            // 
            this.grid_results_adm.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grid_results_adm.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_results_adm.Location = new System.Drawing.Point(24, 136);
            this.grid_results_adm.Margin = new System.Windows.Forms.Padding(2);
            this.grid_results_adm.Name = "grid_results_adm";
            this.grid_results_adm.ReadOnly = true;
            this.grid_results_adm.RowHeadersVisible = false;
            this.grid_results_adm.RowTemplate.Height = 24;
            this.grid_results_adm.Size = new System.Drawing.Size(974, 206);
            this.grid_results_adm.TabIndex = 22;
            // 
            // lbl_username
            // 
            this.lbl_username.AutoSize = true;
            this.lbl_username.Font = new System.Drawing.Font("Franklin Gothic Book", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_username.Location = new System.Drawing.Point(55, 101);
            this.lbl_username.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_username.Name = "lbl_username";
            this.lbl_username.Size = new System.Drawing.Size(48, 28);
            this.lbl_username.TabIndex = 24;
            this.lbl_username.Text = "Hej!";
            // 
            // lbl_Hej
            // 
            this.lbl_Hej.AutoSize = true;
            this.lbl_Hej.Font = new System.Drawing.Font("Franklin Gothic Book", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Hej.Location = new System.Drawing.Point(19, 101);
            this.lbl_Hej.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_Hej.Name = "lbl_Hej";
            this.lbl_Hej.Size = new System.Drawing.Size(42, 28);
            this.lbl_Hej.TabIndex = 23;
            this.lbl_Hej.Text = "Hej";
            // 
            // box_admin
            // 
            this.box_admin.Controls.Add(this.txt_admTrue);
            this.box_admin.Controls.Add(this.txt_admFalse);
            this.box_admin.Location = new System.Drawing.Point(268, 47);
            this.box_admin.Margin = new System.Windows.Forms.Padding(2);
            this.box_admin.Name = "box_admin";
            this.box_admin.Padding = new System.Windows.Forms.Padding(2);
            this.box_admin.Size = new System.Drawing.Size(85, 81);
            this.box_admin.TabIndex = 38;
            this.box_admin.TabStop = false;
            this.box_admin.Text = "Admin";
            // 
            // txt_admTrue
            // 
            this.txt_admTrue.AutoSize = true;
            this.txt_admTrue.Location = new System.Drawing.Point(17, 23);
            this.txt_admTrue.Margin = new System.Windows.Forms.Padding(2);
            this.txt_admTrue.Name = "txt_admTrue";
            this.txt_admTrue.Size = new System.Drawing.Size(55, 17);
            this.txt_admTrue.TabIndex = 20;
            this.txt_admTrue.TabStop = true;
            this.txt_admTrue.Text = "TRUE";
            this.txt_admTrue.UseVisualStyleBackColor = true;
            // 
            // txt_admFalse
            // 
            this.txt_admFalse.AutoSize = true;
            this.txt_admFalse.Location = new System.Drawing.Point(17, 45);
            this.txt_admFalse.Margin = new System.Windows.Forms.Padding(2);
            this.txt_admFalse.Name = "txt_admFalse";
            this.txt_admFalse.Size = new System.Drawing.Size(58, 17);
            this.txt_admFalse.TabIndex = 21;
            this.txt_admFalse.TabStop = true;
            this.txt_admFalse.Text = "FALSE";
            this.txt_admFalse.UseVisualStyleBackColor = true;
            // 
            // btn_register
            // 
            this.btn_register.Location = new System.Drawing.Point(189, 141);
            this.btn_register.Margin = new System.Windows.Forms.Padding(2);
            this.btn_register.Name = "btn_register";
            this.btn_register.Size = new System.Drawing.Size(74, 26);
            this.btn_register.TabIndex = 37;
            this.btn_register.Text = "Registrera";
            this.btn_register.UseVisualStyleBackColor = true;
            this.btn_register.Click += new System.EventHandler(this.btn_register_Click);
            // 
            // txt_lname
            // 
            this.txt_lname.Location = new System.Drawing.Point(93, 88);
            this.txt_lname.Margin = new System.Windows.Forms.Padding(2);
            this.txt_lname.Name = "txt_lname";
            this.txt_lname.Size = new System.Drawing.Size(171, 20);
            this.txt_lname.TabIndex = 32;
            // 
            // txt_pword
            // 
            this.txt_pword.Location = new System.Drawing.Point(93, 110);
            this.txt_pword.Margin = new System.Windows.Forms.Padding(2);
            this.txt_pword.Name = "txt_pword";
            this.txt_pword.Size = new System.Drawing.Size(171, 20);
            this.txt_pword.TabIndex = 31;
            // 
            // txt_fname
            // 
            this.txt_fname.Location = new System.Drawing.Point(93, 65);
            this.txt_fname.Margin = new System.Windows.Forms.Padding(2);
            this.txt_fname.Name = "txt_fname";
            this.txt_fname.Size = new System.Drawing.Size(171, 20);
            this.txt_fname.TabIndex = 30;
            // 
            // txt_pnr
            // 
            this.txt_pnr.Location = new System.Drawing.Point(93, 42);
            this.txt_pnr.Margin = new System.Windows.Forms.Padding(2);
            this.txt_pnr.Name = "txt_pnr";
            this.txt_pnr.Size = new System.Drawing.Size(171, 20);
            this.txt_pnr.TabIndex = 29;
            // 
            // lbl_Author
            // 
            this.lbl_Author.AutoSize = true;
            this.lbl_Author.Location = new System.Drawing.Point(15, 85);
            this.lbl_Author.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_Author.Name = "lbl_Author";
            this.lbl_Author.Size = new System.Drawing.Size(55, 13);
            this.lbl_Author.TabIndex = 46;
            this.lbl_Author.Text = "Författare:";
            // 
            // cmb_authors
            // 
            this.cmb_authors.DisplayMember = "AuthorName";
            this.cmb_authors.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_authors.FormattingEnabled = true;
            this.cmb_authors.Location = new System.Drawing.Point(86, 83);
            this.cmb_authors.Margin = new System.Windows.Forms.Padding(2);
            this.cmb_authors.Name = "cmb_authors";
            this.cmb_authors.Size = new System.Drawing.Size(165, 21);
            this.cmb_authors.TabIndex = 45;
            this.cmb_authors.ValueMember = "AuthorID";
            // 
            // lbl_ISBN
            // 
            this.lbl_ISBN.AutoSize = true;
            this.lbl_ISBN.Location = new System.Drawing.Point(14, 60);
            this.lbl_ISBN.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_ISBN.Name = "lbl_ISBN";
            this.lbl_ISBN.Size = new System.Drawing.Size(35, 13);
            this.lbl_ISBN.TabIndex = 43;
            this.lbl_ISBN.Text = "ISBN:";
            // 
            // lbl_Title
            // 
            this.lbl_Title.AutoSize = true;
            this.lbl_Title.Location = new System.Drawing.Point(14, 38);
            this.lbl_Title.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_Title.Name = "lbl_Title";
            this.lbl_Title.Size = new System.Drawing.Size(45, 13);
            this.lbl_Title.TabIndex = 42;
            this.lbl_Title.Text = "Boktitel:";
            // 
            // txt_addisbn
            // 
            this.txt_addisbn.Location = new System.Drawing.Point(86, 58);
            this.txt_addisbn.Margin = new System.Windows.Forms.Padding(2);
            this.txt_addisbn.Name = "txt_addisbn";
            this.txt_addisbn.Size = new System.Drawing.Size(165, 20);
            this.txt_addisbn.TabIndex = 40;
            // 
            // txt_addtitle
            // 
            this.txt_addtitle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_addtitle.Location = new System.Drawing.Point(86, 36);
            this.txt_addtitle.Margin = new System.Windows.Forms.Padding(2);
            this.txt_addtitle.Name = "txt_addtitle";
            this.txt_addtitle.Size = new System.Drawing.Size(165, 20);
            this.txt_addtitle.TabIndex = 39;
            // 
            // txt_newAuthorName
            // 
            this.txt_newAuthorName.Location = new System.Drawing.Point(87, 141);
            this.txt_newAuthorName.Margin = new System.Windows.Forms.Padding(2);
            this.txt_newAuthorName.Name = "txt_newAuthorName";
            this.txt_newAuthorName.Size = new System.Drawing.Size(164, 20);
            this.txt_newAuthorName.TabIndex = 48;
            // 
            // lbl_AuthorName
            // 
            this.lbl_AuthorName.AutoSize = true;
            this.lbl_AuthorName.Location = new System.Drawing.Point(8, 144);
            this.lbl_AuthorName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_AuthorName.Name = "lbl_AuthorName";
            this.lbl_AuthorName.Size = new System.Drawing.Size(75, 13);
            this.lbl_AuthorName.TabIndex = 49;
            this.lbl_AuthorName.Text = "Författarnamn:";
            // 
            // btn_listallAuthors
            // 
            this.btn_listallAuthors.Location = new System.Drawing.Point(558, 104);
            this.btn_listallAuthors.Margin = new System.Windows.Forms.Padding(2);
            this.btn_listallAuthors.Name = "btn_listallAuthors";
            this.btn_listallAuthors.Size = new System.Drawing.Size(118, 28);
            this.btn_listallAuthors.TabIndex = 51;
            this.btn_listallAuthors.Text = "Alla författare";
            this.btn_listallAuthors.UseVisualStyleBackColor = true;
            this.btn_listallAuthors.Click += new System.EventHandler(this.btn_listallAuthors_Click);
            // 
            // btn_allusers
            // 
            this.btn_allusers.Location = new System.Drawing.Point(680, 104);
            this.btn_allusers.Margin = new System.Windows.Forms.Padding(2);
            this.btn_allusers.Name = "btn_allusers";
            this.btn_allusers.Size = new System.Drawing.Size(101, 28);
            this.btn_allusers.TabIndex = 52;
            this.btn_allusers.Text = "Alla användare";
            this.btn_allusers.UseVisualStyleBackColor = true;
            this.btn_allusers.Click += new System.EventHandler(this.btn_allusers_Click);
            // 
            // btn_allBooks
            // 
            this.btn_allBooks.Location = new System.Drawing.Point(786, 104);
            this.btn_allBooks.Margin = new System.Windows.Forms.Padding(2);
            this.btn_allBooks.Name = "btn_allBooks";
            this.btn_allBooks.Size = new System.Drawing.Size(119, 28);
            this.btn_allBooks.TabIndex = 53;
            this.btn_allBooks.Text = "Alla böcker";
            this.btn_allBooks.UseVisualStyleBackColor = true;
            this.btn_allBooks.Click += new System.EventHandler(this.btn_allBooks_Click);
            // 
            // btn_allLoans
            // 
            this.btn_allLoans.Location = new System.Drawing.Point(909, 104);
            this.btn_allLoans.Margin = new System.Windows.Forms.Padding(2);
            this.btn_allLoans.Name = "btn_allLoans";
            this.btn_allLoans.Size = new System.Drawing.Size(89, 28);
            this.btn_allLoans.TabIndex = 54;
            this.btn_allLoans.Text = "Alla lån";
            this.btn_allLoans.UseVisualStyleBackColor = true;
            this.btn_allLoans.Click += new System.EventHandler(this.btn_allLoans_Click);
            // 
            // grp_AddUser
            // 
            this.grp_AddUser.Controls.Add(this.lbl_Password);
            this.grp_AddUser.Controls.Add(this.lbl_LastName);
            this.grp_AddUser.Controls.Add(this.lbl_FirstName);
            this.grp_AddUser.Controls.Add(this.lbl_UserID);
            this.grp_AddUser.Controls.Add(this.txt_fname);
            this.grp_AddUser.Controls.Add(this.txt_lname);
            this.grp_AddUser.Controls.Add(this.txt_pnr);
            this.grp_AddUser.Controls.Add(this.txt_pword);
            this.grp_AddUser.Controls.Add(this.btn_register);
            this.grp_AddUser.Controls.Add(this.box_admin);
            this.grp_AddUser.Location = new System.Drawing.Point(24, 347);
            this.grp_AddUser.Margin = new System.Windows.Forms.Padding(2);
            this.grp_AddUser.Name = "grp_AddUser";
            this.grp_AddUser.Padding = new System.Windows.Forms.Padding(2);
            this.grp_AddUser.Size = new System.Drawing.Size(361, 185);
            this.grp_AddUser.TabIndex = 55;
            this.grp_AddUser.TabStop = false;
            this.grp_AddUser.Text = "Registrera användare";
            // 
            // lbl_Password
            // 
            this.lbl_Password.AutoSize = true;
            this.lbl_Password.Location = new System.Drawing.Point(8, 113);
            this.lbl_Password.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_Password.Name = "lbl_Password";
            this.lbl_Password.Size = new System.Drawing.Size(51, 13);
            this.lbl_Password.TabIndex = 59;
            this.lbl_Password.Text = "Lösenord";
            // 
            // lbl_LastName
            // 
            this.lbl_LastName.AutoSize = true;
            this.lbl_LastName.Location = new System.Drawing.Point(8, 88);
            this.lbl_LastName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_LastName.Name = "lbl_LastName";
            this.lbl_LastName.Size = new System.Drawing.Size(55, 13);
            this.lbl_LastName.TabIndex = 58;
            this.lbl_LastName.Text = "Efternamn";
            // 
            // lbl_FirstName
            // 
            this.lbl_FirstName.AutoSize = true;
            this.lbl_FirstName.Location = new System.Drawing.Point(8, 67);
            this.lbl_FirstName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_FirstName.Name = "lbl_FirstName";
            this.lbl_FirstName.Size = new System.Drawing.Size(51, 13);
            this.lbl_FirstName.TabIndex = 57;
            this.lbl_FirstName.Text = "Förnamn:";
            // 
            // lbl_UserID
            // 
            this.lbl_UserID.AutoSize = true;
            this.lbl_UserID.Location = new System.Drawing.Point(8, 42);
            this.lbl_UserID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_UserID.Name = "lbl_UserID";
            this.lbl_UserID.Size = new System.Drawing.Size(80, 13);
            this.lbl_UserID.TabIndex = 56;
            this.lbl_UserID.Text = "Personnummer:";
            // 
            // grp_AddBook
            // 
            this.grp_AddBook.Controls.Add(this.btn_AddBook);
            this.grp_AddBook.Controls.Add(this.btn_AddAuthor);
            this.grp_AddBook.Controls.Add(this.cmb_authors);
            this.grp_AddBook.Controls.Add(this.txt_addtitle);
            this.grp_AddBook.Controls.Add(this.txt_addisbn);
            this.grp_AddBook.Controls.Add(this.lbl_Title);
            this.grp_AddBook.Controls.Add(this.lbl_ISBN);
            this.grp_AddBook.Controls.Add(this.lbl_Author);
            this.grp_AddBook.Controls.Add(this.lbl_AuthorName);
            this.grp_AddBook.Controls.Add(this.txt_newAuthorName);
            this.grp_AddBook.Location = new System.Drawing.Point(390, 347);
            this.grp_AddBook.Margin = new System.Windows.Forms.Padding(2);
            this.grp_AddBook.Name = "grp_AddBook";
            this.grp_AddBook.Padding = new System.Windows.Forms.Padding(2);
            this.grp_AddBook.Size = new System.Drawing.Size(361, 208);
            this.grp_AddBook.TabIndex = 56;
            this.grp_AddBook.TabStop = false;
            this.grp_AddBook.Text = "Registrera böcker";
            // 
            // btn_AddAuthor
            // 
            this.btn_AddAuthor.Location = new System.Drawing.Point(190, 165);
            this.btn_AddAuthor.Margin = new System.Windows.Forms.Padding(2);
            this.btn_AddAuthor.Name = "btn_AddAuthor";
            this.btn_AddAuthor.Size = new System.Drawing.Size(61, 24);
            this.btn_AddAuthor.TabIndex = 51;
            this.btn_AddAuthor.Text = "Lägg till";
            this.btn_AddAuthor.UseVisualStyleBackColor = true;
            this.btn_AddAuthor.Click += new System.EventHandler(this.btn_AddAuthor_Click);
            // 
            // grp_Search
            // 
            this.grp_Search.Controls.Add(this.txt_title);
            this.grp_Search.Controls.Add(this.txt_author);
            this.grp_Search.Controls.Add(this.txt_isbn);
            this.grp_Search.Controls.Add(this.btn_search);
            this.grp_Search.Controls.Add(this.lbl_SearchTitle);
            this.grp_Search.Controls.Add(this.lbl_SearchAuthor);
            this.grp_Search.Controls.Add(this.lbl_SearchISBN);
            this.grp_Search.Location = new System.Drawing.Point(755, 347);
            this.grp_Search.Margin = new System.Windows.Forms.Padding(2);
            this.grp_Search.Name = "grp_Search";
            this.grp_Search.Padding = new System.Windows.Forms.Padding(2);
            this.grp_Search.Size = new System.Drawing.Size(244, 136);
            this.grp_Search.TabIndex = 57;
            this.grp_Search.TabStop = false;
            this.grp_Search.Text = "Sök i katalogen";
            // 
            // btn_loan
            // 
            this.btn_loan.Location = new System.Drawing.Point(393, 35);
            this.btn_loan.Margin = new System.Windows.Forms.Padding(2);
            this.btn_loan.Name = "btn_loan";
            this.btn_loan.Size = new System.Drawing.Size(56, 28);
            this.btn_loan.TabIndex = 58;
            this.btn_loan.Text = "Låna";
            this.btn_loan.UseVisualStyleBackColor = true;
            this.btn_loan.Click += new System.EventHandler(this.btn_loan_Click);
            // 
            // btn_returnbook
            // 
            this.btn_returnbook.Location = new System.Drawing.Point(453, 35);
            this.btn_returnbook.Margin = new System.Windows.Forms.Padding(2);
            this.btn_returnbook.Name = "btn_returnbook";
            this.btn_returnbook.Size = new System.Drawing.Size(91, 28);
            this.btn_returnbook.TabIndex = 59;
            this.btn_returnbook.Text = "Lämna tillbaka";
            this.btn_returnbook.UseVisualStyleBackColor = true;
            this.btn_returnbook.Click += new System.EventHandler(this.btn_returnbook_Click);
            // 
            // btn_delbook
            // 
            this.btn_delbook.Location = new System.Drawing.Point(317, 34);
            this.btn_delbook.Margin = new System.Windows.Forms.Padding(2);
            this.btn_delbook.Name = "btn_delbook";
            this.btn_delbook.Size = new System.Drawing.Size(71, 28);
            this.btn_delbook.TabIndex = 60;
            this.btn_delbook.Text = "Radera bok";
            this.btn_delbook.UseVisualStyleBackColor = true;
            this.btn_delbook.Click += new System.EventHandler(this.btn_delbook_Click);
            // 
            // btn_edituser
            // 
            this.btn_edituser.Location = new System.Drawing.Point(884, 34);
            this.btn_edituser.Margin = new System.Windows.Forms.Padding(2);
            this.btn_edituser.Name = "btn_edituser";
            this.btn_edituser.Size = new System.Drawing.Size(116, 28);
            this.btn_edituser.TabIndex = 61;
            this.btn_edituser.Text = "Redigera användare";
            this.btn_edituser.UseVisualStyleBackColor = true;
            this.btn_edituser.Click += new System.EventHandler(this.btn_edituser_Click);
            // 
            // btn_deluser
            // 
            this.btn_deluser.Location = new System.Drawing.Point(776, 34);
            this.btn_deluser.Margin = new System.Windows.Forms.Padding(2);
            this.btn_deluser.Name = "btn_deluser";
            this.btn_deluser.Size = new System.Drawing.Size(104, 28);
            this.btn_deluser.TabIndex = 62;
            this.btn_deluser.Text = "Ta bort användare";
            this.btn_deluser.UseVisualStyleBackColor = true;
            this.btn_deluser.Click += new System.EventHandler(this.btn_deluser_Click);
            // 
            // btn_deleteauthor
            // 
            this.btn_deleteauthor.Location = new System.Drawing.Point(548, 34);
            this.btn_deleteauthor.Margin = new System.Windows.Forms.Padding(2);
            this.btn_deleteauthor.Name = "btn_deleteauthor";
            this.btn_deleteauthor.Size = new System.Drawing.Size(98, 28);
            this.btn_deleteauthor.TabIndex = 63;
            this.btn_deleteauthor.Text = "Ta bort författare";
            this.btn_deleteauthor.UseVisualStyleBackColor = true;
            this.btn_deleteauthor.Click += new System.EventHandler(this.btn_deleteauthor_Click);
            // 
            // btn_editauthor
            // 
            this.btn_editauthor.Location = new System.Drawing.Point(651, 34);
            this.btn_editauthor.Margin = new System.Windows.Forms.Padding(2);
            this.btn_editauthor.Name = "btn_editauthor";
            this.btn_editauthor.Size = new System.Drawing.Size(121, 28);
            this.btn_editauthor.TabIndex = 64;
            this.btn_editauthor.Text = "Redigera författare";
            this.btn_editauthor.UseVisualStyleBackColor = true;
            this.btn_editauthor.Click += new System.EventHandler(this.btn_editauthor_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(356, 108);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(93, 17);
            this.label12.TabIndex = 65;
            this.label12.Text = "VÄLJ VIEW:";
            // 
            // pictureBiblioTech
            // 
            this.pictureBiblioTech.Image = ((System.Drawing.Image)(resources.GetObject("pictureBiblioTech.Image")));
            this.pictureBiblioTech.Location = new System.Drawing.Point(24, 12);
            this.pictureBiblioTech.Name = "pictureBiblioTech";
            this.pictureBiblioTech.Size = new System.Drawing.Size(160, 89);
            this.pictureBiblioTech.TabIndex = 66;
            this.pictureBiblioTech.TabStop = false;
            // 
            // btn_exit
            // 
            this.btn_exit.BackColor = System.Drawing.Color.Transparent;
            this.btn_exit.Image = ((System.Drawing.Image)(resources.GetObject("btn_exit.Image")));
            this.btn_exit.Location = new System.Drawing.Point(955, 6);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(45, 23);
            this.btn_exit.TabIndex = 67;
            this.btn_exit.UseVisualStyleBackColor = false;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // btn_Logout
            // 
            this.btn_Logout.Location = new System.Drawing.Point(909, 529);
            this.btn_Logout.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Logout.Name = "btn_Logout";
            this.btn_Logout.Size = new System.Drawing.Size(89, 24);
            this.btn_Logout.TabIndex = 68;
            this.btn_Logout.Text = "Logga ut";
            this.btn_Logout.UseVisualStyleBackColor = true;
            this.btn_Logout.Click += new System.EventHandler(this.btn_Logout_Click);
            // 
            // btn_AddBook
            // 
            this.btn_AddBook.Location = new System.Drawing.Point(188, 110);
            this.btn_AddBook.Margin = new System.Windows.Forms.Padding(2);
            this.btn_AddBook.Name = "btn_AddBook";
            this.btn_AddBook.Size = new System.Drawing.Size(63, 26);
            this.btn_AddBook.TabIndex = 52;
            this.btn_AddBook.Text = "Registrera";
            this.btn_AddBook.UseVisualStyleBackColor = true;
            this.btn_AddBook.Click += new System.EventHandler(this.btn_AddBook_Click);
            // 
            // btn_LoanHistory
            // 
            this.btn_LoanHistory.Location = new System.Drawing.Point(465, 103);
            this.btn_LoanHistory.Margin = new System.Windows.Forms.Padding(2);
            this.btn_LoanHistory.Name = "btn_LoanHistory";
            this.btn_LoanHistory.Size = new System.Drawing.Size(89, 28);
            this.btn_LoanHistory.TabIndex = 69;
            this.btn_LoanHistory.Text = "All lånhistorik";
            this.btn_LoanHistory.UseVisualStyleBackColor = true;
            this.btn_LoanHistory.Click += new System.EventHandler(this.btn_LoanHistory_Click);
            // 
            // BibliotechAdminView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Snow;
            this.ClientSize = new System.Drawing.Size(1016, 564);
            this.Controls.Add(this.btn_LoanHistory);
            this.Controls.Add(this.btn_Logout);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.pictureBiblioTech);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.btn_editauthor);
            this.Controls.Add(this.btn_deleteauthor);
            this.Controls.Add(this.btn_deluser);
            this.Controls.Add(this.btn_edituser);
            this.Controls.Add(this.btn_delbook);
            this.Controls.Add(this.btn_returnbook);
            this.Controls.Add(this.btn_loan);
            this.Controls.Add(this.grp_Search);
            this.Controls.Add(this.grp_AddBook);
            this.Controls.Add(this.grp_AddUser);
            this.Controls.Add(this.btn_allLoans);
            this.Controls.Add(this.btn_allBooks);
            this.Controls.Add(this.btn_allusers);
            this.Controls.Add(this.btn_listallAuthors);
            this.Controls.Add(this.lbl_username);
            this.Controls.Add(this.lbl_Hej);
            this.Controls.Add(this.grid_results_adm);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "BibliotechAdminView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bibliotech administrationssida";
            ((System.ComponentModel.ISupportInitialize)(this.grid_results_adm)).EndInit();
            this.box_admin.ResumeLayout(false);
            this.box_admin.PerformLayout();
            this.grp_AddUser.ResumeLayout(false);
            this.grp_AddUser.PerformLayout();
            this.grp_AddBook.ResumeLayout(false);
            this.grp_AddBook.PerformLayout();
            this.grp_Search.ResumeLayout(false);
            this.grp_Search.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBiblioTech)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbl_SearchISBN;
        private System.Windows.Forms.Label lbl_SearchAuthor;
        private System.Windows.Forms.Label lbl_SearchTitle;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.TextBox txt_isbn;
        private System.Windows.Forms.TextBox txt_author;
        private System.Windows.Forms.TextBox txt_title;
        private System.Windows.Forms.DataGridView grid_results_adm;
        private System.Windows.Forms.Label lbl_username;
        private System.Windows.Forms.Label lbl_Hej;
        private System.Windows.Forms.GroupBox box_admin;
        private System.Windows.Forms.RadioButton txt_admTrue;
        private System.Windows.Forms.RadioButton txt_admFalse;
        private System.Windows.Forms.Button btn_register;
        private System.Windows.Forms.TextBox txt_lname;
        private System.Windows.Forms.TextBox txt_pword;
        private System.Windows.Forms.TextBox txt_fname;
        private System.Windows.Forms.TextBox txt_pnr;
        private System.Windows.Forms.Label lbl_Author;
        private System.Windows.Forms.ComboBox cmb_authors;
        private System.Windows.Forms.Label lbl_ISBN;
        private System.Windows.Forms.Label lbl_Title;
        private System.Windows.Forms.TextBox txt_addisbn;
        private System.Windows.Forms.TextBox txt_addtitle;
        private System.Windows.Forms.TextBox txt_newAuthorName;
        private System.Windows.Forms.Label lbl_AuthorName;
        private System.Windows.Forms.Button btn_listallAuthors;
        private System.Windows.Forms.Button btn_allusers;
        private System.Windows.Forms.Button btn_allBooks;
        private System.Windows.Forms.Button btn_allLoans;
        private System.Windows.Forms.GroupBox grp_AddUser;
        private System.Windows.Forms.Label lbl_UserID;
        private System.Windows.Forms.Label lbl_Password;
        private System.Windows.Forms.Label lbl_LastName;
        private System.Windows.Forms.Label lbl_FirstName;
        private System.Windows.Forms.GroupBox grp_AddBook;
        private System.Windows.Forms.GroupBox grp_Search;
        private System.Windows.Forms.Button btn_loan;
        private System.Windows.Forms.Button btn_returnbook;
        private System.Windows.Forms.Button btn_delbook;
        private System.Windows.Forms.Button btn_edituser;
        private System.Windows.Forms.Button btn_deluser;
        private System.Windows.Forms.Button btn_deleteauthor;
        private System.Windows.Forms.Button btn_editauthor;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.PictureBox pictureBiblioTech;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.Button btn_Logout;
        private System.Windows.Forms.Button btn_AddAuthor;
        private System.Windows.Forms.Button btn_AddBook;
        private System.Windows.Forms.Button btn_LoanHistory;
    }
}