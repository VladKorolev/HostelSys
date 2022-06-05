using Microsoft.VisualStudio.TestTools.UnitTesting;
using HotelSystem.ViewModel;
using HotelSystem.Model;
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
            Room room = new Room();
            room.Number = "5";
            
            
            int expected = 0;
            expected.GetType();

            Assert.AreEqual(expected.GetType(), Convert.ToInt32(room.Number).GetType());
        }
    }
}