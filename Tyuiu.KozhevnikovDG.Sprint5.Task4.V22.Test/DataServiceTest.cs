using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using System.IO;

using Tyuiu.KozhevnikovDG.Sprint5.Task4.V22.Lib;


namespace Tyuiu.KozhevnikovDG.Sprint5.Task4.V22.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string path = @"C:\DataSprint5\InPutDataFileTask4V22.txt";

            FileInfo fileInfo = new FileInfo(path);

            bool fileExist = fileInfo.Exists;

            bool wait = true;

            Assert.AreEqual(wait, fileExist);

        }
    }
}
