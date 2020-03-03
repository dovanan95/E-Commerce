using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model.EF;

namespace Model.DAO
{
    public class MenuDAO
    {
        OnlineShopDBContext db = null;
        public MenuDAO()
        {
            db = new OnlineShopDBContext();
        }
        public List<Menu> ListByGroupId(string groupId)
        {
            return db.Menus.Where(x => x.TypeID == groupId && x.Status == true).OrderBy(x => x.DisplayOrder).ToList();
        }
    }
}
