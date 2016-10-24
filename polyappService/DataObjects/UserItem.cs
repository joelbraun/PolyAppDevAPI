using Microsoft.Azure.Mobile.Server;

namespace polyappService.DataObjects
{
    public class UserItem : EntityData
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Url { get; set; }
        public string ClassStanding { get; set; }
        public bool InterestediOS { get; set; }
        public bool InterestedAndroid { get; set; }
        public bool InterestedWindows { get; set; }
        public string InterestedOther { get; set; }
        public string FavoritePizza { get; set; }
        public string FavoriteSoda { get; set; }

    }
}