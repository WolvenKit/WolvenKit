using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WolvenKit.CR2W;
using WolvenKit.CR2W.Types;
using WolvenKit.Utility;

namespace WolvenKit.Extensions
{
    public static class ComboBoxExtensions
    {
        public static void UpdateComboBoxWith(this ComboBox editor, IChunkPtrAccessor ptr)
        {
            editor.Items.Add(new PtrComboItem { Text = "", Value = null });

            var availableChunks = CR2WManager.GetAvailableTypes(ptr.ReferenceType).Select(_ => _.Name).ToList();
            foreach (var chunk in ptr.cr2w.Chunks.Where(_ => availableChunks.Contains(_.REDType)))
            {
                editor.Items.Add(new PtrComboItem
                    {
                        Text = $"{chunk.REDType} #{chunk.ChunkIndex}", //real index
                        Value = chunk

                    }
                );
            }

            // add new item 
            editor.Items.Add(new PtrComboItem
            {
                Text = $"<Add new chunk ...>",
                Value = null

            });

            // select item
            if (ptr.Reference == null)
                editor.SelectedIndex = 0;
            else
            {
                int selIndex = 0;
                for (int i = 0; i < editor.Items.Count; i++)
                {
                    if (editor.Items[i].ToString() == $"{ptr.Reference.REDType} #{ptr.Reference.ChunkIndex}")
                    {
                        selIndex = i;
                        break;
                    }
                }

                editor.SelectedIndex = selIndex;
            }
        }
    }

    
}
