using System;

namespace Assignment2
{

	/****************************************
	 * Class Guilds
	 * Purpose:
	 * creates a guild object to hold the
	 * information about various guilds in 
	 * world of conflictcraft
	 ****************************************/
	public class Guild : IComparable
	{
		private uint gid;
		private GuildType type;
		private string name;
		private string server;
		/********************************************
		 * Null constructor
		 * No inputs
		 * this creates a blank guild
		 ********************************************/
		public Guild()
		{
			gid = 0;
			type = (GuildType)0;
			name = "N/A";
			server = "N/A";
		}
		/******************************************************************
		 * guild constructor
		 * inputs uint id, guildType, string name
		 * 
		 * This constructor is for pulling the guild information from the file
		 * server name is parsed from the guild name that is read in.
		 * 
		 ******************************************************************/
		public Guild(uint tid = 0, GuildType ttype = (GuildType)0, string tname = "")
        {
			gid = tid;
			type = ttype;
			string[] subs = tname.Split('-');
			name = subs[0];
			server = subs[1];
			if (!Globals.servers.Contains(server))
			{
				Globals.servers.Add(server);
			}

		}
		/*****************************************************************
		 * guild constructor the second
		 * input: uint id, guildType, string name, string server
		 * 
		 * This constructor is for the user inputed guild, where we don't 
		 * need to parse the servername from the guild name, it's done for us
		 *****************************************************************/
		public Guild(uint tid = 0, GuildType ttype = (GuildType)0, string tname = "", string tserver = "")
		{
			//checks to see if we were given a server name, since loading from file is deliniated by a dash, we will handle it in this class
			gid = tid;
			type = ttype;
			if (String.IsNullOrEmpty(tserver))
			{
				string[] subs = tname.Split('-');
				name = subs[0];
				server = subs[1];
				if (!Globals.servers.Contains(server))
				{
					Globals.servers.Add(server);
				}
			}
			else
            {
				name = tname;
				server = tserver;

            }

		}
		//properties
		public uint GID
		{
			get { return gid; }
			set { gid = value; }
		}
		public GuildType Type
		{
			get { return type; }
			set { type = value; }
		}
		public string Name
		{
			get { return name; }
			set { name = value; }
		}
		public string Server
		{
			get { return server;}
			set { server = value;}
		}

		/************************************************
		 * IComparable implementation
		 * This allows us to compare two guild objects
		 * we will compare by their names.
		 ***********************************************/
		int IComparable.CompareTo(object obj)
        {
			Guild other = (Guild)obj;
			return String.Compare(name, other.name);
		}
		/****************************************************
		 * ToString() override
		 * 
		 * This prints out the name, guild type, and server it resides in
		 ****************************************************/
		public override string ToString()
        {
			return name + "\t" + type + "\t" + server;
        }

		public string ToStringBasic()
        {
			/*************************************************************************************
             * Returns a string containing a guild's name with it's server in brackets.
             *************************************************************************************/
			return name.PadRight(30, ' ') + "\t[" + server + "]";
        }
	}
}
