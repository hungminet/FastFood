using FastFoodDemo.DB_Layer;
using FastFoodDemo.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FastFoodDemo.BL_Layer
{
    class BLCa
    {
        DBMain main;
        DataSet ds = new DataSet();

        public BLCa()
        {
            main = new DBMain();
        }
        public DataSet LoadShift()
        {
            string str = string.Format("SELECT * FROM CA");
            ds.Tables.Add(main.LoadData(str));
            return ds;
        }

    }
}
