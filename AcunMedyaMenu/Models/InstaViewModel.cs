namespace AcunMedyaMenu.Models
{
    public class InstaViewModel
    {
        public Data data { get; set; }
        public class Data
        {
            public string Username { get; set; }          // Kullanıcı adı
            public string FullName { get; set; }          // Tam isim
            public string Biography { get; set; }         // Biyografi
            public int FollowerCount { get; set; }        // Takipçi sayısı
            public int FollowingCount { get; set; }       // Takip edilen sayısı
            public int MediaCount { get; set; }           // Paylaşım sayısı
            public string ProfilePicUrl { get; set; }     // Profil resmi URL'si
            public string ProfilePicUrlHd { get; set; }   // HD profil resmi URL'si
        }
    }

}
