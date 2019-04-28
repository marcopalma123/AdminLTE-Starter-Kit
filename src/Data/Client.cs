using System;
using System.Collections.Generic;

namespace Company.WebApplication1.Data
{
    public partial class Client
    {
        public Client()
        {
            
        }

        public int Id { get; set; }
        public string IdentityId { get; set; }
        public string Locale { get; set; }
        public string Location { get; set; }

    }
}
