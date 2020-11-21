using System;
using NUnit.Framework;

namespace StructTask.Tests
{
    public class Tests
    {
        private Person _man;
        private Person _child;

        [SetUp]
        public void Setup()
        {
            _man = new Person("Adult", "AdultSurname", 25);
            _child = new Person("Child", "ChildSurname", 5);
        }

        [TestCase(20)]
        public void ValidateAgeTest1(int age)
        {
            var expectedMan = $"{_man.FirstName} {_man.SurName} older than {age}. Welcome!";
            var expectedChild = $"{_child.FirstName} {_child.SurName} younger than {age}. Wait {age - _child.Age} years to pass.";
            var actualMan = _man.ValidateAge(age);
            var actualChild = _child.ValidateAge(age);
            Assert.AreEqual(expectedMan, actualMan);
            Assert.AreEqual(expectedChild, actualChild);
        }

        [TestCase(5)]
        public void ValidateAgeTest2(int age)
        {
            var expectedMan = $"{_man.FirstName} {_man.SurName} older than {age}. Welcome!";
            var expectedChild = $"{_child.FirstName} {_child.SurName} equals to {age}. Welocme!";
            var actualMan = _man.ValidateAge(age);
            var actualChild = _child.ValidateAge(age);
            Assert.AreEqual(expectedMan, actualMan);
            Assert.AreEqual(expectedChild, actualChild);
        }

        [TestCase(0)]
        [TestCase(-2)]
        [TestCase(125)]
        public void CorrectAgeTest1(int age)
        {
            var actException = Assert.Catch(() => new Person("Name", "Surname", age));
            var expectedException = new ArgumentException();
            Assert.AreEqual(expectedException.GetType(), actException.GetType());
        }

    }
}