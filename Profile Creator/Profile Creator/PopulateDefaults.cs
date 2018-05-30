using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Profile_Creator
{
    internal class PopulateDefaults
    {
        private Dictionary<string,string> Location { get; set; }
        private List<string> ProfileType { get; set; }

        public PopulateDefaults()
        {
            Dictionary<string,string> _location = new Dictionary<string,string>();
            List<string> _profileType = new List<string>();
            _location.Add("UK-Swansea", @"\\SVAASWSCCNAS01\Home$\");
            _location.Add("UK-The Hangar-GND Floor", @"\\SVAALHRHGRNAS01\Home$\");
            _location.Add("UK-The Base", @"\\svaakntnas596\home1$\");
            _location.Add("UK-The VHQ",@"\\svaakntnas596\home1$\");
            _location.Add("UK-The Office", @"\\svaakntnas596\home1$\");
            _location.Add("UK-LHR LGW maintenance", @"\\SVAALHRATONAS01\Home$\");

            _profileType.Add("Roaming Profile");
            _profileType.Add("Local Profile");

            Location = _location;
            ProfileType = _profileType;
            
        }

        public Dictionary<string,string> GetLocation()
        {
            return Location;
        }

        public List<string> GetProfileType()
        {
            return ProfileType;
        }
    }
}
