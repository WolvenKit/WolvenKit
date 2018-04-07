using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WolvenKit.Bundles
{
    class __Metadata_Store_Test
    {
        [STAThread]
        static int Main(string[] args)
        {
            using (var of = new OpenFileDialog()
            {
                Filter = "Metadata files | metadata.store"
            })
            {
                if (of.ShowDialog() == DialogResult.OK)
                {
                    new Metadata_Store(of.FileName);
                }
            }
            return 0;
        }
    }
}
