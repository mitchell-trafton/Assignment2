
namespace Assignment2
{
    partial class player_guild_management
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
            this.managementFunctions_gbx = new System.Windows.Forms.GroupBox();
            this.guildSearch_lbl = new System.Windows.Forms.Label();
            this.guildSearch_txt = new System.Windows.Forms.TextBox();
            this.searchPlayer_lbl = new System.Windows.Forms.Label();
            this.playerSearch_txt = new System.Windows.Forms.TextBox();
            this.aplySearchCrit_btn = new System.Windows.Forms.Button();
            this.leaveGuild_btn = new System.Windows.Forms.Button();
            this.joinGuild_btn = new System.Windows.Forms.Button();
            this.disbandGuild_btn = new System.Windows.Forms.Button();
            this.printRoster_btn = new System.Windows.Forms.Button();
            this.newPlayer_gbx = new System.Windows.Forms.GroupBox();
            this.addNewPlayer_btn = new System.Windows.Forms.Button();
            this.newPlayerRole_cbx = new System.Windows.Forms.ComboBox();
            this.newPlayerRole_lbl = new System.Windows.Forms.Label();
            this.newPlayerRace_cbx = new System.Windows.Forms.ComboBox();
            this.newPlayerRace_lbl = new System.Windows.Forms.Label();
            this.newPlayerClass_cbx = new System.Windows.Forms.ComboBox();
            this.newPlayerClass_lbl = new System.Windows.Forms.Label();
            this.newPlayerNme_lbl = new System.Windows.Forms.Label();
            this.newPlayerName_txt = new System.Windows.Forms.TextBox();
            this.createGuild_gbx = new System.Windows.Forms.GroupBox();
            this.addNewGuild_btn = new System.Windows.Forms.Button();
            this.newGuildType_cbx = new System.Windows.Forms.ComboBox();
            this.newGuildType_lbl = new System.Windows.Forms.Label();
            this.newGuildServer_txt = new System.Windows.Forms.ComboBox();
            this.newGuildServer_lbl = new System.Windows.Forms.Label();
            this.newGuildName_lbl = new System.Windows.Forms.Label();
            this.newGuildName_txt = new System.Windows.Forms.TextBox();
            this.title_lbl = new System.Windows.Forms.Label();
            this.playerList_lbx = new System.Windows.Forms.ListBox();
            this.playerList_lbl = new System.Windows.Forms.Label();
            this.guildList_lbl = new System.Windows.Forms.Label();
            this.guildList_lbx = new System.Windows.Forms.ListBox();
            this.output_lbl = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.managementFunctions_gbx.SuspendLayout();
            this.newPlayer_gbx.SuspendLayout();
            this.createGuild_gbx.SuspendLayout();
            this.SuspendLayout();
            // 
            // managementFunctions_gbx
            // 
            this.managementFunctions_gbx.Controls.Add(this.guildSearch_lbl);
            this.managementFunctions_gbx.Controls.Add(this.guildSearch_txt);
            this.managementFunctions_gbx.Controls.Add(this.searchPlayer_lbl);
            this.managementFunctions_gbx.Controls.Add(this.playerSearch_txt);
            this.managementFunctions_gbx.Controls.Add(this.aplySearchCrit_btn);
            this.managementFunctions_gbx.Controls.Add(this.leaveGuild_btn);
            this.managementFunctions_gbx.Controls.Add(this.joinGuild_btn);
            this.managementFunctions_gbx.Controls.Add(this.disbandGuild_btn);
            this.managementFunctions_gbx.Controls.Add(this.printRoster_btn);
            this.managementFunctions_gbx.ForeColor = System.Drawing.SystemColors.Control;
            this.managementFunctions_gbx.Location = new System.Drawing.Point(12, 45);
            this.managementFunctions_gbx.Name = "managementFunctions_gbx";
            this.managementFunctions_gbx.Size = new System.Drawing.Size(373, 183);
            this.managementFunctions_gbx.TabIndex = 0;
            this.managementFunctions_gbx.TabStop = false;
            this.managementFunctions_gbx.Text = "Management Functions";
            this.managementFunctions_gbx.Enter += new System.EventHandler(this.managementFunctions_gbx_Enter);
            // 
            // guildSearch_lbl
            // 
            this.guildSearch_lbl.AutoSize = true;
            this.guildSearch_lbl.Location = new System.Drawing.Point(161, 90);
            this.guildSearch_lbl.Name = "guildSearch_lbl";
            this.guildSearch_lbl.Size = new System.Drawing.Size(122, 13);
            this.guildSearch_lbl.TabIndex = 8;
            this.guildSearch_lbl.Text = "Search Guild (by Server)";
            // 
            // guildSearch_txt
            // 
            this.guildSearch_txt.Location = new System.Drawing.Point(164, 106);
            this.guildSearch_txt.Name = "guildSearch_txt";
            this.guildSearch_txt.Size = new System.Drawing.Size(117, 20);
            this.guildSearch_txt.TabIndex = 7;
            // 
            // searchPlayer_lbl
            // 
            this.searchPlayer_lbl.AutoSize = true;
            this.searchPlayer_lbl.Location = new System.Drawing.Point(161, 32);
            this.searchPlayer_lbl.Name = "searchPlayer_lbl";
            this.searchPlayer_lbl.Size = new System.Drawing.Size(124, 13);
            this.searchPlayer_lbl.TabIndex = 6;
            this.searchPlayer_lbl.Text = "Search Player (by Name)";
            // 
            // playerSearch_txt
            // 
            this.playerSearch_txt.Location = new System.Drawing.Point(164, 48);
            this.playerSearch_txt.Name = "playerSearch_txt";
            this.playerSearch_txt.Size = new System.Drawing.Size(117, 20);
            this.playerSearch_txt.TabIndex = 5;
            // 
            // aplySearchCrit_btn
            // 
            this.aplySearchCrit_btn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.aplySearchCrit_btn.Location = new System.Drawing.Point(6, 135);
            this.aplySearchCrit_btn.Name = "aplySearchCrit_btn";
            this.aplySearchCrit_btn.Size = new System.Drawing.Size(124, 23);
            this.aplySearchCrit_btn.TabIndex = 4;
            this.aplySearchCrit_btn.Text = "Apply Search Criteria";
            this.aplySearchCrit_btn.UseVisualStyleBackColor = true;
            // 
            // leaveGuild_btn
            // 
            this.leaveGuild_btn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.leaveGuild_btn.Location = new System.Drawing.Point(6, 106);
            this.leaveGuild_btn.Name = "leaveGuild_btn";
            this.leaveGuild_btn.Size = new System.Drawing.Size(124, 23);
            this.leaveGuild_btn.TabIndex = 3;
            this.leaveGuild_btn.Text = "Leave Guild";
            this.leaveGuild_btn.UseVisualStyleBackColor = true;
            // 
            // joinGuild_btn
            // 
            this.joinGuild_btn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.joinGuild_btn.Location = new System.Drawing.Point(6, 77);
            this.joinGuild_btn.Name = "joinGuild_btn";
            this.joinGuild_btn.Size = new System.Drawing.Size(124, 23);
            this.joinGuild_btn.TabIndex = 2;
            this.joinGuild_btn.Text = "Join Guild";
            this.joinGuild_btn.UseVisualStyleBackColor = true;
            // 
            // disbandGuild_btn
            // 
            this.disbandGuild_btn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.disbandGuild_btn.Location = new System.Drawing.Point(6, 48);
            this.disbandGuild_btn.Name = "disbandGuild_btn";
            this.disbandGuild_btn.Size = new System.Drawing.Size(124, 23);
            this.disbandGuild_btn.TabIndex = 1;
            this.disbandGuild_btn.Text = "Disband Guild";
            this.disbandGuild_btn.UseVisualStyleBackColor = true;
            // 
            // printRoster_btn
            // 
            this.printRoster_btn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.printRoster_btn.Location = new System.Drawing.Point(6, 19);
            this.printRoster_btn.Name = "printRoster_btn";
            this.printRoster_btn.Size = new System.Drawing.Size(124, 23);
            this.printRoster_btn.TabIndex = 0;
            this.printRoster_btn.Text = "Print Guild Roster";
            this.printRoster_btn.UseVisualStyleBackColor = true;
            // 
            // newPlayer_gbx
            // 
            this.newPlayer_gbx.Controls.Add(this.addNewPlayer_btn);
            this.newPlayer_gbx.Controls.Add(this.newPlayerRole_cbx);
            this.newPlayer_gbx.Controls.Add(this.newPlayerRole_lbl);
            this.newPlayer_gbx.Controls.Add(this.newPlayerRace_cbx);
            this.newPlayer_gbx.Controls.Add(this.newPlayerRace_lbl);
            this.newPlayer_gbx.Controls.Add(this.newPlayerClass_cbx);
            this.newPlayer_gbx.Controls.Add(this.newPlayerClass_lbl);
            this.newPlayer_gbx.Controls.Add(this.newPlayerNme_lbl);
            this.newPlayer_gbx.Controls.Add(this.newPlayerName_txt);
            this.newPlayer_gbx.ForeColor = System.Drawing.SystemColors.Control;
            this.newPlayer_gbx.Location = new System.Drawing.Point(12, 243);
            this.newPlayer_gbx.Name = "newPlayer_gbx";
            this.newPlayer_gbx.Size = new System.Drawing.Size(373, 125);
            this.newPlayer_gbx.TabIndex = 1;
            this.newPlayer_gbx.TabStop = false;
            this.newPlayer_gbx.Text = "Create New Player";
            // 
            // addNewPlayer_btn
            // 
            this.addNewPlayer_btn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.addNewPlayer_btn.Location = new System.Drawing.Point(282, 32);
            this.addNewPlayer_btn.Name = "addNewPlayer_btn";
            this.addNewPlayer_btn.Size = new System.Drawing.Size(75, 23);
            this.addNewPlayer_btn.TabIndex = 9;
            this.addNewPlayer_btn.Text = "Add Player";
            this.addNewPlayer_btn.UseVisualStyleBackColor = true;
            // 
            // newPlayerRole_cbx
            // 
            this.newPlayerRole_cbx.FormattingEnabled = true;
            this.newPlayerRole_cbx.Location = new System.Drawing.Point(139, 81);
            this.newPlayerRole_cbx.Name = "newPlayerRole_cbx";
            this.newPlayerRole_cbx.Size = new System.Drawing.Size(117, 21);
            this.newPlayerRole_cbx.TabIndex = 15;
            // 
            // newPlayerRole_lbl
            // 
            this.newPlayerRole_lbl.AutoSize = true;
            this.newPlayerRole_lbl.Location = new System.Drawing.Point(136, 65);
            this.newPlayerRole_lbl.Name = "newPlayerRole_lbl";
            this.newPlayerRole_lbl.Size = new System.Drawing.Size(29, 13);
            this.newPlayerRole_lbl.TabIndex = 14;
            this.newPlayerRole_lbl.Text = "Role";
            // 
            // newPlayerRace_cbx
            // 
            this.newPlayerRace_cbx.FormattingEnabled = true;
            this.newPlayerRace_cbx.Location = new System.Drawing.Point(139, 34);
            this.newPlayerRace_cbx.Name = "newPlayerRace_cbx";
            this.newPlayerRace_cbx.Size = new System.Drawing.Size(117, 21);
            this.newPlayerRace_cbx.TabIndex = 13;
            // 
            // newPlayerRace_lbl
            // 
            this.newPlayerRace_lbl.AutoSize = true;
            this.newPlayerRace_lbl.Location = new System.Drawing.Point(136, 18);
            this.newPlayerRace_lbl.Name = "newPlayerRace_lbl";
            this.newPlayerRace_lbl.Size = new System.Drawing.Size(33, 13);
            this.newPlayerRace_lbl.TabIndex = 12;
            this.newPlayerRace_lbl.Text = "Race";
            // 
            // newPlayerClass_cbx
            // 
            this.newPlayerClass_cbx.FormattingEnabled = true;
            this.newPlayerClass_cbx.Location = new System.Drawing.Point(6, 81);
            this.newPlayerClass_cbx.Name = "newPlayerClass_cbx";
            this.newPlayerClass_cbx.Size = new System.Drawing.Size(117, 21);
            this.newPlayerClass_cbx.TabIndex = 11;
            // 
            // newPlayerClass_lbl
            // 
            this.newPlayerClass_lbl.AutoSize = true;
            this.newPlayerClass_lbl.Location = new System.Drawing.Point(3, 65);
            this.newPlayerClass_lbl.Name = "newPlayerClass_lbl";
            this.newPlayerClass_lbl.Size = new System.Drawing.Size(32, 13);
            this.newPlayerClass_lbl.TabIndex = 10;
            this.newPlayerClass_lbl.Text = "Class";
            // 
            // newPlayerNme_lbl
            // 
            this.newPlayerNme_lbl.AutoSize = true;
            this.newPlayerNme_lbl.Location = new System.Drawing.Point(3, 19);
            this.newPlayerNme_lbl.Name = "newPlayerNme_lbl";
            this.newPlayerNme_lbl.Size = new System.Drawing.Size(67, 13);
            this.newPlayerNme_lbl.TabIndex = 8;
            this.newPlayerNme_lbl.Text = "Player Name";
            // 
            // newPlayerName_txt
            // 
            this.newPlayerName_txt.Location = new System.Drawing.Point(6, 35);
            this.newPlayerName_txt.Name = "newPlayerName_txt";
            this.newPlayerName_txt.Size = new System.Drawing.Size(117, 20);
            this.newPlayerName_txt.TabIndex = 7;
            // 
            // createGuild_gbx
            // 
            this.createGuild_gbx.Controls.Add(this.addNewGuild_btn);
            this.createGuild_gbx.Controls.Add(this.newGuildType_cbx);
            this.createGuild_gbx.Controls.Add(this.newGuildType_lbl);
            this.createGuild_gbx.Controls.Add(this.newGuildServer_txt);
            this.createGuild_gbx.Controls.Add(this.newGuildServer_lbl);
            this.createGuild_gbx.Controls.Add(this.newGuildName_lbl);
            this.createGuild_gbx.Controls.Add(this.newGuildName_txt);
            this.createGuild_gbx.ForeColor = System.Drawing.SystemColors.Control;
            this.createGuild_gbx.Location = new System.Drawing.Point(12, 394);
            this.createGuild_gbx.Name = "createGuild_gbx";
            this.createGuild_gbx.Size = new System.Drawing.Size(373, 118);
            this.createGuild_gbx.TabIndex = 2;
            this.createGuild_gbx.TabStop = false;
            this.createGuild_gbx.Text = "Create New Guild";
            // 
            // addNewGuild_btn
            // 
            this.addNewGuild_btn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.addNewGuild_btn.Location = new System.Drawing.Point(282, 32);
            this.addNewGuild_btn.Name = "addNewGuild_btn";
            this.addNewGuild_btn.Size = new System.Drawing.Size(75, 23);
            this.addNewGuild_btn.TabIndex = 19;
            this.addNewGuild_btn.Text = "Add Guild";
            this.addNewGuild_btn.UseVisualStyleBackColor = true;
            // 
            // newGuildType_cbx
            // 
            this.newGuildType_cbx.FormattingEnabled = true;
            this.newGuildType_cbx.Location = new System.Drawing.Point(139, 82);
            this.newGuildType_cbx.Name = "newGuildType_cbx";
            this.newGuildType_cbx.Size = new System.Drawing.Size(117, 21);
            this.newGuildType_cbx.TabIndex = 18;
            // 
            // newGuildType_lbl
            // 
            this.newGuildType_lbl.AutoSize = true;
            this.newGuildType_lbl.Location = new System.Drawing.Point(136, 67);
            this.newGuildType_lbl.Name = "newGuildType_lbl";
            this.newGuildType_lbl.Size = new System.Drawing.Size(31, 13);
            this.newGuildType_lbl.TabIndex = 17;
            this.newGuildType_lbl.Text = "Type";
            // 
            // newGuildServer_txt
            // 
            this.newGuildServer_txt.FormattingEnabled = true;
            this.newGuildServer_txt.Location = new System.Drawing.Point(139, 34);
            this.newGuildServer_txt.Name = "newGuildServer_txt";
            this.newGuildServer_txt.Size = new System.Drawing.Size(117, 21);
            this.newGuildServer_txt.TabIndex = 16;
            // 
            // newGuildServer_lbl
            // 
            this.newGuildServer_lbl.AutoSize = true;
            this.newGuildServer_lbl.Location = new System.Drawing.Point(136, 19);
            this.newGuildServer_lbl.Name = "newGuildServer_lbl";
            this.newGuildServer_lbl.Size = new System.Drawing.Size(38, 13);
            this.newGuildServer_lbl.TabIndex = 12;
            this.newGuildServer_lbl.Text = "Server";
            // 
            // newGuildName_lbl
            // 
            this.newGuildName_lbl.AutoSize = true;
            this.newGuildName_lbl.Location = new System.Drawing.Point(3, 19);
            this.newGuildName_lbl.Name = "newGuildName_lbl";
            this.newGuildName_lbl.Size = new System.Drawing.Size(62, 13);
            this.newGuildName_lbl.TabIndex = 10;
            this.newGuildName_lbl.Text = "Guild Name";
            // 
            // newGuildName_txt
            // 
            this.newGuildName_txt.Location = new System.Drawing.Point(6, 35);
            this.newGuildName_txt.Name = "newGuildName_txt";
            this.newGuildName_txt.Size = new System.Drawing.Size(117, 20);
            this.newGuildName_txt.TabIndex = 9;
            // 
            // title_lbl
            // 
            this.title_lbl.AutoSize = true;
            this.title_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.title_lbl.ForeColor = System.Drawing.SystemColors.Control;
            this.title_lbl.Location = new System.Drawing.Point(241, 11);
            this.title_lbl.Name = "title_lbl";
            this.title_lbl.Size = new System.Drawing.Size(424, 31);
            this.title_lbl.TabIndex = 3;
            this.title_lbl.Text = "Player/Guild Management System";
            // 
            // playerList_lbx
            // 
            this.playerList_lbx.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.playerList_lbx.FormattingEnabled = true;
            this.playerList_lbx.Location = new System.Drawing.Point(467, 88);
            this.playerList_lbx.Name = "playerList_lbx";
            this.playerList_lbx.Size = new System.Drawing.Size(198, 420);
            this.playerList_lbx.TabIndex = 4;
            // 
            // playerList_lbl
            // 
            this.playerList_lbl.AutoSize = true;
            this.playerList_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.playerList_lbl.ForeColor = System.Drawing.SystemColors.Control;
            this.playerList_lbl.Location = new System.Drawing.Point(462, 60);
            this.playerList_lbl.Name = "playerList_lbl";
            this.playerList_lbl.Size = new System.Drawing.Size(77, 25);
            this.playerList_lbl.TabIndex = 5;
            this.playerList_lbl.Text = "Players";
            // 
            // guildList_lbl
            // 
            this.guildList_lbl.AutoSize = true;
            this.guildList_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.guildList_lbl.ForeColor = System.Drawing.SystemColors.Control;
            this.guildList_lbl.Location = new System.Drawing.Point(701, 60);
            this.guildList_lbl.Name = "guildList_lbl";
            this.guildList_lbl.Size = new System.Drawing.Size(67, 25);
            this.guildList_lbl.TabIndex = 7;
            this.guildList_lbl.Text = "Guilds";
            // 
            // guildList_lbx
            // 
            this.guildList_lbx.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.guildList_lbx.FormattingEnabled = true;
            this.guildList_lbx.Location = new System.Drawing.Point(706, 90);
            this.guildList_lbx.Name = "guildList_lbx";
            this.guildList_lbx.Size = new System.Drawing.Size(229, 420);
            this.guildList_lbx.TabIndex = 6;
            // 
            // output_lbl
            // 
            this.output_lbl.AutoSize = true;
            this.output_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.output_lbl.ForeColor = System.Drawing.SystemColors.Control;
            this.output_lbl.Location = new System.Drawing.Point(13, 546);
            this.output_lbl.Name = "output_lbl";
            this.output_lbl.Size = new System.Drawing.Size(71, 25);
            this.output_lbl.TabIndex = 8;
            this.output_lbl.Text = "Output";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(18, 574);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(947, 142);
            this.textBox1.TabIndex = 9;
            // 
            // player_guild_management
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Desktop;
            this.ClientSize = new System.Drawing.Size(977, 728);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.output_lbl);
            this.Controls.Add(this.guildList_lbl);
            this.Controls.Add(this.guildList_lbx);
            this.Controls.Add(this.playerList_lbl);
            this.Controls.Add(this.playerList_lbx);
            this.Controls.Add(this.title_lbl);
            this.Controls.Add(this.createGuild_gbx);
            this.Controls.Add(this.newPlayer_gbx);
            this.Controls.Add(this.managementFunctions_gbx);
            this.Name = "player_guild_management";
            this.Text = "Player/Guild Management System";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.managementFunctions_gbx.ResumeLayout(false);
            this.managementFunctions_gbx.PerformLayout();
            this.newPlayer_gbx.ResumeLayout(false);
            this.newPlayer_gbx.PerformLayout();
            this.createGuild_gbx.ResumeLayout(false);
            this.createGuild_gbx.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox managementFunctions_gbx;
        private System.Windows.Forms.Button disbandGuild_btn;
        private System.Windows.Forms.Button printRoster_btn;
        private System.Windows.Forms.Button leaveGuild_btn;
        private System.Windows.Forms.Button joinGuild_btn;
        private System.Windows.Forms.Label guildSearch_lbl;
        private System.Windows.Forms.TextBox guildSearch_txt;
        private System.Windows.Forms.Label searchPlayer_lbl;
        private System.Windows.Forms.TextBox playerSearch_txt;
        private System.Windows.Forms.Button aplySearchCrit_btn;
        private System.Windows.Forms.GroupBox newPlayer_gbx;
        private System.Windows.Forms.Button addNewPlayer_btn;
        private System.Windows.Forms.ComboBox newPlayerRole_cbx;
        private System.Windows.Forms.Label newPlayerRole_lbl;
        private System.Windows.Forms.ComboBox newPlayerRace_cbx;
        private System.Windows.Forms.Label newPlayerRace_lbl;
        private System.Windows.Forms.ComboBox newPlayerClass_cbx;
        private System.Windows.Forms.Label newPlayerClass_lbl;
        private System.Windows.Forms.Label newPlayerNme_lbl;
        private System.Windows.Forms.TextBox newPlayerName_txt;
        private System.Windows.Forms.GroupBox createGuild_gbx;
        private System.Windows.Forms.Button addNewGuild_btn;
        private System.Windows.Forms.ComboBox newGuildType_cbx;
        private System.Windows.Forms.Label newGuildType_lbl;
        private System.Windows.Forms.ComboBox newGuildServer_txt;
        private System.Windows.Forms.Label newGuildServer_lbl;
        private System.Windows.Forms.Label newGuildName_lbl;
        private System.Windows.Forms.TextBox newGuildName_txt;
        private System.Windows.Forms.Label title_lbl;
        private System.Windows.Forms.ListBox playerList_lbx;
        private System.Windows.Forms.Label playerList_lbl;
        private System.Windows.Forms.Label guildList_lbl;
        private System.Windows.Forms.ListBox guildList_lbx;
        private System.Windows.Forms.Label output_lbl;
        private System.Windows.Forms.TextBox textBox1;
    }
}

