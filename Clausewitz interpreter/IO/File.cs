﻿using Clausewitz.Constructs;
namespace Clausewitz.IO
{
	/// <summary>An extended type of scope, which enforces file name and parent directory.</summary>
	public class File : Scope, IExplorable
	{
		/// <summary>Primary constructor.</summary>
		/// <param name="parent">Parent directory.</param>
		/// <param name="name">File name with extension.</param>
		internal File(Directory parent, string name) : base(name)
		{
			Name = name;
			Parent = parent;
		}

		/// <inheritdoc />
		public string Address
		{
			get
			{
				return this.GetAddress();
			}
		}

		/// <inheritdoc />
		public new Directory Parent
		{
			get;
		}
	}
}