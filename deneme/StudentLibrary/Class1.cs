using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentLibrary
{
    public class StudentInformation
    {
        private int Id;
        private string Name;
        private string Adress;
        private int Avarage;

        public StudentInformation()
        {
            Id = 0;
        }
        public void SetStudentName(string name)
        {
            this.Name = name; //this bu belirtiyor gösteriyor bu diye. Bu class
        }

        public void SetAdress(string adress)
        {
            this.Adress = adress;
        }

        public void SetNotes(int not1, int not2, int not3)
        {
            this.Avarage = (not1 + not2 + not3) / 3;
        }
        public void PrintInfo()
        {
            
        }
    }
}
