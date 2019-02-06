using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace deneme
{
    class Program
    {
        static void Main(string[] args)
        {
            Student ogrenci = new Student(); //obje yaratır,Object
            Object obj = new Student();//neden? çünkü c# da en temel sınıf Object dir.Tüm tipler ondan türer.
            ogrenci.Name = "Ercan";
            ogrenci.Note = 1;
            ogrenci.Adress = "Çatalca";

            Console.WriteLine("Student Name="+ogrenci.Name);
            Console.WriteLine("Student Note="+ogrenci.Note);
            Console.WriteLine("Student Adress"+ogrenci.Adress);

            //Student tembelOgrenci = new Student();
            //tembelOgrenci = ogrenci;

            //Console.WriteLine("--------------");
            //Console.WriteLine(tembelOgrenci.Name);

            //tembelOgrenci.Name = "Tembel";
            //Console.WriteLine("--------------");
            //Console.WriteLine(ogrenci.Name);

            Console.WriteLine("-----Print Values----");
            ogrenci.Print();

        }
    }
    class Student
    {
        //ad
        //not
        //adres
        //Fields deniliyor.
    
        public string Name;
        public int Note;

        //Properties,Kapsülleme
        public string _adress;
        public string Adress
        {
            get
            {
                return _adress;
            }
            set
            {
                _adress = value;
            }
        }
        
        //methods
        public void DateHomeWork()
        {

        }
        public void Print()
        {
            Console.WriteLine(Name);
            Console.WriteLine(Note);
            Console.WriteLine(Adress);
        }
    }
    //struct Student //gerek yok buna
    //{
    //    //ad
    //    //not
    //    //adres
    //    //okula gider
    //    //kız arkadaş / erkek arkadaş
    //    //yemek
    //    //langırt oynar
    //    //ders çalışır
    //    //bilgisayar oyunu oynar.
    //    // ne zaman login olmuş
    //    // kimleri takip ediyor
    //    //neleri sever.
    //}
}
