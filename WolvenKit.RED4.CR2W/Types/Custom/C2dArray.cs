using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using FastMember;
using WolvenKit.RED4.CR2W;
using WolvenKit.RED4.CR2W.Reflection;
using WolvenKit.RED4.CR2W.Types;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
    public class C2dArray : C2dArray_
    {
        public C2dArray(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }

        /// <summary>
        /// Converts the data to a csv file
        /// </summary>
        /// <param name="stream"></param>
        /// <param name="seperator"></param>
        public void ToCsvStream(Stream stream, char seperator = ',')
        {
            using var writer = new StreamWriter(stream);

            // write header
            if (Headers?.Elements == null) return;
            string headerline = string.Join(seperator, Headers.Elements.Select(_ => _.Value));
            writer.WriteLine(headerline);
            
            // write body
            if (Data?.Elements == null) return;
            foreach (var dataElement in Data.Elements)
            {
                string dataline = string.Join(seperator, dataElement.Elements.Select(_ => _.Value));
                writer.WriteLine(dataline);
            }
        }

        /// <summary>
        /// Imports data from a csv file
        /// </summary>
        /// <param name="stream"></param>
        /// <param name="separator"></param>
        public void FromCsvStream(Stream stream, char separator = ',')
        {
            using var sr = new StreamReader(stream);

            // first line is the header
            Headers.Clear();
            var headerline = sr.ReadLine();
            if (string.IsNullOrEmpty(headerline))
            {
                return;
            }

            var array = headerline.Split(separator);
            for (var i = 0; i < array.Length; i++)
            {
                var item = array[i];
                var cstring = new CString(cr2w, Headers, i.ToString());
                cstring.SetValue(item);
                Headers.Add(cstring);
            }
            Headers.IsSerialized = true;

            // read elements
            string line;
            var cnt = 0;
            while ((line = sr.ReadLine()) != null)
            {
                // check if same columns as header
                var columns = line.Split(separator);
                if (columns.Length != Headers.Count)
                {
                    throw new SerializationException();
                }

                var row = new CArray<CString>(cr2w, Data, cnt.ToString());
                for (var i = 0; i < columns.Length; i++)
                {
                    var item = columns[i];
                    var cstring = new CString(cr2w, null, i.ToString());
                    cstring.SetValue(item);
                    row.Add(cstring);
                }

                Data.Add(row);
                cnt++;
            }
            Data.IsSerialized = true;

        }

        public override void Read(BinaryReader file, uint size)
        {
            base.Read(file, size);

            // csv files have the same data as above but appended
            // and with VLQint-indexed arrays instead of uint32

            // Headers
            var vlqheader = new CArrayVLQInt32<CString>(cr2w, null, "");
            vlqheader.Read(file, 0);

            // Data
            var vlqdata = new CArrayVLQInt32<CArrayVLQInt32<CString>>(cr2w, null, "");
            vlqdata.Read(file, 0);

        }

        public override void Write(BinaryWriter file)
        {
            base.Write(file);

            // Headers
            var vlqheader = new CArrayVLQInt32<CString>(cr2w, null, "") {Elements = Headers.Elements};
            vlqheader.Write(file);

            // Data
            var vlqdata = new CArrayVLQInt32<CArrayVLQInt32<CString>>(cr2w, null, "");
            if (Data != null)
                foreach (var dataElement in Data.Elements)
                {
                    var datael = new CArrayVLQInt32<CString>(cr2w, null, "") {Elements = dataElement.Elements};
                    vlqdata.Elements.Add(datael);
                }

            vlqdata.Write(file);
        }
    }
}
