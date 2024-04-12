﻿using System;

namespace BlazorServerAppDemo2.Components.Models
{
	[Serializable]
	public class Contact
	{
		public string FirstName { get; set; }	
		public string LastName { get; set; }	
		public string Email { get; set; }
	}
}
