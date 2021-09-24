using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using Folluk.Models.Utility;

namespace Folluk.Models.Users
{
    public class ILogin : IDb
    {

        public IWarning OWarning;

        public UserCredential Model { get; set; }

        public UserCredential Credential { get; set; }

        public User User { get; set; }

        public bool Status { get; set; }

        public ILogin()
        {
            OWarning = new IWarning();
        }

        public void Do()
        {
            if (Model.Email.Trim() != "" && Model.Password.Trim() != "")
            {
                this.Credential = db.UserCredentials.Where(x => x.Email == Model.Email && x.Password == Model.Password).FirstOrDefault();
                if (this.Credential != null)
                {
                    this.User = db.Users.Where(x => x.UserId == this.Credential.UserId).FirstOrDefault();
                    Status = true;
                }
                else
                {
                    OWarning.Set(true, "", "User Not Found.", "danger");
                    Status = false;
                }
            }
        }

    }
}