using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using System.IO;

using Tyuiu.KozhevnikovDG.Sprint5.Task1.V20.Lib;

namespace Tyuiu.KozhevnikovDG.Sprint5.Task1.V20.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string path = @"C:\Users\f1zog\source\repos\Tyuiu.KozhevnikovDG.Sprint5\Tyuiu.KozhevnikovDG.Sprint5.Task1.V20\bin\Debug\OutPutFileTask1.txt";

            FileInfo fileInfo = new FileInfo(path);
            bool fileExist = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExist);
        }
    }
}
