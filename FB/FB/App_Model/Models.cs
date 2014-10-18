﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FB.App_Model
{
    public class FaceBook
    {
        public FaceBook()
        {
        }
        public long ID { get; set; }
        public string Login { get; set; }
        public string Pass { get; set; }
        public string FBID { get; set; }
        public string MBLoginText { get; set; }
        public byte[] MBCookie { get; set; }
        public byte[] WebCookie { get; set; }

        public long FBPackageID { get; set; }
        public virtual FBPackage FBPackage { get; set; }
    }

    public class FBPackage
    {
        public FBPackage()
        {
            FaceBooks = new List<FaceBook>();
        }
        public long ID { get; set; }
        public long Pack { get; set; }

        public virtual ICollection<FaceBook> FaceBooks { get; set; }
    }

    public class Package
    {
        public Package()
        {
            Pokers = new List<Poker>();
        }
        public long ID { get; set; }
        public long Pack { get; set; }

        public virtual ICollection<Poker> Pokers { get; set; }
    }
    public class Poker
    {
        public long ID { get; set; }

        public long FaceBookID { get; set; }
        public virtual FaceBook FaceBook { get; set; }

        public string PKID { get; set; }

        public long PackageID { get; set; }
        public virtual Package Package { get; set; }

        public string MBAccessToken { get; set; }
        public string WebAccessToken { get; set; }

        public string MBLoginText { get; set; }
        public string WebLoginText { get; set; }

        public byte[] WebCookie { get; set; }
        public string X_TUNNEL_VERIFY { get; set; }
    }

    public class Tiki
    {
        public long ID { get; set; }
        public string Login { get; set; }
        public string Pass { get; set; }
        public byte[] Cookie { get; set; }
    }
}
