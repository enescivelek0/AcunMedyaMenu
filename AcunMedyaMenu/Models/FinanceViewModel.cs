namespace AcunMedyaMenu.Models
{
    public class FinanceViewModel
    {
        public Data data { get; set; }
        public class Data
        {
            public string _base { get; set; }
            public float USD { get; set; }
            public int EUR { get; set; }
            public float JPY { get; set; }
            public float TRY { get; set; }
        }
    }
}
