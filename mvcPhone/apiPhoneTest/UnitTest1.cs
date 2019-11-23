using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace apiPhoneTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestControllerExistePhoneExists()
        {
            //Organizar

            var controller = new apiPhone.Controllers.PhonesController();

            //Actuar

            var reponse = controller.PhoneExists(1);

            //Afirmar

            Assert.AreEqual(false, reponse);
        }
    }
}
