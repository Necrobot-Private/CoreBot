#region using directives

using System;
using System.Net;

#endregion using directives

namespace CoreBot.RocketAPI
{
    public class WebProxy : IWebProxy
    {
        public Uri GetProxy(Uri destination)
        {
            return new Uri("http://localhost:8888");
        }

        public bool IsBypassed(Uri host)
        {
            return false;
        }

        public ICredentials Credentials { get; set; }
    }
}