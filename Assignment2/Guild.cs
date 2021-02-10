﻿using System;

namespace Assignment2
{
	public class Guild : IComparable
	{
		private uint gid;
		private GuildType type;
		private string name;
		private string server;
		public Guild()
		{
			gid = 0;
			type = (GuildType)0;
			name = "N/A";
			server = "N/A";
		}
		public Guild(uint tid, GuildType ttype, string tname, string? tserver = null)
		{
			//checks to see if we were given a server name, since loading from file is deliniated by a dash, we will handle it in this class
			if (String.IsNullOrEmpty(tserver))
			{
				string[] subs = tname.Split('\t');
				name = subs[0];
				server = subs[1];
				if (!Globals.servers.Contains(server))
				{
					Globals.servers.Add(server);
				}
			}

		}
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

		int IComparable.CompareTo(object obj)
        {
			Guild other = (Guild)obj;
			return String.Compare(name, other.name);
		}
		public override string ToString()
        {
			return name + "\t" + type + "\t" + server;
        }
	}
}