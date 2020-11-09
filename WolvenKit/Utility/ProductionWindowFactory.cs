using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WolvenKit.Common.Services;

namespace WolvenKit.Utility
{
    public class ProductionWindowFactory : IWindowFactory
    {
        public string ShowAddChunkFormModal(IEnumerable<string> availableTypes, ref string output)
        {
            using (var form = new frmAddChunk(availableTypes.ToList()))
            {
                var result = form.ShowDialog();
                output = result == DialogResult.OK 
                    ? form.ChunkType 
                    : "";
                return output;
            }
        }
    }
}
