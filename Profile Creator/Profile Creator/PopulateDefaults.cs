using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Profile_Creator
{
    internal class PopulateDefaults
    {
        private List<string> Location { get; set; }
        private List<string> ProfileType { get; set; }

        public PopulateDefaults()
        {
            List<string> _location = new List<string>();
            List<string> _profileType = new List<string>();
            _location.Add("Swansea");
            _location.Add("The Hangar - GND Floor");
            _location.Add("The Base");
            _location.Add("The VHQ");
            _location.Add("The Office");
            _location.Add("LHR LGW maintenance");

            _profileType.Add("Roaming Profile");
            _profileType.Add("Local Profile");

            Location = _location;
            ProfileType = _profileType;
            
        }

        public List<string> GetLocation()
        {
            return Location;
        }

        public List<string> GetProfileType()
        {
            return ProfileType;
        }
    }
}
