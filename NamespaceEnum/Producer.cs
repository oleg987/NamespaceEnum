using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NamespaceEnum
{
    class Producer
    {
        string fullName;
        DateTime birthDay;
        DateTime deathDay;

        public string FullName { get => fullName; set => fullName = (value != "")? value: "Unnamed"; }
        public DateTime BirthDay { get => birthDay; set => birthDay = (value < DateTime.Today.AddYears(-15))? value: DateTime.Today.AddYears(-15); }
        public DateTime DeathDay { get => deathDay; set => deathDay = ((value > birthDay) && (value < DateTime.Today))? value : DateTime.MaxValue; }

        public Producer(string fullName, DateTime birthDay, DateTime deathDay)
        {
            FullName = fullName;
            BirthDay = birthDay;
            DeathDay = deathDay;
        }

        public Producer()
        {
            
        }

        public Producer(string fullName, DateTime birthDay)
        {
            FullName = fullName;
            BirthDay = birthDay;
        }

        private int GetAge()
        {
            int age;
            if (deathDay == DateTime.MinValue)
            {
                age = DateTime.Today.Subtract(birthDay).Days/365;
            }
            else
            {
                age = deathDay.Subtract(birthDay).Days / 365;
            }
            return age;
        }

        public override string ToString()
        {
            return $"Name: {fullName}\nAge: {GetAge()}";
        }
    }
}
