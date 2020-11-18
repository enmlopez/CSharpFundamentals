using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace _07_ClassesToErase
{
    [TestClass]
    public class ClassesTests1
    {
        [TestMethod]
        public void CookieTests()
        {
            Cookie cookie = new Cookie();
            cookie.Name = "Snickerdoodle";

            Cookie anotherCookie = new Cookie();
            cookie.Name = "Snickers";

            Cookie newCookie = new Cookie();
            cookie.GramAmount = 15;
        }
    }
}
