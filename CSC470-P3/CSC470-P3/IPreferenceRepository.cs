using System;
using System.Collections.Generic;
using System.Text;

namespace CSC470_P3
{
    interface IPreferenceRepository
    {
        string GetPreference(string UserName, string PreferenceName);
        string SetPreference(string Username, string PreferenceName, string Value);
    }
}
