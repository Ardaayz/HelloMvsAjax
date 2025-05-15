namespace HelloMvs.Models.ViewModels
{

    public class OgrenciDetayDTO
    {
        public int OgrenciId { get; set; }
        public string Ad { get; set; } = string.Empty;
        public string Soyad { get; set; } = string.Empty;

        public int OgretmenID { get; set; }
        public string OgretmenAd { get; set; } = string.Empty;
        public string OgretmenSoyad { get; set; } = string.Empty;
    }
}