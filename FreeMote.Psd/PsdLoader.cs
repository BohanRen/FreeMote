using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PhotoshopFile;

namespace FreeMote.Psd
{
    public class PsdLoader
    {
        public static void Test()
        {
            PsdFile file = new PsdFile(@"..\..\..\FreeMote.Tests\Res\e-mote38基本テンプレート(正面zバイナリ専用)_free.psd", new LoadContext());
            foreach (var fileLayer in file.Layers)
            {
                var fn = fileLayer.Name;
                var info = fileLayer.AdditionalInfo[1];
            }
        }
    }
}
