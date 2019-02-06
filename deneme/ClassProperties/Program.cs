using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassProperties
{
    class Program
    {
        static void Main(string[] args)
        {
            Ogrenci ogr = new Ogrenci();
            ogr.Note = 12;
        }
    }
    class Ogrenci
    {
        //public int MyProperty { get; set; } // POCO object,Model,DTA(data transfer objeler)
        private int note; //field,kapsülleme.(encapsulation) ,Kısıtlayıcı.
        public int Note//property
        {
            get
            {
                return note;
            }
            set
            {
                if (value != 0)
                    note = value;
                else
                    note = -1;
            }
        }

    }
}
