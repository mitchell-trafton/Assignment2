using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment2
{
    public partial class player_guild_management : Form
    {
        public player_guild_management()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
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
