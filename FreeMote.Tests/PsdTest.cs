using System;
using System.Text;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using FreeMote.Psb;
using FreeMote.PsBuild;
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
            var path = Path.Combine(resPath, "e-mote38_free.psd");
            PsdFile file = new PsdFile(path, new LoadContext());

            Bitmap bmp = new Bitmap("Monarch.png");
            Layer psdLayer = new Layer(file);
            // Set layer metadata
            psdLayer.Name = "Monarch";
            psdLayer.Rect = new Rectangle(new Point(100, 100), bmp.Size);
            psdLayer.BlendModeKey = PsdBlendMode.Normal;
            psdLayer.Opacity = 255;
            psdLayer.Visible = true;
            psdLayer.Masks = new MaskInfo();
            psdLayer.BlendingRangesData = new BlendingRanges(psdLayer);
            psdLayer.SetBitmap(bmp);
            file.Layers.Add(psdLayer);

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

        [TestMethod]
        public void TestPsdBuildKrkr()
        {
            var resPath = Path.Combine(Environment.CurrentDirectory, @"..\..\Res");
            var path = Path.Combine(resPath, "澄怜a_裸-pure.psb");
            Psb2PsdConverter converter = new Psb2PsdConverter(new PSB(path));
            converter.ConvertToPsd(1500, 3800).Save(path + ".psd", Encoding.UTF8);
            Console.WriteLine();
        }

        [TestMethod]
        public void TestPsdBuildWin()
        {
            var resPath = Path.Combine(Environment.CurrentDirectory, @"..\..\Res");
            var path = Path.Combine(resPath, "ca01-pure.psb");
            Psb2PsdConverter converter = new Psb2PsdConverter(new PSB(path));
            converter.ConvertToPsd(1600, 2000).Save(path + ".psd", Encoding.UTF8);
            Console.WriteLine();
        }

        [TestMethod]
        public void TestPsdLoadBuilt()
        {
            var resPath = Path.Combine(Environment.CurrentDirectory, @"..\..\Res");
            var path = Path.Combine(resPath, "澄怜a_裸-pure.psb.psd");
            PsdFile file = new PsdFile(path, new LoadContext());
            var layers = file.Layers;
        }
    }
}
