﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/************************************************************
 * Assignment 2
 * Programmers: Robert Tyler Trotter z1802019
 *              Mitchell Trafton     z1831076
 ***********************************************************/

namespace Assignment2
{
    public partial class player_guild_management : Form
    {
        private StringWriter sw; //console output
        private List<uint> displayPlayerIDs = new List<uint>();//list of IDs corresponding with players being shown in playerList_lbx
        private List<uint> displayGuildIDs = new List<uint>();//list of IDs corresponding with guilds being shown in guildList_lbx

        private void UpdateFilters(string playerFltr = "", string guildFltr = "")
        {
            /********************************************************************************************************
             * Updates the filters for the playerList and guildList listboxes and updates the listboxes accordingly.
             *******************************************************************************************************/
            
            //clear the saved player/guild IDs and their listboxes
            displayPlayerIDs.Clear();
            displayGuildIDs.Clear();
            playerList_lbx.Items.Clear();
            guildList_lbx.Items.Clear();

            foreach (KeyValuePair<uint, Player> player in Globals.characters)
            {
                if (player.Value.Name.StartsWith(playerFltr))
                {
                    playerList_lbx.Items.Add(player.Value.ToStringBasic());
                    displayPlayerIDs.Add(player.Key);
                }
            }

            foreach (KeyValuePair<uint, Assignment2.Guild> guild in Globals.guilds)
            {
                if (guild.Value.Name.StartsWith(guildFltr))
                {
                    guildList_lbx.Items.Add(guild.Value.ToStringBasic());
                    displayGuildIDs.Add(guild.Key);
                }
            }
        }

        public player_guild_management()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            /***********************************************************************
             * Handler for Form 1 load.
             * 
             * Initiates the StringWriter for console output and populates all
             * listboxes/comoboboxes in form except for newPlayerClass_cbx.
             **********************************************************************/

            //initialize StringWriter object for reading text from console output
            sw = new StringWriter();
            Console.SetOut(sw);


            //populate newPlayerRace_cbx
            foreach (Race r in Enum.GetValues(typeof(Race)))
                newPlayerRace_cbx.Items.Add(Enum.GetName(typeof(Race), r));

            //populate newPlayerClass_cbx
            foreach (Class c in Enum.GetValues(typeof(Class)))
                newPlayerClass_cbx.Items.Add(Enum.GetName(typeof(Class), c));

            //populate newGuildServer_cbx
            foreach (KeyValuePair<uint, Guild> guild in Globals.guilds)
                if (!newGuildServer_cbx.Items.Contains(guild.Value.Server))
                    newGuildServer_cbx.Items.Add(guild.Value.Server);

            //populate newGuildType_cbx
            foreach (GuildType g in Enum.GetValues(typeof(GuildType)))
            {
                if (Enum.GetName(typeof(GuildType), g) == "MythicPls") newGuildType_cbx.Items.Add("Mythic+");
                else newGuildType_cbx.Items.Add(Enum.GetName(typeof(GuildType), g));
            }

            //populate playerList_lbx and guildList_lbx
            UpdateFilters();

            output_txt.Text = sw.ToString();
        }

        private void printRoster_btn_Click(object sender, EventArgs e)
        {
            /************************************************************
             * onClick handler for printRoster_btn.
             * 
             * Prints list of all players with their guild information.
             ************************************************************/

            List<string> playerList = Globals.game.PrintPlayer();

            output_txt.Clear();

            output_txt.AppendText("Guild Listing for All Guilds" + Environment.NewLine);

            output_txt.AppendText("-------------------------------------------------------------------------------------" + Environment.NewLine);

            foreach (string player in playerList) output_txt.AppendText(player + Environment.NewLine);

        }

        private void addNewPlayer_btn_Click(object sender, EventArgs e)
        {
            /*************************************************************
             * onClick handler for addNewPlayer_btn.
             * 
             * Adds a new player to the global characters list and players.txt
             * using data from the fields in newPlayer_gbx.
             *************************************************************/

            uint newPlayerID = 0; //id for new player

            if (newPlayerClass_cbx.SelectedIndex == -1 || newPlayerRace_cbx.SelectedIndex == -1 || newPlayerRole_cbx.SelectedIndex == -1 || newPlayerName_txt.Text == "")
            {
                //if any field for new player is blank, don't create a new player and display an appropriate message
                output_txt.Text = "New player not created. Please fill out all fields.";
            }
            else
            {
                //generate new player ID by adding the numerical values of each character in player name and moding it by 99999999
                foreach (char c in newPlayerName_txt.Text)
                    newPlayerID += (uint)c;
                newPlayerID %= 99999999;
                //keep adding 1 to newPlayerID until it doesn't match any existing player IDs
                while (Globals.characters.ContainsKey(newPlayerID)) newPlayerID++;

                //attempt to add new player to file
                if (Globals.game.AddPlayer(new Player(ID:newPlayerID, Name:newPlayerName_txt.Text, Race_:(Race)newPlayerRace_cbx.SelectedIndex, setClass:(Class)newPlayerClass_cbx.SelectedIndex, 
                                                      Role_:Constants.allowedRolls[(Class)newPlayerClass_cbx.SelectedIndex][newPlayerRole_cbx.SelectedIndex])))
                {//if player creation was successful, update playerList_cbx and display a success message
                    UpdateFilters();
                    output_txt.Text = "New player '" + newPlayerName_txt.Text + "' successfully created!";

                    //clear fields
                    newPlayerClass_cbx.SelectedIndex = -1;
                    newPlayerRace_cbx.SelectedIndex = -1;
                    newPlayerRole_cbx.SelectedIndex = -1;
                    newPlayerName_txt.Text = "";
                }
                else
                {//if new player creation was not successful, display an error message
                    output_txt.Text = "Error: Unable to add new player to player list. Please try again later.";
                }
            }
        }

        private void addNewGuild_btn_Click(object sender, EventArgs e)
        {
            /*************************************************************
             * onClick handler for addNewGuild_btn.
             * 
             * Adds a new player to the global guilds list and guilds.txt
             * using data from the fields in newGuild_gbx.
             *************************************************************/

            uint newGuildID = 0; //id for new guild

            if (newGuildName_txt.Text == "" || newGuildServer_cbx.SelectedIndex == -1 || newGuildType_cbx.SelectedIndex == -1)
            {//if any field for new guild is blank, don't create an new guild and display an appropriate message
                output_txt.Text = "New guild not created. Please fill out all fields.";
            }
            else
            {
                //generate new guild ID by adding the numerical values of each character in guild name and moding it by 999999
                foreach (char c in newGuildName_txt.Text)
                    newGuildID += (uint)c;
                newGuildID %= 999999;
                //keep adding 1 to newGuildID until it doesn't match any existing guild IDs
                while (Globals.guilds.ContainsKey(newGuildID)) newGuildID++;

                //attempt to add new guild to file
                if (Globals.game.AddGuild(new Guild(tid: newGuildID, tname: newGuildName_txt.Text, ttype:(GuildType)newGuildType_cbx.SelectedIndex, tserver: newGuildServer_cbx.Text)))
                {//if guild creation was successful, update guildList_cbx and display a success message
                    UpdateFilters();
                    output_txt.Text = "New guild '" + newGuildName_txt.Text + "' successfully created!";

                    //clear fields
                    newGuildName_txt.Text = "";
                    newGuildServer_cbx.SelectedIndex = -1;
                    newGuildType_cbx.SelectedIndex = -1;
                }
                else
                {//if new guild creation was not successful, display an error message
                    output_txt.Text = "Error: Unable to add new guild to guild list. Please try agian later.";
                }
            }
        }

        private void aplySearchCrit_btn_Click(object sender, EventArgs e)
        {
            /********************************************************
             * onClick handler for applySearchCrit_btn.
             * 
             * Updates filters for form's listboxes using 
             * playerSearch_txt and guildSearch_txt fields.
             ********************************************************/

            UpdateFilters(playerSearch_txt.Text, guildSearch_txt.Text);
        }

        private void newPlayerClass_cbx_SelectedIndexChanged(object sender, EventArgs e)
        {
            /*********************************************************************
             * Handler for newPlayerClass_cbx selection change.
             * 
             * Updates the contents of newPlayerRole_cbx based on the allowed role(s)
             * for the selected class in newPlayerClass_cbx.
             *********************************************************************/

            if (newPlayerClass_cbx.SelectedIndex == -1) return;//do nothing if combobox is being reset

            newPlayerRole_cbx.Items.Clear();
            newPlayerRole_cbx.SelectedIndex = -1;
            newPlayerRole_cbx.Text = "";
            foreach (Role r in Constants.allowedRolls[(Class)newPlayerClass_cbx.SelectedIndex])
            {
                newPlayerRole_cbx.Items.Add(Enum.GetName(typeof(Role), r));
            }
        }

        private void disbandGuild_btn_Click(object sender, EventArgs e)
        {
            /****************************************************************
             * onClick handler for disbandGuild_btn.
             * 
             * Dispands the guild selected in guildList_lbx, and updates guildList_lbx.
             ****************************************************************/

            if (guildList_lbx.SelectedIndex == -1) return; //do nothng if no guild is selected
            sw.Flush();

            if (Globals.game.DisbandGuild(displayGuildIDs[guildList_lbx.SelectedIndex]))
            {//if guild was successfully deleted, display success message and update listboxes
                output_txt.Text = "Guild successfully deleted.";

                UpdateFilters();
            }
            else
            {//if guild was not successfully deleted, display console messages generated by DisbandGuild()
                output_txt.Text = sw.ToString();
            }
        }

        private void joinGuild_btn_Click(object sender, EventArgs e)
        {
            /*********************************************************************
             * onClick handler for joinGuild_btn.
             * 
             * Adds the selected player in playerList_lbx to the guild selected
             * in guildList_lbx.
             * 
             * Player will be removed from previous guild.
             *********************************************************************/

            sw.Flush();

            if (playerList_lbx.SelectedIndex == -1 || guildList_lbx.SelectedIndex == -1) return; //do nothing if there aren't selections for both player and guild

            Globals.game.JoinGuild(displayPlayerIDs[playerList_lbx.SelectedIndex], displayGuildIDs[guildList_lbx.SelectedIndex]);

            output_txt.Text = sw.ToString();
        }

        private void leaveGuild_btn_Click(object sender, EventArgs e)
        {
            /**************************************************************
             * onClick handler for leaveGuild_btn.
             * 
             * Removes selected player in playerList_lbx from their current guild.
             **************************************************************/
            sw.Flush();

            if (playerList_lbx.SelectedIndex == -1) return; //do nothing if there isn't a selection for player

            Globals.game.LeaveGuild(displayPlayerIDs[playerList_lbx.SelectedIndex]);

            output_txt.Text = sw.ToString();
        }
    }

    
}
