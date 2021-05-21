using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Configuration.Binder;
using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;


namespace Clarity.Emailer {
    
    /*
     * SendMail
     * Handles sending mail async
     */
    public class SendMail {

        /*
         * _config
         * Configuration interface to get appsettings.json data for SMTP
         */
        private IConfiguration _config { get; set; }
        /*
         * _email
         * Email data model
         */
        public Email _email { get; set; }
        /*
         * _status
         * Helps track the status of the email
         */
        public EmailState _status { get; set; }
        /*
         * set this to number of seconds to increase time interval (default 1 sec)
         */
        public TimeSpan _resendTimeInterval { get; set; }

        /*
         * track number of attempts
         */
        public int _numTries { get; set; }

        /*
         * maximum retries
         */
        public const int MAX_RESENDS = 3;

        /*
         * EmailState statuses
         */
        public enum EmailState {
            none,
            initiated,
            sent,
            failed
		}

		#region c'tor


		public SendMail(IConfiguration iconfig, Email email) {
            this._config = iconfig;
            this._email = email;
            this._resendTimeInterval = TimeSpan.FromSeconds(1);
            this._status = EmailState.none;
            this._numTries = 0;
		}


        public SendMail(IConfiguration iconfig, Email email, int resendTimeInterval) {
            this._config = iconfig;
            this._email = email;
            this._resendTimeInterval = TimeSpan.FromSeconds(resendTimeInterval);
            this._status = EmailState.none;
            this._numTries = 0;
        }
        #endregion


        /*
         * SendAsync
         * This allows an async call to send an email based on the
         * max number of tries allowed.  It uses the resend interval
         * to delay retries.  I did this like this because in the constraints
         * it says to be able to send in succession or over a period of time
         */
        public async Task SendAsync() {
            
            while(true) {
                // send the email, return on success
                try {
                    await this.Send();
                    return;
                // try failed, try again or throw error
				} catch {
                    if(++this._numTries >= MAX_RESENDS) {
                        this._status = EmailState.failed;
                        throw;
					}
                    // delay between tries
                    await Task.Delay(this._resendTimeInterval);
				}
			}
		}

        /*
         * Send
         * main method to send the email
         */
        public async Task Send() {

            this._status = EmailState.initiated;

            // use system net mail
            var mailMsg = new MailMessage();
            mailMsg.To.Add(this._email.To);

            mailMsg.Subject = this._email.Subject;
            mailMsg.Body = this._email.Body;
            mailMsg.From = new MailAddress(this._email.From);


            using (var smtpClient = new SmtpClient()) {
                smtpClient.Port = Convert.ToInt32(this._config.GetValue<string>("Smtp:Port"));
                smtpClient.EnableSsl = Convert.ToBoolean(this._config.GetValue<string>("Smtp:EnableSsl"));
                smtpClient.DeliveryMethod = SmtpDeliveryMethod.Network;
                smtpClient.UseDefaultCredentials = false;
                smtpClient.Credentials = new NetworkCredential(this._config.GetValue<string>("Smtp:Username"), this._config.GetValue<string>("Smtp:Password"));
                smtpClient.Host = this._config.GetValue<string>("Smtp:Host");
                try {
                    // send async
                    await smtpClient.SendMailAsync(mailMsg);
                    this._status = EmailState.sent;
                } catch(Exception e) {
                    this._status = EmailState.failed;
				}
            }
        }


    }
}
