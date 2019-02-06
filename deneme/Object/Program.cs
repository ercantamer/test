using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Object
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "ogrenciIsmi";
            Ogrenci ogr = new Ogrenci(name);
            // string ogr = new Ogrenci("İsim");
            //Ogrenci ogr3 = new Ogrenci(name);
            ogr.OrtalamaHesapla(20,60);
            ogr.OrtalamaHesapla(20, 60,40);

            Ogrenci ogr3 = new Ogrenci(); //overloadı 3 olucak
            Ogrenci ogr4 = new Ogrenci("tamer", 23);
        }
    }
    //Yapıcı bir methoddur
    class Ogrenci
    {
        //public Ogrenci()

        //{
        //Console.WriteLine("nesne yaratıldı");
        // }
        public Ogrenci(string name)
        {
            Console.WriteLine("Öğrenci ismi=" + name);
        }
        public Ogrenci()
            {

            }
        public Ogrenci(string name,int not)
        {

        }

        public void OrtalamaHesapla(int not1,int not2)
        {
            int ortalama = (not1 + not2) / 2;   //islem önceli * / + -
            Console.WriteLine("Not Ortalaması="+ortalama);
        }
        //Method OverLoading
        public void OrtalamaHesapla(int not1,int not2,int not3)
        {
            int ortalama = (not1 + not2 + not3) / 3;
            Console.WriteLine("Sene Sonu Ortalaması="+ortalama);
        }
    }
}


