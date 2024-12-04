using System;

namespace DBProject.Admin
{
    public static class UserSession
    {
       
        public static int UserId { get; set; }
        public static string Email { get; set; }

        
        public static string FirstName { get; set; }
        public static string LastName { get; set; }

        
        public static void ClearSession()
        {
            UserId = 0;
            Email = string.Empty;
            FirstName = string.Empty;
            LastName = string.Empty;
        }

        
        public static bool IsLoggedIn()
        {
            return UserId !=0;
        }
    }
}
