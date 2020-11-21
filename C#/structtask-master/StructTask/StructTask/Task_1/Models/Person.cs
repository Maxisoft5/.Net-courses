using System;
using System.Collections.Generic;
using System.Text;

namespace StructTask
{
    public struct Person
    {
        private string _firstName;
        private string _surName;
        private int _age;

        /// <summary>
        /// Person's firstname
        /// </summary>
        public string FirstName
        {
            get
            {
                return this._firstName;
            }
            set
            {
                this._firstName = value;
            }
        }

        /// <summary>
        /// Person's lastname
        /// </summary>
        public string SurName
        {
            get
            {
                return this._surName;
            }
            set
            {
                this._surName = value;
            }
        }

        /// <summary>
        /// Person's age
        /// </summary>
        public int Age
        {
            get
            {
                return this._age;
            }
            set
            {
                if (_age > 0 && _age < 120)
                {
                    this._age = value;
                }
                else
                {
                    throw new ArgumentException("Wrong age");
                }
            }
        }

        public Person(string firstName, string surname, int age)
        {
            this._firstName = firstName;
            this._surName = surname;
            this._age = age;
            FirstName = _firstName;
            SurName = _surName;
            Age = _age;
        }

        public string ValidateAge(int age)
        {
            if (age <= 0 || age > 120)
            {
                Console.WriteLine("Enter a valid age");
                ValidateAge(age);
            }
            if (age < _age)
            {
                return $"{_firstName} {_surName} older than {age}. Welcome!";
            }
            else if (age > _age)
            {
                return $"{_firstName} {_surName} younger than {age}. Wait {age - Age} years to pass.";
            }
            else
            {
                return $"{_firstName} {_surName} equals to {age}. Welocme!";
            }
        }
    }
}
