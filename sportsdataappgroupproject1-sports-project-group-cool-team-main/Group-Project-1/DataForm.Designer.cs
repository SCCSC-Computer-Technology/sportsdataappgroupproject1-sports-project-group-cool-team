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

        private System.Windows.Forms.Label labelWeek;
        private System.Windows.Forms.ComboBox comboWeek;

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
            this.labelSport = new System.Windows.Forms.Label();
            this.comboSports = new System.Windows.Forms.ComboBox();
            this.labelCategory = new System.Windows.Forms.Label();
            this.comboCategory = new System.Windows.Forms.ComboBox();
            this.labelYear = new System.Windows.Forms.Label();
            this.comboYear = new System.Windows.Forms.ComboBox();
            this.labelWeek = new System.Windows.Forms.Label();
            this.comboWeek = new System.Windows.Forms.ComboBox();
            this.labelSearch = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnClearSearch = new System.Windows.Forms.Button();
            this.btnGo = new System.Windows.Forms.Button();
            this.dgvData = new System.Windows.Forms.DataGridView();
            this.lblLoggedIn = new System.Windows.Forms.Label();
            this.btnLogOut = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).BeginInit();
            this.SuspendLayout();
            // 
            // labelSport
            // 
            this.labelSport.AutoSize = true;
            this.labelSport.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F);
            this.labelSport.Location = new System.Drawing.Point(20, 20);
            this.labelSport.Name = "labelSport";
            this.labelSport.Size = new System.Drawing.Size(49, 16);
            this.labelSport.TabIndex = 0;
            this.labelSport.Text = "Sport:";
            // 
            // comboSports
            // 
            this.comboSports.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboSports.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F);
            this.comboSports.FormattingEnabled = true;
            this.comboSports.Items.AddRange(new object[] {
            "Football",
            "Basketball"});
            this.comboSports.Location = new System.Drawing.Point(75, 17);
            this.comboSports.Name = "comboSports";
            this.comboSports.Size = new System.Drawing.Size(140, 24);
            this.comboSports.TabIndex = 1;
            // 
            // labelCategory
            // 
            this.labelCategory.AutoSize = true;
            this.labelCategory.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F);
            this.labelCategory.Location = new System.Drawing.Point(235, 20);
            this.labelCategory.Name = "labelCategory";
            this.labelCategory.Size = new System.Drawing.Size(73, 16);
            this.labelCategory.TabIndex = 2;
            this.labelCategory.Text = "Category:";
            // 
            // comboCategory
            // 
            this.comboCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboCategory.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F);
            this.comboCategory.FormattingEnabled = true;
            this.comboCategory.Items.AddRange(new object[] {
            "Teams",
            "Standings",
            "Games",
            "Players"});
            this.comboCategory.Location = new System.Drawing.Point(320, 17);
            this.comboCategory.Name = "comboCategory";
            this.comboCategory.Size = new System.Drawing.Size(140, 24);
            this.comboCategory.TabIndex = 3;
            // 
            // labelYear
            // 
            this.labelYear.AutoSize = true;
            this.labelYear.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F);
            this.labelYear.Location = new System.Drawing.Point(480, 20);
            this.labelYear.Name = "labelYear";
            this.labelYear.Size = new System.Drawing.Size(43, 16);
            this.labelYear.TabIndex = 4;
            this.labelYear.Text = "Year:";
            // 
            // comboYear
            // 
            this.comboYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboYear.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F);
            this.comboYear.FormattingEnabled = true;
            this.comboYear.Location = new System.Drawing.Point(525, 17);
            this.comboYear.Name = "comboYear";
            this.comboYear.Size = new System.Drawing.Size(85, 24);
            this.comboYear.TabIndex = 5;
            // 
            // labelWeek
            // 
            this.labelWeek.AutoSize = true;
            this.labelWeek.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F);
            this.labelWeek.Location = new System.Drawing.Point(625, 20);
            this.labelWeek.Name = "labelWeek";
            this.labelWeek.Size = new System.Drawing.Size(49, 16);
            this.labelWeek.TabIndex = 6;
            this.labelWeek.Text = "Week:";
            // 
            // comboWeek
            // 
            this.comboWeek.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboWeek.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F);
            this.comboWeek.FormattingEnabled = true;
            this.comboWeek.Location = new System.Drawing.Point(675, 17);
            this.comboWeek.Name = "comboWeek";
            this.comboWeek.Size = new System.Drawing.Size(70, 24);
            this.comboWeek.TabIndex = 7;
            // 
            // labelSearch
            // 
            this.labelSearch.AutoSize = true;
            this.labelSearch.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F);
            this.labelSearch.Location = new System.Drawing.Point(765, 20);
            this.labelSearch.Name = "labelSearch";
            this.labelSearch.Size = new System.Drawing.Size(59, 16);
            this.labelSearch.TabIndex = 8;
            this.labelSearch.Text = "Search:";
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F);
            this.txtSearch.Location = new System.Drawing.Point(830, 17);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(150, 23);
            this.txtSearch.TabIndex = 9;
            // 
            // btnClearSearch
            // 
            this.btnClearSearch.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F);
            this.btnClearSearch.Location = new System.Drawing.Point(990, 16);
            this.btnClearSearch.Name = "btnClearSearch";
            this.btnClearSearch.Size = new System.Drawing.Size(70, 26);
            this.btnClearSearch.TabIndex = 10;
            this.btnClearSearch.Text = "Clear";
            this.btnClearSearch.UseVisualStyleBackColor = true;
            this.btnClearSearch.Click += new System.EventHandler(this.btnClearSearch_Click);
            // 
            // btnGo
            // 
            this.btnGo.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F);
            this.btnGo.Location = new System.Drawing.Point(1065, 16);
            this.btnGo.Name = "btnGo";
            this.btnGo.Size = new System.Drawing.Size(60, 26);
            this.btnGo.TabIndex = 11;
            this.btnGo.Text = "Go";
            this.btnGo.UseVisualStyleBackColor = true;
            this.btnGo.Click += new System.EventHandler(this.btnGo_Click);
            // 
            // dgvData
            // 
            this.dgvData.BackgroundColor = System.Drawing.Color.White;
            this.dgvData.Location = new System.Drawing.Point(20, 60);
            this.dgvData.Name = "dgvData";
            this.dgvData.Size = new System.Drawing.Size(1104, 460);
            this.dgvData.TabIndex = 12;
            // 
            // lblLoggedIn
            // 
            this.lblLoggedIn.AutoSize = true;
            this.lblLoggedIn.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F);
            this.lblLoggedIn.Location = new System.Drawing.Point(20, 545);
            this.lblLoggedIn.Name = "lblLoggedIn";
            this.lblLoggedIn.Size = new System.Drawing.Size(78, 16);
            this.lblLoggedIn.TabIndex = 13;
            this.lblLoggedIn.Text = "Logged In:";
            // 
            // btnLogOut
            // 
            this.btnLogOut.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F);
            this.btnLogOut.Location = new System.Drawing.Point(980, 538);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(100, 26);
            this.btnLogOut.TabIndex = 14;
            this.btnLogOut.Text = "Log Out";
            this.btnLogOut.UseVisualStyleBackColor = true;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // DataForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ClientSize = new System.Drawing.Size(1136, 600);
            this.Controls.Add(this.labelSport);
            this.Controls.Add(this.comboSports);
            this.Controls.Add(this.labelCategory);
            this.Controls.Add(this.comboCategory);
            this.Controls.Add(this.labelYear);
            this.Controls.Add(this.comboYear);
            this.Controls.Add(this.labelWeek);
            this.Controls.Add(this.comboWeek);
            this.Controls.Add(this.labelSearch);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.btnClearSearch);
            this.Controls.Add(this.btnGo);
            this.Controls.Add(this.dgvData);
            this.Controls.Add(this.lblLoggedIn);
            this.Controls.Add(this.btnLogOut);
            this.Name = "DataForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sports Statistics Dashboard";
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}