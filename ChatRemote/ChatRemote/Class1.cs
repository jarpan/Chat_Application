using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatRemote
{
    public class RemoteClass:MarshalByRefObject
    {
        static string msg;
        public void SetMsg(string name, string s)
        {
            msg += name + "::" + s + Environment.NewLine;
        }
        public string GetMsg()
        {
            return msg;
        }
    }
}
