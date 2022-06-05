using Microsoft.VisualStudio.TestTools.UnitTesting;
using HotelSystem.ViewModel;
using HotelSystem.Model;
using HotelSystem.HotelDbContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelSystem.ViewModel.Tests
{
    [TestClass()]
    public class MainWindowViewModelTests
    {
        [TestMethod()]
        public void MainWindowViewModelTest()
        {
            Client client = new Client();         
            client.Passport = "1111-111111";
            int expectedsize = 11;                            

            Assert.AreEqual(expectedsize, client.Passport.Length);
        }
    }
}