using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model.EF;

namespace Model.DAO
{
    public class OrderDetailDAO
    {
        OnlineShopDBContext db = null;
        public OrderDetailDAO()
        {
            db = new OnlineShopDBContext();
        }
        public bool Insert(OrderDetail orderDetail)
        {
            try
            {

                db.OrderDetails.Add(orderDetail);
                db.SaveChanges();
                return true;
            }
            catch(Exception ex)
            {
                return false;
            }
        }
    }
}
