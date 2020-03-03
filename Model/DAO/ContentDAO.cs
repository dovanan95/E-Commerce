using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model.EF;

namespace Model.DAO
{
    public class ContentDAO
    {

        OnlineShopDBContext db = null;
        public ContentDAO()
        {
            db = new OnlineShopDBContext();
        }
        public Content GetById(long ID)
        {
           return db.Contents.Find(ID);
        }
    }
}
