using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CshHW3
{
    internal class WebSite
    {
        private string _name;
        private string _url;
        private string _ip;
        private string _discription;

        public WebSite(string name, string url, string ip, string discription = "")
        {
            _name = name;
            _url = url;
            _ip = ip;
            _discription = discription;
        }

        public void SetDiscription(string discription)
        {
            _discription = discription;
        }

        public void ChangeIp(string ip)
        {
            _ip = ip;
        }

        public void ChangeUrl(string url)
        {
            _url = url;
        }
        public void ChangeName(string name)
        {
            _name = name;
        }

        public void ShowSiteInfo()
        {
            Console.WriteLine($"This is information about site {_name}");
            Console.WriteLine($"The url of the site is {_url}, site IP is {_ip}.\nDiscription: {_discription}");
        }



    }
}
