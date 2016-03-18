using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Customer_Zero.Test
{
    [TestFixture]
    public class Class1
    {
        [TestCase]
        public void VerifyDomasticImages()
        {
            //check this part. rrrrrr
            bool isFileExist = true;
            if (File.Exists("D:\\Siva\\Tours\\DelhiTour.png"))
                isFileExist = false;

            if (File.Exists("D:\\Siva\\Tours\\Kashmir.png"))
                isFileExist = false;

            if (File.Exists("D:\\Siva\\Tours\\Rshikesh.png"))
                isFileExist = false;

            if (File.Exists("D:\\Siva\\Tours\\Simla.png"))
                isFileExist = false;

            if (File.Exists("D:\\Siva\\Tours\\Agra-Mathura.png"))
                isFileExist = false;

            if (File.Exists("D:\\Siva\\Tours\\Amarnath.png"))
                isFileExist = false;

            Assert.AreEqual(false, isFileExist);
        }

        [TestCase]
        public void VerifyInternationalImages()
        {
            bool isFileExist = true;
            if (File.Exists("D:\\Siva\\Tours\\Africa.png"))
                isFileExist = false;

            if (File.Exists("D:\\Siva\\Tours\\America.png"))
                isFileExist = false;

            if (File.Exists("D:\\Siva\\Tours\\Australia.png"))
                isFileExist = false;

            if (File.Exists("D:\\Siva\\Tours\\China.png"))
                isFileExist = false;

            if (File.Exists("D:\\Siva\\Tours\\Greese.png"))
                isFileExist = false;

            if (File.Exists("D:\\Siva\\Tours\\Swiss.png"))
                isFileExist = false;

            Assert.AreEqual(false, isFileExist);
        }
        // Will it commit ??????
        [TestCase]
        public void DummyTestCase()
        {
            bool isFileExist = true;
            if ("y" == "x")
                isFileExist = false;

            Assert.AreEqual(true, isFileExist);
        }
        //comments
    }
}
