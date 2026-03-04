namespace Group_Project_1
{
    partial class DataForm
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Label labelSport;
        private System.Windows.Forms.ComboBox comboSports;

        private System.Windows.Forms.Label labelCategory;
        private System.Windows.Forms.ComboBox comboCategory;

        private System.Windows.Forms.Label labelYear;
        private System.Windows.Forms.ComboBox comboYear;

        private System.Windows.Forms.Label labelSearch;
        private System.Windows.Forms.TextBox txtSearch;

        private System.Windows.Forms.Button btnClearSearch;
        private System.Windows.Forms.Button btnGo;

        private System.Windows.Forms.DataGridView dgvData;

        private System.Windows.Forms.Label lblLoggedIn;
        private System.Windows.Forms.Button btnLogOut;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DataForm));
            this.labelSport = new System.Windows.Forms.Label();
            this.comboSports = new System.Windows.Forms.ComboBox();
            this.labelCategory = new System.Windows.Forms.Label();
            this.comboCategory = new System.Windows.Forms.ComboBox();
            this.labelYear = new System.Windows.Forms.Label();
            this.comboYear = new System.Windows.Forms.ComboBox();
            this.labelSearch = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnClearSearch = new System.Windows.Forms.Button();
            this.btnGo = new System.Windows.Forms.Button();
            this.dgvData = new System.Windows.Forms.DataGridView();
            this.lblLoggedIn = new System.Windows.Forms.Label();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.btnUserSettings = new System.Windows.Forms.Button();
            this.gBLeague = new System.Windows.Forms.GroupBox();
            this.labelWeek = new System.Windows.Forms.Label();
            this.comboWeek = new System.Windows.Forms.ComboBox();
            this.tCLeagues = new System.Windows.Forms.TabControl();
            this.tPGames = new System.Windows.Forms.TabPage();
            this.dateTimeGame = new System.Windows.Forms.DateTimePicker();
            this.tBDate = new System.Windows.Forms.TextBox();
            this.tBStatium = new System.Windows.Forms.TextBox();
            this.tBHomeTeam = new System.Windows.Forms.TextBox();
            this.tBAwayTeam = new System.Windows.Forms.TextBox();
            this.tBHomeScore = new System.Windows.Forms.TextBox();
            this.tBAwayScore = new System.Windows.Forms.TextBox();
            this.pictureBoxAway = new System.Windows.Forms.PictureBox();
            this.lblAt = new System.Windows.Forms.Label();
            this.lblVS = new System.Windows.Forms.Label();
            this.pictureBoxHome = new System.Windows.Forms.PictureBox();
            this.listBoxGames = new System.Windows.Forms.ListBox();
            this.lblAway = new System.Windows.Forms.Label();
            this.lblHome = new System.Windows.Forms.Label();
            this.tPTeams = new System.Windows.Forms.TabPage();
            this.tBTeamConference = new System.Windows.Forms.TextBox();
            this.tBTeamDivision = new System.Windows.Forms.TextBox();
            this.tBTeamCity = new System.Windows.Forms.TextBox();
            this.tBTeamLoss = new System.Windows.Forms.TextBox();
            this.tBTeamTies = new System.Windows.Forms.TextBox();
            this.tBTeamWins = new System.Windows.Forms.TextBox();
            this.lblWinLossRating = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lBTopPlayers = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblTeamName = new System.Windows.Forms.Label();
            this.pictureBoxTeamLogo = new System.Windows.Forms.PictureBox();
            this.listBoxTeam = new System.Windows.Forms.ListBox();
            this.tPPlayers = new System.Windows.Forms.TabPage();
            this.groupBoxNBAPlayerStats = new System.Windows.Forms.GroupBox();
            this.label25 = new System.Windows.Forms.Label();
            this.tBNBASteals = new System.Windows.Forms.TextBox();
            this.label26 = new System.Windows.Forms.Label();
            this.tBNBATurnovers = new System.Windows.Forms.TextBox();
            this.label27 = new System.Windows.Forms.Label();
            this.tBNBABlocks = new System.Windows.Forms.TextBox();
            this.label28 = new System.Windows.Forms.Label();
            this.tBNBAFreeThrowsMade = new System.Windows.Forms.TextBox();
            this.label29 = new System.Windows.Forms.Label();
            this.tBNBAFreeThrowsAttempt = new System.Windows.Forms.TextBox();
            this.label30 = new System.Windows.Forms.Label();
            this.tBNBAThreePointers = new System.Windows.Forms.TextBox();
            this.label32 = new System.Windows.Forms.Label();
            this.tBNBARebounds = new System.Windows.Forms.TextBox();
            this.label33 = new System.Windows.Forms.Label();
            this.tBNBAAssists = new System.Windows.Forms.TextBox();
            this.label35 = new System.Windows.Forms.Label();
            this.tBNBAPoints = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.groupBoxNFLPlayerStats = new System.Windows.Forms.GroupBox();
            this.label24 = new System.Windows.Forms.Label();
            this.tBNFLSacks = new System.Windows.Forms.TextBox();
            this.label23 = new System.Windows.Forms.Label();
            this.tBNFLInterceptions = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.tBNFLTackles = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.tBNFLYReceiving = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.tBNFLYRushing = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.tBNFLYPassing = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.tBNFLTDReceiving = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.tBNFLTDRushing = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.tBNFLTDPassing = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.lblPlayerName = new System.Windows.Forms.Label();
            this.tbPlayerPosition = new System.Windows.Forms.TextBox();
            this.tBPlayerTeam = new System.Windows.Forms.TextBox();
            this.cBTeamFilter = new System.Windows.Forms.CheckBox();
            this.comboBoxTeamList = new System.Windows.Forms.ComboBox();
            this.listBoxPlayer = new System.Windows.Forms.ListBox();
            this.pBSport = new System.Windows.Forms.PictureBox();
            this.imageListNFL = new System.Windows.Forms.ImageList(this.components);
            this.imageListNBA = new System.Windows.Forms.ImageList(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).BeginInit();
            this.gBLeague.SuspendLayout();
            this.tCLeagues.SuspendLayout();
            this.tPGames.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAway)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHome)).BeginInit();
            this.tPTeams.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTeamLogo)).BeginInit();
            this.tPPlayers.SuspendLayout();
            this.groupBoxNBAPlayerStats.SuspendLayout();
            this.groupBoxNFLPlayerStats.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBSport)).BeginInit();
            this.SuspendLayout();
            // 
            // labelSport
            // 
            this.labelSport.AutoSize = true;
            this.labelSport.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.labelSport.Location = new System.Drawing.Point(131, 16);
            this.labelSport.Name = "labelSport";
            this.labelSport.Size = new System.Drawing.Size(42, 16);
            this.labelSport.TabIndex = 0;
            this.labelSport.Text = "Sport:";
            // 
            // comboSports
            // 
            this.comboSports.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboSports.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.comboSports.FormattingEnabled = true;
            this.comboSports.Items.AddRange(new object[] {
            "Football",
            "Basketball"});
            this.comboSports.Location = new System.Drawing.Point(186, 13);
            this.comboSports.Name = "comboSports";
            this.comboSports.Size = new System.Drawing.Size(140, 24);
            this.comboSports.TabIndex = 1;
            // 
            // labelCategory
            // 
            this.labelCategory.AutoSize = true;
            this.labelCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.labelCategory.Location = new System.Drawing.Point(346, 16);
            this.labelCategory.Name = "labelCategory";
            this.labelCategory.Size = new System.Drawing.Size(65, 16);
            this.labelCategory.TabIndex = 2;
            this.labelCategory.Text = "Category:";
            this.labelCategory.Visible = false;
            // 
            // comboCategory
            // 
            this.comboCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.comboCategory.FormattingEnabled = true;
            this.comboCategory.Items.AddRange(new object[] {
            "Teams",
            "Standings",
            "Games",
            "Players"});
            this.comboCategory.Location = new System.Drawing.Point(431, 13);
            this.comboCategory.Name = "comboCategory";
            this.comboCategory.Size = new System.Drawing.Size(140, 24);
            this.comboCategory.TabIndex = 3;
            this.comboCategory.Visible = false;
            // 
            // labelYear
            // 
            this.labelYear.AutoSize = true;
            this.labelYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.labelYear.Location = new System.Drawing.Point(591, 16);
            this.labelYear.Name = "labelYear";
            this.labelYear.Size = new System.Drawing.Size(39, 16);
            this.labelYear.TabIndex = 4;
            this.labelYear.Text = "Year:";
            this.labelYear.Visible = false;
            // 
            // comboYear
            // 
            this.comboYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.comboYear.FormattingEnabled = true;
            this.comboYear.Location = new System.Drawing.Point(636, 13);
            this.comboYear.Name = "comboYear";
            this.comboYear.Size = new System.Drawing.Size(85, 24);
            this.comboYear.TabIndex = 5;
            this.comboYear.Visible = false;
            // 
            // labelSearch
            // 
            this.labelSearch.AutoSize = true;
            this.labelSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.labelSearch.Location = new System.Drawing.Point(876, 19);
            this.labelSearch.Name = "labelSearch";
            this.labelSearch.Size = new System.Drawing.Size(53, 16);
            this.labelSearch.TabIndex = 8;
            this.labelSearch.Text = "Search:";
            this.labelSearch.Visible = false;
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.txtSearch.Location = new System.Drawing.Point(941, 16);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(150, 22);
            this.txtSearch.TabIndex = 9;
            this.txtSearch.Visible = false;
            // 
            // btnClearSearch
            // 
            this.btnClearSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.btnClearSearch.Location = new System.Drawing.Point(941, 44);
            this.btnClearSearch.Name = "btnClearSearch";
            this.btnClearSearch.Size = new System.Drawing.Size(70, 26);
            this.btnClearSearch.TabIndex = 10;
            this.btnClearSearch.Text = "Clear";
            this.btnClearSearch.UseVisualStyleBackColor = true;
            this.btnClearSearch.Visible = false;
            this.btnClearSearch.Click += new System.EventHandler(this.btnClearSearch_Click);
            // 
            // btnGo
            // 
            this.btnGo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.btnGo.Location = new System.Drawing.Point(1031, 46);
            this.btnGo.Name = "btnGo";
            this.btnGo.Size = new System.Drawing.Size(60, 26);
            this.btnGo.TabIndex = 11;
            this.btnGo.Text = "Go";
            this.btnGo.UseVisualStyleBackColor = true;
            this.btnGo.Visible = false;
            this.btnGo.Click += new System.EventHandler(this.btnGo_Click);
            // 
            // dgvData
            // 
            this.dgvData.BackgroundColor = System.Drawing.Color.White;
            this.dgvData.Location = new System.Drawing.Point(1099, 532);
            this.dgvData.Name = "dgvData";
            this.dgvData.Size = new System.Drawing.Size(35, 63);
            this.dgvData.TabIndex = 12;
            this.dgvData.Visible = false;
            // 
            // lblLoggedIn
            // 
            this.lblLoggedIn.AutoSize = true;
            this.lblLoggedIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.lblLoggedIn.Location = new System.Drawing.Point(6, 536);
            this.lblLoggedIn.Name = "lblLoggedIn";
            this.lblLoggedIn.Size = new System.Drawing.Size(70, 16);
            this.lblLoggedIn.TabIndex = 13;
            this.lblLoggedIn.Text = "Logged In:";
            // 
            // btnLogOut
            // 
            this.btnLogOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.btnLogOut.Location = new System.Drawing.Point(1011, 551);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(100, 26);
            this.btnLogOut.TabIndex = 14;
            this.btnLogOut.Text = "Log Out";
            this.btnLogOut.UseVisualStyleBackColor = true;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // btnUserSettings
            // 
            this.btnUserSettings.Location = new System.Drawing.Point(1, 556);
            this.btnUserSettings.Name = "btnUserSettings";
            this.btnUserSettings.Size = new System.Drawing.Size(92, 23);
            this.btnUserSettings.TabIndex = 15;
            this.btnUserSettings.Text = "User Settings";
            this.btnUserSettings.UseVisualStyleBackColor = true;
            // 
            // gBLeague
            // 
            this.gBLeague.Controls.Add(this.labelWeek);
            this.gBLeague.Controls.Add(this.comboWeek);
            this.gBLeague.Controls.Add(this.btnGo);
            this.gBLeague.Controls.Add(this.btnUserSettings);
            this.gBLeague.Controls.Add(this.btnLogOut);
            this.gBLeague.Controls.Add(this.tCLeagues);
            this.gBLeague.Controls.Add(this.pBSport);
            this.gBLeague.Controls.Add(this.labelSport);
            this.gBLeague.Controls.Add(this.lblLoggedIn);
            this.gBLeague.Controls.Add(this.comboSports);
            this.gBLeague.Controls.Add(this.txtSearch);
            this.gBLeague.Controls.Add(this.labelCategory);
            this.gBLeague.Controls.Add(this.comboCategory);
            this.gBLeague.Controls.Add(this.btnClearSearch);
            this.gBLeague.Controls.Add(this.labelYear);
            this.gBLeague.Controls.Add(this.labelSearch);
            this.gBLeague.Controls.Add(this.comboYear);
            this.gBLeague.Location = new System.Drawing.Point(7, 12);
            this.gBLeague.Name = "gBLeague";
            this.gBLeague.Size = new System.Drawing.Size(1117, 583);
            this.gBLeague.TabIndex = 17;
            this.gBLeague.TabStop = false;
            this.gBLeague.Text = "Sport";
            // 
            // labelWeek
            // 
            this.labelWeek.AutoSize = true;
            this.labelWeek.Location = new System.Drawing.Point(751, 20);
            this.labelWeek.Name = "labelWeek";
            this.labelWeek.Size = new System.Drawing.Size(33, 13);
            this.labelWeek.TabIndex = 18;
            this.labelWeek.Text = "week";
            // 
            // comboWeek
            // 
            this.comboWeek.FormattingEnabled = true;
            this.comboWeek.Location = new System.Drawing.Point(792, 17);
            this.comboWeek.Name = "comboWeek";
            this.comboWeek.Size = new System.Drawing.Size(66, 21);
            this.comboWeek.TabIndex = 17;
            // 
            // tCLeagues
            // 
            this.tCLeagues.Controls.Add(this.tPGames);
            this.tCLeagues.Controls.Add(this.tPTeams);
            this.tCLeagues.Controls.Add(this.tPPlayers);
            this.tCLeagues.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tCLeagues.Location = new System.Drawing.Point(111, 46);
            this.tCLeagues.Name = "tCLeagues";
            this.tCLeagues.SelectedIndex = 0;
            this.tCLeagues.Size = new System.Drawing.Size(1000, 483);
            this.tCLeagues.TabIndex = 0;
            // 
            // tPGames
            // 
            this.tPGames.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.tPGames.Controls.Add(this.dateTimeGame);
            this.tPGames.Controls.Add(this.tBDate);
            this.tPGames.Controls.Add(this.tBStatium);
            this.tPGames.Controls.Add(this.tBHomeTeam);
            this.tPGames.Controls.Add(this.tBAwayTeam);
            this.tPGames.Controls.Add(this.tBHomeScore);
            this.tPGames.Controls.Add(this.tBAwayScore);
            this.tPGames.Controls.Add(this.pictureBoxAway);
            this.tPGames.Controls.Add(this.lblAt);
            this.tPGames.Controls.Add(this.lblVS);
            this.tPGames.Controls.Add(this.pictureBoxHome);
            this.tPGames.Controls.Add(this.listBoxGames);
            this.tPGames.Controls.Add(this.lblAway);
            this.tPGames.Controls.Add(this.lblHome);
            this.tPGames.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tPGames.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tPGames.Location = new System.Drawing.Point(4, 34);
            this.tPGames.Name = "tPGames";
            this.tPGames.Padding = new System.Windows.Forms.Padding(3);
            this.tPGames.Size = new System.Drawing.Size(992, 429);
            this.tPGames.TabIndex = 0;
            this.tPGames.Text = "Games";
            // 
            // dateTimeGame
            // 
            this.dateTimeGame.Location = new System.Drawing.Point(176, 6);
            this.dateTimeGame.Name = "dateTimeGame";
            this.dateTimeGame.Size = new System.Drawing.Size(200, 26);
            this.dateTimeGame.TabIndex = 15;
            this.dateTimeGame.Visible = false;
            // 
            // tBDate
            // 
            this.tBDate.Location = new System.Drawing.Point(469, 60);
            this.tBDate.Name = "tBDate";
            this.tBDate.Size = new System.Drawing.Size(185, 26);
            this.tBDate.TabIndex = 14;
            this.tBDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tBStatium
            // 
            this.tBStatium.Location = new System.Drawing.Point(469, 298);
            this.tBStatium.Name = "tBStatium";
            this.tBStatium.Size = new System.Drawing.Size(185, 26);
            this.tBStatium.TabIndex = 12;
            this.tBStatium.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tBHomeTeam
            // 
            this.tBHomeTeam.Location = new System.Drawing.Point(668, 118);
            this.tBHomeTeam.Name = "tBHomeTeam";
            this.tBHomeTeam.Size = new System.Drawing.Size(185, 26);
            this.tBHomeTeam.TabIndex = 10;
            this.tBHomeTeam.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tBAwayTeam
            // 
            this.tBAwayTeam.Location = new System.Drawing.Point(271, 118);
            this.tBAwayTeam.Name = "tBAwayTeam";
            this.tBAwayTeam.Size = new System.Drawing.Size(185, 26);
            this.tBAwayTeam.TabIndex = 9;
            this.tBAwayTeam.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tBHomeScore
            // 
            this.tBHomeScore.Location = new System.Drawing.Point(707, 259);
            this.tBHomeScore.Name = "tBHomeScore";
            this.tBHomeScore.Size = new System.Drawing.Size(100, 26);
            this.tBHomeScore.TabIndex = 6;
            this.tBHomeScore.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tBAwayScore
            // 
            this.tBAwayScore.Location = new System.Drawing.Point(308, 259);
            this.tBAwayScore.Name = "tBAwayScore";
            this.tBAwayScore.Size = new System.Drawing.Size(100, 26);
            this.tBAwayScore.TabIndex = 5;
            this.tBAwayScore.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pictureBoxAway
            // 
            this.pictureBoxAway.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxAway.Location = new System.Drawing.Point(295, 150);
            this.pictureBoxAway.Name = "pictureBoxAway";
            this.pictureBoxAway.Size = new System.Drawing.Size(119, 103);
            this.pictureBoxAway.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxAway.TabIndex = 13;
            this.pictureBoxAway.TabStop = false;
            // 
            // lblAt
            // 
            this.lblAt.AutoSize = true;
            this.lblAt.Location = new System.Drawing.Point(539, 265);
            this.lblAt.Name = "lblAt";
            this.lblAt.Size = new System.Drawing.Size(29, 20);
            this.lblAt.TabIndex = 11;
            this.lblAt.Text = "At:";
            // 
            // lblVS
            // 
            this.lblVS.AutoSize = true;
            this.lblVS.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVS.Location = new System.Drawing.Point(532, 180);
            this.lblVS.Name = "lblVS";
            this.lblVS.Size = new System.Drawing.Size(50, 29);
            this.lblVS.TabIndex = 8;
            this.lblVS.Text = "VS.";
            // 
            // pictureBoxHome
            // 
            this.pictureBoxHome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxHome.Location = new System.Drawing.Point(698, 150);
            this.pictureBoxHome.Name = "pictureBoxHome";
            this.pictureBoxHome.Size = new System.Drawing.Size(119, 103);
            this.pictureBoxHome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxHome.TabIndex = 4;
            this.pictureBoxHome.TabStop = false;
            // 
            // listBoxGames
            // 
            this.listBoxGames.FormattingEnabled = true;
            this.listBoxGames.ItemHeight = 20;
            this.listBoxGames.Location = new System.Drawing.Point(6, 19);
            this.listBoxGames.Name = "listBoxGames";
            this.listBoxGames.Size = new System.Drawing.Size(150, 404);
            this.listBoxGames.TabIndex = 2;
            this.listBoxGames.SelectedIndexChanged += new System.EventHandler(this.listBoxGames_SelectedIndexChanged);
            // 
            // lblAway
            // 
            this.lblAway.AutoSize = true;
            this.lblAway.Location = new System.Drawing.Point(329, 60);
            this.lblAway.Name = "lblAway";
            this.lblAway.Size = new System.Drawing.Size(47, 20);
            this.lblAway.TabIndex = 1;
            this.lblAway.Text = "Away";
            // 
            // lblHome
            // 
            this.lblHome.AutoSize = true;
            this.lblHome.Location = new System.Drawing.Point(734, 60);
            this.lblHome.Name = "lblHome";
            this.lblHome.Size = new System.Drawing.Size(52, 20);
            this.lblHome.TabIndex = 0;
            this.lblHome.Text = "Home";
            // 
            // tPTeams
            // 
            this.tPTeams.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.tPTeams.Controls.Add(this.tBTeamConference);
            this.tPTeams.Controls.Add(this.tBTeamDivision);
            this.tPTeams.Controls.Add(this.tBTeamCity);
            this.tPTeams.Controls.Add(this.tBTeamLoss);
            this.tPTeams.Controls.Add(this.tBTeamTies);
            this.tPTeams.Controls.Add(this.tBTeamWins);
            this.tPTeams.Controls.Add(this.lblWinLossRating);
            this.tPTeams.Controls.Add(this.label8);
            this.tPTeams.Controls.Add(this.label7);
            this.tPTeams.Controls.Add(this.label6);
            this.tPTeams.Controls.Add(this.label1);
            this.tPTeams.Controls.Add(this.lBTopPlayers);
            this.tPTeams.Controls.Add(this.label5);
            this.tPTeams.Controls.Add(this.label4);
            this.tPTeams.Controls.Add(this.label3);
            this.tPTeams.Controls.Add(this.label2);
            this.tPTeams.Controls.Add(this.lblTeamName);
            this.tPTeams.Controls.Add(this.pictureBoxTeamLogo);
            this.tPTeams.Controls.Add(this.listBoxTeam);
            this.tPTeams.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tPTeams.Location = new System.Drawing.Point(4, 34);
            this.tPTeams.Name = "tPTeams";
            this.tPTeams.Padding = new System.Windows.Forms.Padding(3);
            this.tPTeams.Size = new System.Drawing.Size(992, 429);
            this.tPTeams.TabIndex = 1;
            this.tPTeams.Text = "Teams";
            // 
            // tBTeamConference
            // 
            this.tBTeamConference.Location = new System.Drawing.Point(264, 317);
            this.tBTeamConference.Name = "tBTeamConference";
            this.tBTeamConference.Size = new System.Drawing.Size(100, 26);
            this.tBTeamConference.TabIndex = 23;
            // 
            // tBTeamDivision
            // 
            this.tBTeamDivision.Location = new System.Drawing.Point(264, 283);
            this.tBTeamDivision.Name = "tBTeamDivision";
            this.tBTeamDivision.Size = new System.Drawing.Size(100, 26);
            this.tBTeamDivision.TabIndex = 22;
            // 
            // tBTeamCity
            // 
            this.tBTeamCity.Location = new System.Drawing.Point(264, 251);
            this.tBTeamCity.Name = "tBTeamCity";
            this.tBTeamCity.Size = new System.Drawing.Size(100, 26);
            this.tBTeamCity.TabIndex = 21;
            // 
            // tBTeamLoss
            // 
            this.tBTeamLoss.Location = new System.Drawing.Point(690, 103);
            this.tBTeamLoss.Name = "tBTeamLoss";
            this.tBTeamLoss.Size = new System.Drawing.Size(54, 26);
            this.tBTeamLoss.TabIndex = 20;
            // 
            // tBTeamTies
            // 
            this.tBTeamTies.Location = new System.Drawing.Point(594, 103);
            this.tBTeamTies.Name = "tBTeamTies";
            this.tBTeamTies.Size = new System.Drawing.Size(54, 26);
            this.tBTeamTies.TabIndex = 19;
            // 
            // tBTeamWins
            // 
            this.tBTeamWins.Location = new System.Drawing.Point(502, 103);
            this.tBTeamWins.Name = "tBTeamWins";
            this.tBTeamWins.Size = new System.Drawing.Size(54, 26);
            this.tBTeamWins.TabIndex = 18;
            // 
            // lblWinLossRating
            // 
            this.lblWinLossRating.AutoSize = true;
            this.lblWinLossRating.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWinLossRating.Location = new System.Drawing.Point(829, 113);
            this.lblWinLossRating.Name = "lblWinLossRating";
            this.lblWinLossRating.Size = new System.Drawing.Size(67, 39);
            this.lblWinLossRating.TabIndex = 17;
            this.lblWinLossRating.Text = "0%";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(813, 68);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(129, 20);
            this.label8.TabIndex = 16;
            this.label8.Text = "Win/Loss Rating:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(684, 68);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 20);
            this.label7.TabIndex = 15;
            this.label7.Text = "Losses";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(610, 68);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 20);
            this.label6.TabIndex = 14;
            this.label6.Text = "Ties";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(512, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 20);
            this.label1.TabIndex = 13;
            this.label1.Text = "Wins";
            // 
            // lBTopPlayers
            // 
            this.lBTopPlayers.FormattingEnabled = true;
            this.lBTopPlayers.ItemHeight = 20;
            this.lBTopPlayers.Location = new System.Drawing.Point(516, 196);
            this.lBTopPlayers.Name = "lBTopPlayers";
            this.lBTopPlayers.Size = new System.Drawing.Size(460, 124);
            this.lBTopPlayers.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(166, 320);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 20);
            this.label5.TabIndex = 11;
            this.label5.Text = "Conference";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(195, 283);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 20);
            this.label4.TabIndex = 10;
            this.label4.Text = "Division";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(223, 251);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "City";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(511, 173);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Top Players:";
            // 
            // lblTeamName
            // 
            this.lblTeamName.AutoSize = true;
            this.lblTeamName.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTeamName.Location = new System.Drawing.Point(178, 7);
            this.lblTeamName.Name = "lblTeamName";
            this.lblTeamName.Size = new System.Drawing.Size(208, 39);
            this.lblTeamName.TabIndex = 5;
            this.lblTeamName.Text = "Team Name";
            // 
            // pictureBoxTeamLogo
            // 
            this.pictureBoxTeamLogo.Location = new System.Drawing.Point(227, 68);
            this.pictureBoxTeamLogo.Name = "pictureBoxTeamLogo";
            this.pictureBoxTeamLogo.Size = new System.Drawing.Size(155, 134);
            this.pictureBoxTeamLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxTeamLogo.TabIndex = 4;
            this.pictureBoxTeamLogo.TabStop = false;
            // 
            // listBoxTeam
            // 
            this.listBoxTeam.FormattingEnabled = true;
            this.listBoxTeam.ItemHeight = 20;
            this.listBoxTeam.Location = new System.Drawing.Point(6, 19);
            this.listBoxTeam.Name = "listBoxTeam";
            this.listBoxTeam.Size = new System.Drawing.Size(150, 404);
            this.listBoxTeam.TabIndex = 3;
            this.listBoxTeam.SelectedIndexChanged += new System.EventHandler(this.listBoxTeam_SelectedIndexChanged);
            // 
            // tPPlayers
            // 
            this.tPPlayers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.tPPlayers.Controls.Add(this.groupBoxNBAPlayerStats);
            this.tPPlayers.Controls.Add(this.label11);
            this.tPPlayers.Controls.Add(this.groupBoxNFLPlayerStats);
            this.tPPlayers.Controls.Add(this.label12);
            this.tPPlayers.Controls.Add(this.lblPlayerName);
            this.tPPlayers.Controls.Add(this.tbPlayerPosition);
            this.tPPlayers.Controls.Add(this.tBPlayerTeam);
            this.tPPlayers.Controls.Add(this.cBTeamFilter);
            this.tPPlayers.Controls.Add(this.comboBoxTeamList);
            this.tPPlayers.Controls.Add(this.listBoxPlayer);
            this.tPPlayers.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tPPlayers.Location = new System.Drawing.Point(4, 34);
            this.tPPlayers.Name = "tPPlayers";
            this.tPPlayers.Padding = new System.Windows.Forms.Padding(3);
            this.tPPlayers.Size = new System.Drawing.Size(992, 445);
            this.tPPlayers.TabIndex = 2;
            this.tPPlayers.Text = "Players";
            // 
            // groupBoxNBAPlayerStats
            // 
            this.groupBoxNBAPlayerStats.Controls.Add(this.label25);
            this.groupBoxNBAPlayerStats.Controls.Add(this.tBNBASteals);
            this.groupBoxNBAPlayerStats.Controls.Add(this.label26);
            this.groupBoxNBAPlayerStats.Controls.Add(this.tBNBATurnovers);
            this.groupBoxNBAPlayerStats.Controls.Add(this.label27);
            this.groupBoxNBAPlayerStats.Controls.Add(this.tBNBABlocks);
            this.groupBoxNBAPlayerStats.Controls.Add(this.label28);
            this.groupBoxNBAPlayerStats.Controls.Add(this.tBNBAFreeThrowsMade);
            this.groupBoxNBAPlayerStats.Controls.Add(this.label29);
            this.groupBoxNBAPlayerStats.Controls.Add(this.tBNBAFreeThrowsAttempt);
            this.groupBoxNBAPlayerStats.Controls.Add(this.label30);
            this.groupBoxNBAPlayerStats.Controls.Add(this.tBNBAThreePointers);
            this.groupBoxNBAPlayerStats.Controls.Add(this.label32);
            this.groupBoxNBAPlayerStats.Controls.Add(this.tBNBARebounds);
            this.groupBoxNBAPlayerStats.Controls.Add(this.label33);
            this.groupBoxNBAPlayerStats.Controls.Add(this.tBNBAAssists);
            this.groupBoxNBAPlayerStats.Controls.Add(this.label35);
            this.groupBoxNBAPlayerStats.Controls.Add(this.tBNBAPoints);
            this.groupBoxNBAPlayerStats.Location = new System.Drawing.Point(510, 76);
            this.groupBoxNBAPlayerStats.Name = "groupBoxNBAPlayerStats";
            this.groupBoxNBAPlayerStats.Size = new System.Drawing.Size(386, 327);
            this.groupBoxNBAPlayerStats.TabIndex = 41;
            this.groupBoxNBAPlayerStats.TabStop = false;
            this.groupBoxNBAPlayerStats.Text = "NBA";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(246, 50);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(58, 20);
            this.label25.TabIndex = 39;
            this.label25.Text = "Steals:";
            // 
            // tBNBASteals
            // 
            this.tBNBASteals.Location = new System.Drawing.Point(306, 47);
            this.tBNBASteals.Name = "tBNBASteals";
            this.tBNBASteals.Size = new System.Drawing.Size(45, 26);
            this.tBNBASteals.TabIndex = 40;
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(31, 22);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(83, 20);
            this.label26.TabIndex = 37;
            this.label26.Text = "Turnovers:";
            // 
            // tBNBATurnovers
            // 
            this.tBNBATurnovers.Location = new System.Drawing.Point(114, 17);
            this.tBNBATurnovers.Name = "tBNBATurnovers";
            this.tBNBATurnovers.Size = new System.Drawing.Size(45, 26);
            this.tBNBATurnovers.TabIndex = 38;
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(240, 78);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(60, 20);
            this.label27.TabIndex = 35;
            this.label27.Text = "Blocks:";
            // 
            // tBNBABlocks
            // 
            this.tBNBABlocks.Location = new System.Drawing.Point(306, 75);
            this.tBNBABlocks.Name = "tBNBABlocks";
            this.tBNBABlocks.Size = new System.Drawing.Size(45, 26);
            this.tBNBABlocks.TabIndex = 36;
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(82, 187);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(137, 20);
            this.label28.TabIndex = 33;
            this.label28.Text = "Freethrows made:";
            // 
            // tBNBAFreeThrowsMade
            // 
            this.tBNBAFreeThrowsMade.Location = new System.Drawing.Point(225, 184);
            this.tBNBAFreeThrowsMade.Name = "tBNBAFreeThrowsMade";
            this.tBNBAFreeThrowsMade.Size = new System.Drawing.Size(46, 26);
            this.tBNBAFreeThrowsMade.TabIndex = 34;
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Location = new System.Drawing.Point(45, 150);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(174, 20);
            this.label29.TabIndex = 31;
            this.label29.Text = "Freethrows attempted :";
            // 
            // tBNBAFreeThrowsAttempt
            // 
            this.tBNBAFreeThrowsAttempt.Location = new System.Drawing.Point(223, 150);
            this.tBNBAFreeThrowsAttempt.Name = "tBNBAFreeThrowsAttempt";
            this.tBNBAFreeThrowsAttempt.Size = new System.Drawing.Size(46, 26);
            this.tBNBAFreeThrowsAttempt.TabIndex = 32;
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Location = new System.Drawing.Point(184, 22);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(116, 20);
            this.label30.TabIndex = 29;
            this.label30.Text = "Three Pointers:";
            // 
            // tBNBAThreePointers
            // 
            this.tBNBAThreePointers.Location = new System.Drawing.Point(306, 19);
            this.tBNBAThreePointers.Name = "tBNBAThreePointers";
            this.tBNBAThreePointers.Size = new System.Drawing.Size(46, 26);
            this.tBNBAThreePointers.TabIndex = 30;
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Location = new System.Drawing.Point(20, 81);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(83, 20);
            this.label32.TabIndex = 26;
            this.label32.Text = "Rebounds";
            // 
            // tBNBARebounds
            // 
            this.tBNBARebounds.Location = new System.Drawing.Point(115, 78);
            this.tBNBARebounds.Name = "tBNBARebounds";
            this.tBNBARebounds.Size = new System.Drawing.Size(45, 26);
            this.tBNBARebounds.TabIndex = 27;
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Location = new System.Drawing.Point(40, 52);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(64, 20);
            this.label33.TabIndex = 24;
            this.label33.Text = "Assists:";
            // 
            // tBNBAAssists
            // 
            this.tBNBAAssists.Location = new System.Drawing.Point(115, 49);
            this.tBNBAAssists.Name = "tBNBAAssists";
            this.tBNBAAssists.Size = new System.Drawing.Size(45, 26);
            this.tBNBAAssists.TabIndex = 25;
            // 
            // label35
            // 
            this.label35.AutoSize = true;
            this.label35.Location = new System.Drawing.Point(111, 248);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(57, 20);
            this.label35.TabIndex = 21;
            this.label35.Text = "Points:";
            // 
            // tBNBAPoints
            // 
            this.tBNBAPoints.Location = new System.Drawing.Point(186, 245);
            this.tBNBAPoints.Name = "tBNBAPoints";
            this.tBNBAPoints.Size = new System.Drawing.Size(45, 26);
            this.tBNBAPoints.TabIndex = 22;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(179, 102);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(53, 20);
            this.label11.TabIndex = 12;
            this.label11.Text = "Team:";
            // 
            // groupBoxNFLPlayerStats
            // 
            this.groupBoxNFLPlayerStats.Controls.Add(this.label24);
            this.groupBoxNFLPlayerStats.Controls.Add(this.tBNFLSacks);
            this.groupBoxNFLPlayerStats.Controls.Add(this.label23);
            this.groupBoxNFLPlayerStats.Controls.Add(this.tBNFLInterceptions);
            this.groupBoxNFLPlayerStats.Controls.Add(this.label22);
            this.groupBoxNFLPlayerStats.Controls.Add(this.tBNFLTackles);
            this.groupBoxNFLPlayerStats.Controls.Add(this.label19);
            this.groupBoxNFLPlayerStats.Controls.Add(this.tBNFLYReceiving);
            this.groupBoxNFLPlayerStats.Controls.Add(this.label20);
            this.groupBoxNFLPlayerStats.Controls.Add(this.tBNFLYRushing);
            this.groupBoxNFLPlayerStats.Controls.Add(this.label21);
            this.groupBoxNFLPlayerStats.Controls.Add(this.tBNFLYPassing);
            this.groupBoxNFLPlayerStats.Controls.Add(this.label18);
            this.groupBoxNFLPlayerStats.Controls.Add(this.label17);
            this.groupBoxNFLPlayerStats.Controls.Add(this.tBNFLTDReceiving);
            this.groupBoxNFLPlayerStats.Controls.Add(this.label16);
            this.groupBoxNFLPlayerStats.Controls.Add(this.tBNFLTDRushing);
            this.groupBoxNFLPlayerStats.Controls.Add(this.label15);
            this.groupBoxNFLPlayerStats.Controls.Add(this.label13);
            this.groupBoxNFLPlayerStats.Controls.Add(this.tBNFLTDPassing);
            this.groupBoxNFLPlayerStats.Location = new System.Drawing.Point(510, 76);
            this.groupBoxNFLPlayerStats.Name = "groupBoxNFLPlayerStats";
            this.groupBoxNFLPlayerStats.Size = new System.Drawing.Size(386, 327);
            this.groupBoxNFLPlayerStats.TabIndex = 20;
            this.groupBoxNFLPlayerStats.TabStop = false;
            this.groupBoxNFLPlayerStats.Text = "NFL";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(208, 182);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(57, 20);
            this.label24.TabIndex = 39;
            this.label24.Text = "Sacks:";
            // 
            // tBNFLSacks
            // 
            this.tBNFLSacks.Location = new System.Drawing.Point(266, 179);
            this.tBNFLSacks.Name = "tBNFLSacks";
            this.tBNFLSacks.Size = new System.Drawing.Size(45, 26);
            this.tBNFLSacks.TabIndex = 40;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(97, 242);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(106, 20);
            this.label23.TabIndex = 37;
            this.label23.Text = "Interceptions:";
            // 
            // tBNFLInterceptions
            // 
            this.tBNFLInterceptions.Location = new System.Drawing.Point(203, 239);
            this.tBNFLInterceptions.Name = "tBNFLInterceptions";
            this.tBNFLInterceptions.Size = new System.Drawing.Size(45, 26);
            this.tBNFLInterceptions.TabIndex = 38;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(44, 182);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(67, 20);
            this.label22.TabIndex = 35;
            this.label22.Text = "Tackles:";
            // 
            // tBNFLTackles
            // 
            this.tBNFLTackles.Location = new System.Drawing.Point(117, 179);
            this.tBNFLTackles.Name = "tBNFLTackles";
            this.tBNFLTackles.Size = new System.Drawing.Size(45, 26);
            this.tBNFLTackles.TabIndex = 36;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(208, 108);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(82, 20);
            this.label19.TabIndex = 33;
            this.label19.Text = "Receiving:";
            // 
            // tBNFLYReceiving
            // 
            this.tBNFLYReceiving.Location = new System.Drawing.Point(292, 105);
            this.tBNFLYReceiving.Name = "tBNFLYReceiving";
            this.tBNFLYReceiving.Size = new System.Drawing.Size(46, 26);
            this.tBNFLYReceiving.TabIndex = 34;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(217, 79);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(72, 20);
            this.label20.TabIndex = 31;
            this.label20.Text = "Rushing:";
            // 
            // tBNFLYRushing
            // 
            this.tBNFLYRushing.Location = new System.Drawing.Point(292, 76);
            this.tBNFLYRushing.Name = "tBNFLYRushing";
            this.tBNFLYRushing.Size = new System.Drawing.Size(46, 26);
            this.tBNFLYRushing.TabIndex = 32;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(217, 52);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(69, 20);
            this.label21.TabIndex = 29;
            this.label21.Text = "Passing:";
            // 
            // tBNFLYPassing
            // 
            this.tBNFLYPassing.Location = new System.Drawing.Point(292, 49);
            this.tBNFLYPassing.Name = "tBNFLYPassing";
            this.tBNFLYPassing.Size = new System.Drawing.Size(46, 26);
            this.tBNFLYPassing.TabIndex = 30;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(217, 22);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(51, 20);
            this.label18.TabIndex = 28;
            this.label18.Text = "Yards";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(17, 111);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(82, 20);
            this.label17.TabIndex = 26;
            this.label17.Text = "Receiving:";
            // 
            // tBNFLTDReceiving
            // 
            this.tBNFLTDReceiving.Location = new System.Drawing.Point(101, 108);
            this.tBNFLTDReceiving.Name = "tBNFLTDReceiving";
            this.tBNFLTDReceiving.Size = new System.Drawing.Size(45, 26);
            this.tBNFLTDReceiving.TabIndex = 27;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(26, 82);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(72, 20);
            this.label16.TabIndex = 24;
            this.label16.Text = "Rushing:";
            // 
            // tBNFLTDRushing
            // 
            this.tBNFLTDRushing.Location = new System.Drawing.Point(101, 79);
            this.tBNFLTDRushing.Name = "tBNFLTDRushing";
            this.tBNFLTDRushing.Size = new System.Drawing.Size(45, 26);
            this.tBNFLTDRushing.TabIndex = 25;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(27, 22);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(99, 20);
            this.label15.TabIndex = 23;
            this.label15.Text = "Touchdowns";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(26, 55);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(69, 20);
            this.label13.TabIndex = 21;
            this.label13.Text = "Passing:";
            // 
            // tBNFLTDPassing
            // 
            this.tBNFLTDPassing.Location = new System.Drawing.Point(101, 52);
            this.tBNFLTDPassing.Name = "tBNFLTDPassing";
            this.tBNFLTDPassing.Size = new System.Drawing.Size(45, 26);
            this.tBNFLTDPassing.TabIndex = 22;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(166, 142);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(66, 20);
            this.label12.TabIndex = 13;
            this.label12.Text = "Postion:";
            // 
            // lblPlayerName
            // 
            this.lblPlayerName.AutoSize = true;
            this.lblPlayerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayerName.Location = new System.Drawing.Point(401, 19);
            this.lblPlayerName.Name = "lblPlayerName";
            this.lblPlayerName.Size = new System.Drawing.Size(233, 42);
            this.lblPlayerName.TabIndex = 11;
            this.lblPlayerName.Text = "Player Name";
            // 
            // tbPlayerPosition
            // 
            this.tbPlayerPosition.Location = new System.Drawing.Point(238, 139);
            this.tbPlayerPosition.Name = "tbPlayerPosition";
            this.tbPlayerPosition.Size = new System.Drawing.Size(43, 26);
            this.tbPlayerPosition.TabIndex = 18;
            // 
            // tBPlayerTeam
            // 
            this.tBPlayerTeam.Location = new System.Drawing.Point(238, 99);
            this.tBPlayerTeam.Name = "tBPlayerTeam";
            this.tBPlayerTeam.Size = new System.Drawing.Size(183, 26);
            this.tBPlayerTeam.TabIndex = 16;
            // 
            // cBTeamFilter
            // 
            this.cBTeamFilter.AutoSize = true;
            this.cBTeamFilter.Location = new System.Drawing.Point(160, 20);
            this.cBTeamFilter.Name = "cBTeamFilter";
            this.cBTeamFilter.Size = new System.Drawing.Size(123, 24);
            this.cBTeamFilter.TabIndex = 6;
            this.cBTeamFilter.Text = "Filter by team";
            this.cBTeamFilter.UseVisualStyleBackColor = true;
            this.cBTeamFilter.Visible = false;
            // 
            // comboBoxTeamList
            // 
            this.comboBoxTeamList.FormattingEnabled = true;
            this.comboBoxTeamList.Location = new System.Drawing.Point(160, 50);
            this.comboBoxTeamList.Name = "comboBoxTeamList";
            this.comboBoxTeamList.Size = new System.Drawing.Size(121, 28);
            this.comboBoxTeamList.TabIndex = 5;
            this.comboBoxTeamList.Visible = false;
            // 
            // listBoxPlayer
            // 
            this.listBoxPlayer.FormattingEnabled = true;
            this.listBoxPlayer.ItemHeight = 20;
            this.listBoxPlayer.Location = new System.Drawing.Point(6, 19);
            this.listBoxPlayer.Name = "listBoxPlayer";
            this.listBoxPlayer.Size = new System.Drawing.Size(148, 404);
            this.listBoxPlayer.TabIndex = 4;
            this.listBoxPlayer.SelectedIndexChanged += new System.EventHandler(this.listBoxPlayer_SelectedIndexChanged);
            // 
            // pBSport
            // 
            this.pBSport.Image = global::Group_Project_1.Properties.Resources.Red___Black_minimalist_football;
            this.pBSport.Location = new System.Drawing.Point(5, 19);
            this.pBSport.Name = "pBSport";
            this.pBSport.Size = new System.Drawing.Size(100, 104);
            this.pBSport.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pBSport.TabIndex = 16;
            this.pBSport.TabStop = false;
            // 
            // imageListNFL
            // 
            this.imageListNFL.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageListNFL.ImageStream")));
            this.imageListNFL.TransparentColor = System.Drawing.Color.Transparent;
            this.imageListNFL.Images.SetKeyName(0, "49ers.png");
            this.imageListNFL.Images.SetKeyName(1, "Bears.png");
            this.imageListNFL.Images.SetKeyName(2, "Bengals.png");
            this.imageListNFL.Images.SetKeyName(3, "Bills.png");
            this.imageListNFL.Images.SetKeyName(4, "Broncos.png");
            this.imageListNFL.Images.SetKeyName(5, "Browns.png");
            this.imageListNFL.Images.SetKeyName(6, "Buccaneers.png");
            this.imageListNFL.Images.SetKeyName(7, "Cardinals.png");
            this.imageListNFL.Images.SetKeyName(8, "Chargers.png");
            this.imageListNFL.Images.SetKeyName(9, "Chiefs.png");
            this.imageListNFL.Images.SetKeyName(10, "Colts.png");
            this.imageListNFL.Images.SetKeyName(11, "Commanders.png");
            this.imageListNFL.Images.SetKeyName(12, "Cowboys.png");
            this.imageListNFL.Images.SetKeyName(13, "Dolphins.png");
            this.imageListNFL.Images.SetKeyName(14, "Eagles.png");
            this.imageListNFL.Images.SetKeyName(15, "Falcons.png");
            this.imageListNFL.Images.SetKeyName(16, "Giants.png");
            this.imageListNFL.Images.SetKeyName(17, "Jaguars.png");
            this.imageListNFL.Images.SetKeyName(18, "Jets.png");
            this.imageListNFL.Images.SetKeyName(19, "Lions.png");
            this.imageListNFL.Images.SetKeyName(20, "Packers.png");
            this.imageListNFL.Images.SetKeyName(21, "Panthers.png");
            this.imageListNFL.Images.SetKeyName(22, "Patriots.png");
            this.imageListNFL.Images.SetKeyName(23, "Raiders.png");
            this.imageListNFL.Images.SetKeyName(24, "Rams.png");
            this.imageListNFL.Images.SetKeyName(25, "Ravens.png");
            this.imageListNFL.Images.SetKeyName(26, "Saints.png");
            this.imageListNFL.Images.SetKeyName(27, "Seahawks.png");
            this.imageListNFL.Images.SetKeyName(28, "Steelers.png");
            this.imageListNFL.Images.SetKeyName(29, "Texans.png");
            this.imageListNFL.Images.SetKeyName(30, "Titans.png");
            this.imageListNFL.Images.SetKeyName(31, "Vikings.png");
            this.imageListNFL.Images.SetKeyName(32, "NFLLogo.png");
            // 
            // imageListNBA
            // 
            this.imageListNBA.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageListNBA.ImageStream")));
            this.imageListNBA.TransparentColor = System.Drawing.Color.Transparent;
            this.imageListNBA.Images.SetKeyName(0, "76ers.png");
            this.imageListNBA.Images.SetKeyName(1, "Bucks.png");
            this.imageListNBA.Images.SetKeyName(2, "Bulls.png");
            this.imageListNBA.Images.SetKeyName(3, "Cavaliers.png");
            this.imageListNBA.Images.SetKeyName(4, "Celtics.png");
            this.imageListNBA.Images.SetKeyName(5, "Clippers.png");
            this.imageListNBA.Images.SetKeyName(6, "Grizzlies.png");
            this.imageListNBA.Images.SetKeyName(7, "Hawks.png");
            this.imageListNBA.Images.SetKeyName(8, "Hornets.png");
            this.imageListNBA.Images.SetKeyName(9, "Jazz.png");
            this.imageListNBA.Images.SetKeyName(10, "Kings.png");
            this.imageListNBA.Images.SetKeyName(11, "Knicks.png");
            this.imageListNBA.Images.SetKeyName(12, "Lakers.png");
            this.imageListNBA.Images.SetKeyName(13, "Magic.png");
            this.imageListNBA.Images.SetKeyName(14, "Mavericks.png");
            this.imageListNBA.Images.SetKeyName(15, "NBALogo.png");
            this.imageListNBA.Images.SetKeyName(16, "Nets.png");
            this.imageListNBA.Images.SetKeyName(17, "Nuggets.png");
            this.imageListNBA.Images.SetKeyName(18, "Pacers.png");
            this.imageListNBA.Images.SetKeyName(19, "Pelicans.png");
            this.imageListNBA.Images.SetKeyName(20, "Pistons.png");
            this.imageListNBA.Images.SetKeyName(21, "Raptors.png");
            this.imageListNBA.Images.SetKeyName(22, "Rockets.png");
            this.imageListNBA.Images.SetKeyName(23, "Spurs.png");
            this.imageListNBA.Images.SetKeyName(24, "Suns.png");
            this.imageListNBA.Images.SetKeyName(25, "Thunder.png");
            this.imageListNBA.Images.SetKeyName(26, "Timberwolves.png");
            this.imageListNBA.Images.SetKeyName(27, "TrailBlazers.png");
            this.imageListNBA.Images.SetKeyName(28, "Warriors.png");
            this.imageListNBA.Images.SetKeyName(29, "Wizards.png");
            this.imageListNBA.Images.SetKeyName(30, "Heat.png");
            // 
            // DataForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ClientSize = new System.Drawing.Size(1136, 600);
            this.Controls.Add(this.gBLeague);
            this.Controls.Add(this.dgvData);
            this.Name = "DataForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sports Statistics Dashboard";
            this.Load += new System.EventHandler(this.DataForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).EndInit();
            this.gBLeague.ResumeLayout(false);
            this.gBLeague.PerformLayout();
            this.tCLeagues.ResumeLayout(false);
            this.tPGames.ResumeLayout(false);
            this.tPGames.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAway)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHome)).EndInit();
            this.tPTeams.ResumeLayout(false);
            this.tPTeams.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTeamLogo)).EndInit();
            this.tPPlayers.ResumeLayout(false);
            this.tPPlayers.PerformLayout();
            this.groupBoxNBAPlayerStats.ResumeLayout(false);
            this.groupBoxNBAPlayerStats.PerformLayout();
            this.groupBoxNFLPlayerStats.ResumeLayout(false);
            this.groupBoxNFLPlayerStats.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBSport)).EndInit();
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.Button btnUserSettings;
        private System.Windows.Forms.PictureBox pBSport;
        private System.Windows.Forms.GroupBox gBLeague;
        private System.Windows.Forms.ImageList imageListNFL;
        private System.Windows.Forms.ImageList imageListNBA;
        private System.Windows.Forms.ComboBox comboWeek;
        private System.Windows.Forms.Label labelWeek;
        private System.Windows.Forms.TabControl tCLeagues;
        private System.Windows.Forms.TabPage tPGames;
        private System.Windows.Forms.DateTimePicker dateTimeGame;
        private System.Windows.Forms.TextBox tBDate;
        private System.Windows.Forms.TextBox tBStatium;
        private System.Windows.Forms.TextBox tBHomeTeam;
        private System.Windows.Forms.TextBox tBAwayTeam;
        private System.Windows.Forms.TextBox tBHomeScore;
        private System.Windows.Forms.TextBox tBAwayScore;
        private System.Windows.Forms.PictureBox pictureBoxAway;
        private System.Windows.Forms.Label lblAt;
        private System.Windows.Forms.Label lblVS;
        private System.Windows.Forms.PictureBox pictureBoxHome;
        private System.Windows.Forms.ListBox listBoxGames;
        private System.Windows.Forms.Label lblAway;
        private System.Windows.Forms.Label lblHome;
        private System.Windows.Forms.TabPage tPTeams;
        private System.Windows.Forms.TextBox tBTeamConference;
        private System.Windows.Forms.TextBox tBTeamDivision;
        private System.Windows.Forms.TextBox tBTeamCity;
        private System.Windows.Forms.TextBox tBTeamLoss;
        private System.Windows.Forms.TextBox tBTeamTies;
        private System.Windows.Forms.TextBox tBTeamWins;
        private System.Windows.Forms.Label lblWinLossRating;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lBTopPlayers;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblTeamName;
        private System.Windows.Forms.PictureBox pictureBoxTeamLogo;
        private System.Windows.Forms.ListBox listBoxTeam;
        private System.Windows.Forms.TabPage tPPlayers;
        private System.Windows.Forms.GroupBox groupBoxNBAPlayerStats;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.TextBox tBNBASteals;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.TextBox tBNBATurnovers;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.TextBox tBNBABlocks;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.TextBox tBNBAFreeThrowsMade;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.TextBox tBNBAFreeThrowsAttempt;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.TextBox tBNBAThreePointers;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.TextBox tBNBARebounds;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.TextBox tBNBAAssists;
        private System.Windows.Forms.Label label35;
        private System.Windows.Forms.TextBox tBNBAPoints;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.GroupBox groupBoxNFLPlayerStats;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.TextBox tBNFLSacks;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.TextBox tBNFLInterceptions;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.TextBox tBNFLTackles;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox tBNFLYReceiving;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox tBNFLYRushing;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TextBox tBNFLYPassing;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox tBNFLTDReceiving;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox tBNFLTDRushing;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox tBNFLTDPassing;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lblPlayerName;
        private System.Windows.Forms.TextBox tbPlayerPosition;
        private System.Windows.Forms.TextBox tBPlayerTeam;
        private System.Windows.Forms.CheckBox cBTeamFilter;
        private System.Windows.Forms.ComboBox comboBoxTeamList;
        private System.Windows.Forms.ListBox listBoxPlayer;
    }
}