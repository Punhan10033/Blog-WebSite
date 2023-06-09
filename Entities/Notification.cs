﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
	public class Notification
	{
		[Key]
		public int NotificationId { get; set; }
		public string NotificationType { get; set; }
		public string NotificationTypeSymbol { get; set; }
		public string NotificationDetails { get; set; }
		public DateTime NotificationDate { get; set; }
		public bool NotificationStatus { get; set; }
		public int? UserSenderId { get; set; }
		public User UserSender { get; set; }
		public int UserReceieverId { get; set; }
		public virtual User  UserReceiever {get;set;}
	}
}
