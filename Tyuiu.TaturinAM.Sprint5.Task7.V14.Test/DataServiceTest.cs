using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.TaturinAM.Sprint5.Task7.V14.Lib;
using System.IO;
namespace Tyuiu.TaturinAM.Sprint5.Task7.V14.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidLoadDataAndSave()
        {
            string path = @"C:\Users\Tatur\source\repos\Tyuiu.TaturinAM.Sprint5\Tyuiu.TaturinAM.Sprint5.Task7.V14\bin\Debug\OutPutDataFileTask7V14.txt";
            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            Assert.IsTrue(fileExists);
        }
    }
}
