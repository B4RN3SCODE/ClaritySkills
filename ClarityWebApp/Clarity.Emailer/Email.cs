using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Clarity.Emailer {
	public class Email {
		[Key]
		[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		public int Id { get; set; }
		public string To { get; set; }

		public string From { get; set; }

		public string Subject { get; set; }

		public string Body { get; set; }

		public DateTime Date { get; set; }

		public string SendingStatus { get; set; }
	}
}
