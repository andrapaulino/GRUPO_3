using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace capaMODELO.Model
{
    public class mEstatus
    {
        public int _idEstatus {  get; set; }
        public string _descriptionEstatus { get; set; }
        public string _modifyBY { get; set; }
        public string _cancelBY { get; set; }
        public DateTime _fecCreate { get; set; }
        public DateTime _fecModify { get; set; }
        public DateTime _fedCancel { get; set; }

        // contructor vacio
        public mEstatus()
        {


        }


    }
}
