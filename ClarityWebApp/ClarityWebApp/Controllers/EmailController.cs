using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Clarity.Emailer;
using ClarityWebApp.Library;
using Microsoft.Extensions.Configuration;

namespace ClarityWebApp.Controllers {
	[Route("api/[controller]")]
	[ApiController]
	public class EmailController : ControllerBase {

		// config to read settings and pass to SendMail
		private IConfiguration _config { get; }
		
		// SendMail object to update email object status
		private SendMail _sm { get; set; }

		public EmailController(IConfiguration iconfig) {
			this._config = iconfig;
		}
		
		// test its working
		// GET: api/Email
		[HttpGet]
		public IEnumerable<string> Get() {
			return new string[] { "status", "working" };
		}

		// main API endpoint & method
		// POST api/Email
		[HttpPost]
		public string Post([FromBody] Email e) {
			// e is from the body of the request (make sure JSON stringify is used)
			this.SendMail(e).Wait();

			// update the email data
			e.Date = DateTime.Now;
			e.SendingStatus = this._sm._status == Clarity.Emailer.SendMail.EmailState.sent ? "sent" : "fail";

			this.UpdateDatabase(e);

			return "sent";
		}

		/*
		 * SendMail - use the SM object to async call based on the retry interval
		 */
		private async Task SendMail(Email e) {
			
			this._sm = new SendMail(this._config, e);

			await this._sm.SendAsync();
		}


		/*
		 * Use the EmailContext to add the email and insert into database
		 */
		private void UpdateDatabase(Email e) {
			using(var context = new EmailContext()) {
				context.Emails.Add(e);

				context.SaveChanges();
			}
		}

	}
}
