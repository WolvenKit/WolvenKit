using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace WolvenKit.CR2W.Types
{
    class CFurMeshResource : CVector
    {
        public CFurMeshResource(CR2WFile cr2w) : base(cr2w)
        {
        }

        public override Control GetEditor()
        {
            var btn = new Button();
            btn.Text = "Export";
            btn.Click += (sender, args) =>
            {
                using (var sf = new SaveFileDialog())
                {
                    sf.Filter = "XML File | *.xml";
                    if (sf.ShowDialog() == DialogResult.OK)
                    {
                        Apex.HairWorks.ConvertToApexXml(this.cr2w).Save(sf.FileName);
                    }
                }
            };
            return btn;
        }
    }
}
