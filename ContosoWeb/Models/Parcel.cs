namespace ContosoWeb.Models
{
    public class Parcel
    {
        public int Id { get; set; }

        public string TrackingNumber { get; set; } = "";

        public string Recipient { get; set; } = "";

        public string Status { get; set; } = "";

        public bool IsDelivered { get; set; }
    }
}