using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment2
{
    public partial class player_guild_management : Form
    {
        private StringWriter sw; //console output
        private List<uint> displayPlayerIDs = new List<uint>();//list of IDs corresponding with players being shown in playerList_lbx

        private void UpdateFilters(string playerFltr = "", string guildFltr = "")
        {
            /********************************************************************************************************
             * Updates the filters for the playerList and guildList listboxes and updates the listboxes accordingly.
             *******************************************************************************************************/
            
            //clear the saved player/guild IDs and their listboxes
            displayPlayerIDs.Clear();
            playerList_lbx.Items.Clear();

            foreach (KeyValuePair<uint, Player> player in Globals.characters)
            {
                if (player.Value.Name.StartsWith(playerFltr))
                {
                    playerList_lbx.Items.Add(player.Value.ToStringBasic());
                    displayPlayerIDs.Add(player.Key);
                }
            }
        }

        public player_guild_management()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //initialize StringWriter object for reading text from console output
            sw = new StringWriter();
            //Console.SetOut(sw);


            //populate newPlayerRace_cbx
            foreach (Race r in Enum.GetValues(typeof(Race)))
                newPlayerRace_cbx.Items.Add(Enum.GetName(typeof(Race), r));

            //populate newPlayerClass_cbx
            foreach (Class c in Enum.GetValues(typeof(Class)))
                newPlayerClass_cbx.Items.Add(Enum.GetName(typeof(Class), c));

            //populate newPlayerRoll_cbx
            foreach (Role r in Enum.GetValues(typeof(Role)))
                newPlayerRole_cbx.Items.Add(Enum.GetName(typeof(Role), r));

            //populate newGuildServer_cbx
            foreach (string server in Globals.servers)
                newGuildServer_cbx.Items.Add(server);

            //populate newGuildType_cbx
            foreach (GuildType g in Enum.GetValues(typeof(GuildType)))
            {
                if (Enum.GetName(typeof(GuildType), g) == "MythicPls") newGuildType_cbx.Items.Add("Mythic+");
                else newGuildType_cbx.Items.Add(Enum.GetName(typeof(GuildType), g));
            }

            //populate playerList_lbx
            UpdateFilters();

            output_txt.Text = sw.ToString();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void managementFunctions_gbx_Enter(object sender, EventArgs e)
        {

        }

        private void printRoster_btn_Click(object sender, EventArgs e)
        {

            List<string> playerList = Globals.game.PrintPlayer();

            output_txt.Clear();

            output_txt.AppendText("Guild Listing for All Guilds" + Environment.NewLine);

            output_txt.AppendText("-------------------------------------------------------------------------------------" + Environment.NewLine);

            foreach (string player in playerList) output_txt.AppendText(player + Environment.NewLine);

        }

        private void joinGuild_btn_Click(object sender, EventArgs e)
        {
            output_txt.Clear();

            output_txt.Text = "work in progress";
        }

        private void addNewPlayer_btn_Click(object sender, EventArgs e)
        {
            
        }
    }
}
