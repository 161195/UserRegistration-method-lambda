using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UserRegistration
{
    [TestClass]
    public class UserRegistrationTestMethod
    {
        //First Name valid or not
        [TestMethod]
        public void TestingFirstNameValid()
        {
            //Arrange
            string fname = "Mau";
            string expected = "valid";
            string actual;
            //Act
            actual = RegexValidate.FirstName(fname);
            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestingFirstNameInvalid()
        {
            //Arrange
            string fname = "Mayuri";
            string expected = "invalid";
            string actual;
            //Act
            actual = RegexValidate.FirstName(fname);
            //Assert
            Assert.AreEqual(expected, actual);
        }

        //Last Name valid or not
        [TestMethod]
        public void TestingLastNamevalid()
        {
            //Arrange
            string fname = "Roy";
            string expected = "valid";
            string actual;
            //Act
            actual = RegexValidate.LastName(fname);
            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestingLastNameInvalid()
        {
            //Arrange
            string fname = "Salunkhe";
            string expected = "invalid";
            string actual;
            //Act
            actual = RegexValidate.LastName(fname);
            //Assert
            Assert.AreEqual(expected, actual);
        }

        //phone no valid or not
        [TestMethod]
        public void MobileNumValid()
        {
            //Arrange
            string fname = "91 9881815815";
            string expected = "valid";
            string actual;
            //Act
            actual = RegexValidate.MobileNumValid(fname);
            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void MobileNumInValid()
        {
            //Arrange
            string fname = "198818158151";
            string expected = "invalid";
            string actual;
            //Act
            actual = RegexValidate.MobileNumValid(fname);
            //Assert
            Assert.AreEqual(expected, actual);
        }

        //Fpassword valid or not
        [TestMethod]
        public void Validpassword()
        {
            //Arrange
            string fname = "a@12Anik";
            string expected = "valid";
            string actual;
            //Act
            actual = RegexValidate.PassWord(fname);
            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void InValidpassword()
        {
            //Arrange
            string fname = "ancvbnmmk@";
            string expected = "invalid";
            string actual;
            //Act
            actual = RegexValidate.PassWord(fname);
            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        //valid email 
        [DataTestMethod]     //for testing multiple data

        [DataRow("abc@gmail.com")]
        [DataRow("1.abc@yahoo.com")]
        [DataRow("2.abc-100@yahoo.com")]
        [DataRow("3.abc.100@yahoo.com")]
        [DataRow("2.abc111@abc.com")]
        [DataRow("4.abc-100@abc.net")]
        [DataRow("5.abc.100@abc.com.au")]
        [DataRow("6.abc@1.com")]
        [DataRow("7.abc@gmail.com.com")]
        [DataRow("8.abc+100@gmail.com")]
        public void Testemail_Valid(string name)
        {
            //Arrange
            string expected = "valid";

            //Act
            string actual = RegexValidate.EmailValid(name);

            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        //Invalid email 
        [DataTestMethod]     //for testing multiple data

        [DataRow("abc")]
        [DataRow("abc@.com.my")]
        [DataRow("abc123@gmail.a")]
        [DataRow("abc123@.com")]
        [DataRow("abc123@.com.com")]
        [DataRow(".abc@abc.com")]
        [DataRow("abc()*@gmail.com")]
        [DataRow("abc@%*.com")]
        [DataRow("abc@abc@gmail.com")]
        [DataRow("abc@gmail.com.1a")]
        [DataRow("abc@gmail.com.aa.au")]

        public void Testemail_Invalid(string name)
        {
            //Arrange
            string expected = "invalid";

            //Act
            string actual = RegexValidate.EmailValid(name);

            //Assert
            Assert.AreEqual(expected, actual);
        }

    }    
}


