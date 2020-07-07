using JimBaub_Site.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static JimBaub_Site.Models.MerchModel;

namespace JimBaub_Site.Services
{
    public interface IStoreData
    {
        IEnumerable<MerchModel> GetAllItems();
        MerchModel GetItem(int Id);
        IEnumerable<MerchModel> GetItemsByType(MerchType type);
        
    }
}
