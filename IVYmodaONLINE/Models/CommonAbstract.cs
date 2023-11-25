using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IVYmodaONLINE.Models
{
    public abstract class CommonAbstract
    {
        public string createdBy { get; set; }
        public DateTime createDate { get; set; }
        public string ModifiedrBy { get; set; }
        public DateTime Modifiedrdate { get; set; }

    }
}