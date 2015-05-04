using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatRemote
{
    interface RemoteClass
    {
        void SetMsg(string name, string s);
        string GetMsg();
    }
}
