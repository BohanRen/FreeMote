using System;
using System.Text;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using FreeMote.Psd;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PhotoshopFile;

namespace FreeMote.Tests
{
    [TestClass]
    public class PsdTest
    {
        public PsdTest()
        {
        }

        private TestContext testContextInstance;


        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }
        
        [TestMethod]
        public void TestPsdLoad()
        {
            var resPath = Path.Combine(Environment.CurrentDirectory, @"..\..\Res");
            var path = Path.Combine(resPath, "e-mote38基本テンプレート(正面zバイナリ専用)_free.psd");
            PsdFile file = new PsdFile(path, new LoadContext());

            foreach (var fileLayer in file.Layers)
            {
                var fn = fileLayer.Name;
                if (fn == "胸")
                {
                    fileLayer.SetBitmap(new Bitmap("body_parts-胸00.png"));
                    break;
                }
                //Console.WriteLine($"{fn} : {fileLayer.AdditionalInfo}");
                //var info = fileLayer.AdditionalInfo[1];
            }
            file.Save("modified.psd", Encoding.UTF8);

            file = new PsdFile(@"modified.psd", new LoadContext());
            foreach (var fileLayer in file.Layers)
            {
                var fn = fileLayer.Name;
                if (fn == "胸")
                {
                    fileLayer.GetBitmap()?.Save($"{fn}.png", ImageFormat.Png);
                    break;
                }
            }
        }
    }
}
