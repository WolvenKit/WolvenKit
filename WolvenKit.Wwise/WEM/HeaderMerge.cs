using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WolvenKit.Wwise.WEM
{
    /// <summary>
    /// Class to merge the header of modified wem files
    /// </summary>
    class HeaderMerge
    {
        /// <summary>
        /// Perform the merge
        /// </summary>
        /// <param name="original_wem">The original unmodified file</param>
        /// <param name="modified_wem">The new file exported from wwise</param>
        public void Merge(string original_wem, string modified_wem)
        {
            if (File.Exists(original_wem) || !File.Exists(modified_wem))
                throw new Exception("File doesn't exist! Can't merge!");
            if(Path.GetExtension(original_wem) != ".wem" || Path.GetExtension(modified_wem) != ".wem")
                throw new Exception("Only wwise *.wem files can be merged!");
            
            var wwinput = new WemFile();
            wwinput.LoadFromFile(original_wem);
            var wwoutput = new WemFile();

            wwoutput.merge_headers(wwinput)
            wwoutput.Merge_Datas(wwinput)
            wwoutput.Calculate_Riff_Size()
            
            wwoutput.WriteToFile(modified_wem);
        }


    }
}
