using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Profile_Creator
{
    internal class MembershipInfo
    {
        public string GrpName { get; private set; }
        Dictionary<string, string> member = new Dictionary<string, string>();
        public MembershipInfo()
        {           
            member.Add(@"\\SVAASWSCCNAS01\Home$\","GS_IT_SVAASWSCCNAS01");
            member.Add(@"\\svaakntnas596\home1$\", "GS_IT_SVAAKNTNAS596_Home1");
            member.Add(@"\\SVAALHRATONAS01\Home$\", "GS_IT_SVAALHRATONAS01");
            
        }

        public string GetGroupName(string _path)
        {
            return member[_path];
        }

    }
}

