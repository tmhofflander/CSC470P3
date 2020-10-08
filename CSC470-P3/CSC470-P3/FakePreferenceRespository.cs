using System;
using System.Collections.Generic;
using System.Text;

namespace CSC470_P3
{
    class FakePreferenceRespository
    {
        public const string PREFERENCE_PROJECT_ID = "Project_Id";
        public const string PREFERENCE_PROJECT_NAME = "Project_Name";
        public const string NO_ERROR = "";


        private static Dictionary<string, Dictionary<string, string>> preferences = new Dictionary<string, Dictionary<string, string>>;


        public string GetPreference(string UserName, string PreferenceName)
        {
            Dictionary<string, string> NameValuePair = new Dictionary<string, string>();
            string value = "";
            if(preferences.TryGetValue(UserName, out NameValuePair))
            {
                NameValuePair.TryGetValue(PreferenceName, out value);
            }

            return value;

        }

        public string SetPreference(string Username, string PreferenceName, string Value)
        {
            Dictionary<string, Dictionary<string, string>> preferences = new Dictionary<string, Dictionary<string, string>>();

            Dictionary<string, string> tempDictionary = new Dictionary<string, string>();
            tempDictionary.Add(PreferenceName, Value);
            preferences.Add(Username, tempDictionary);

            return NO_ERROR;
        }



    }
}
