using System.ComponentModel.DataAnnotations;

namespace JimBaub_Site.Models
{
    public partial class MerchModel
    {
        public enum MerchType
        {
            [Display(Name = "T-Shirt")]
            Tee,
            [Display(Name = "Long Sleeved T-Shirt")]
            LongTee,
            Jumper,
            Hoodie,
            [Display(Name ="Zip-Up Hoodie")]
            ZipHoodie,
            Mug,
            [Display(Name = "Mouse Pad")]
            Pad,
            [Display(Name = "Phone Case")]
            Case
        }
    }
}