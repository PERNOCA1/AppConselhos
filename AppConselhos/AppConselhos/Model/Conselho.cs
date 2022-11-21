using System;
using System.Collections.Generic;
using System.Text;

namespace AppConselhos.Model
{
    public class Conselho
    {
        public string Id { get; set; }
        public string DicaDoDia { get; set; }


        public Conselho()
        {
            this.Id = "";
            this.DicaDoDia = "";
        }
    }
}
