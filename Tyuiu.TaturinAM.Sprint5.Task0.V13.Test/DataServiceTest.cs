using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using Tyuiu.TaturinAM.Sprint5.Task0.V13.Lib;
namespace Tyuiu.TaturinAM.Sprint5.Task0.V13.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void Test()
        {
            string path = @"C:\Users\Tatur\source\repos\Tyuiu.TaturinAM.Sprint5\Tyuiu.TaturinAM.Sprint5.Task0.V13\bin\Debug\OutOutFileTask0.txt";

            FileInfo fileinfo = new FileInfo(path);

            bool fileExists = fileinfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, true);
        }
    }
}
