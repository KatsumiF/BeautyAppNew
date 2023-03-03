using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using CheckStringLib;

namespace CheckStringLibTests
{
    [TestClass]
    public class CheckStringClassTests
    {
        //пустая строка
        [TestMethod]
        public void CheckEmail_EmptySting_ReturnException()
        {
            //Arrange - исходные данные для тестирования
            string email = ""; //String.Empty тоже значит пустую строку
            //Act
            //ИмяКласса obj = new ИмяКласса();
            bool actual = CheckStringClass.CheckEmail(email);
            //Assert
            Assert.IsFalse(actual);
        }
        //пустая строка
        [TestMethod]
        public void CheckEmail_NullString_ReturnException()
        {
            //Arrange - исходные данные для тестирования
            string email = " "; //String.Empty тоже значит пустую строку
            //Act
            //ИмяКласса obj = new ИмяКласса();
            bool actual = CheckStringClass.CheckEmail(email);
            //Assert
            Assert.IsFalse(actual);
        }
        [TestMethod]
        public void CheckEmail_ZnakString_ReturnException()
        {
            //Arrange - исходные данные для тестирования
            string email = " "; //String.Empty тоже значит пустую строку
            //Act
            //ИмяКласса obj = new ИмяКласса();
            bool actual = CheckStringClass.CheckEmail(email);
            //Assert
            Assert.IsFalse(actual);
        }

        [TestMethod]
        public void CheckOtch_NullString_ReturnException()
        {
            //Arrange - исходные данные для тестирования
            string Otch = String.Empty;
            //Act
            //ИмяКласса obj = new ИмяКласса();
            bool actual = CheckStringClass.CheckEmail(Otch);
            //Assert
            Assert.IsFalse(actual);
        }
        [TestMethod]
        public void CheckOtch_ZnakString_ReturnException()
        {
            //Arrange - исходные данные для тестирования
            string Otch = ","; 
            //Act
            //ИмяКласса obj = new ИмяКласса();
            bool actual = CheckStringClass.CheckEmail(Otch);
            //Assert
            Assert.IsFalse(actual);
        }
        [TestMethod]
        public void CheckOtch_CifrString_ReturnException()
        {
            //Arrange - исходные данные для тестирования
            string Otch = "@^[0-9]";
            //Act
            //ИмяКласса obj = new ИмяКласса();
            bool actual = CheckStringClass.CheckEmail(Otch);
            //Assert
            Assert.IsFalse(actual);
        }

        [TestMethod]
        public void CheckOtch_OthTrueString_ReturnException()
        {
            //Arrange - исходные данные для тестирования
            string Otch = "Сергеевна";
            //Act
            //ИмяКласса obj = new ИмяКласса();
            bool actual = CheckStringClass.CheckEmail(Otch);
            //Assert
            Assert.IsTrue(actual);
        }
    }
}

