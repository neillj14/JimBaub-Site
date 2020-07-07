namespace JimBaub_Site.Models
{
    public partial class MerchModel
    {
        public int ItemID { get; set; }
        public string Name { get; set; }
        public MerchType Type { get; set; }
        public string SKU { get; set; }
        public string DesignKey { get; set; }
        public string MockupURL { get; set; }
    }
}