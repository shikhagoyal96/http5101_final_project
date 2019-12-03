using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HTTP_5101_FinalProject_N01329988
{
    public class http_page
    {
        
        private string Stitle;
        private string Sbody;

        //creating get methods
        public string GetStitle()
        {
            return Stitle;
        }
        public string GetSbody()
        {
            return Sbody;
        }

       
       // creating set methods
        public void SetStitle(string value)
        {
            Stitle = value;
        }
        public void SetSbody(string value)
        {
            Sbody = value;
        }
    }
}