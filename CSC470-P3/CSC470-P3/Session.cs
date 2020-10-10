using System;
using System.Collections.Generic;
using System.Text;

namespace CSC470_P3
{
    public static class Session
    {
        public static AppUser appUser { get; set; } = new AppUser();
        public static Project project { get; set; } = new Project();
    }
}
