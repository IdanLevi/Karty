namespace Karty.Models
{
    public class User
    {
        public string UserName { get; set; }
        public string FullName { get; set; }
        public string ProfileImageUrl { get; set; }

        public string Email { get; set; }
    }


    public class UserInfo
    {
        public string access_token { get; set; }
        public string access_token_secret { get; set; }
        public string provider_name { get; set; }
        public User_Claims[] user_claims { get; set; }
        public string user_id { get; set; }
    }

    public class User_Claims
    {
        public string typ { get; set; }
        public string val { get; set; }
    }
}
