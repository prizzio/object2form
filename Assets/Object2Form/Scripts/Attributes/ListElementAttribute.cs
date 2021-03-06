﻿using System;

namespace O2F
{
	[AttributeUsage(AttributeTargets.Field | AttributeTargets.Property)]
	public class ListElementAttribute : Attribute
	{
		public bool removable;

		public ListElementAttribute(bool removable = true)
		{
			this.removable = removable;
		}
	}
}