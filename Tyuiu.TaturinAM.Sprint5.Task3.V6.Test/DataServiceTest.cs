using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.TaturinAM.Sprint5.Task3.V6.Lib;
using System.IO;
namespace Tyuiu.TaturinAM.Sprint5.Task3.V6.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string path = @"C:\Users\Tatur\source\repos\Tyuiu.TaturinAM.Sprint5\Tyuiu.TaturinAM.Sprint5.Task3.V6\bin\Debug\OutPutFileTask3.bin";
            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}
