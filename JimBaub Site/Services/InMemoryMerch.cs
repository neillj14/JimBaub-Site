using JimBaub_Site.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using static JimBaub_Site.Models.MerchModel;

namespace JimBaub_Site.Services
{
    public class InMemoryMerch : IStoreData
    {
        List<MerchModel> items;
        public InMemoryMerch()
        {
            items = new List<MerchModel>()
            {
                new MerchModel{ ItemID=1, DesignKey="PFC[SSDW2K5FhbMUnTSGnvqiaXLQE3NJfb]", SKU = "6160|Charcoal|",
                    MockupURL="https://www.streetshirts.co.uk/creation/services/imageprocessing/getcreationpreviewimage.aspx?filename=PFC[SSDW2K5FhbMUnTSGnvqiaXLQE3NJfb]&size=500",
                    Name="JimBaub's Wood Pullin Jumper", Type=MerchType.Jumper}
            };
        }
        public IEnumerable<MerchModel> GetAllItems()
        {
            return items;
        }

        public MerchModel GetItem(int Id)
        {
            return items.FirstOrDefault(i => i.ItemID == Id);
        }

        public IEnumerable<MerchModel> GetItemsByType(MerchType type)
        {
            return items.Where(i => i.Type == type);
        }
    }
}