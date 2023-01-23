using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED4.Types;

namespace WolvenKit.Modkit.Extensions
{
    internal static class C2dArrayExtensions
    {
        /// <summary>
        /// Converts the data to a csv file
        /// </summary>
        /// <param name="stream"></param>
        /// <param name="separator"></param>
        public static void ToCsvStream(this C2dArray c2DArray, Stream stream, char separator = ',')
        {
            using var writer = new StreamWriter(stream);

            // write header
            if (c2DArray.Headers == null)
            {
                return;
            }

            var headerline = string.Join(separator, c2DArray.Headers);
            writer.WriteLine(headerline);

            // write body
            if (c2DArray.Data == null)
            {
                return;
            }

            foreach (var dataElement in c2DArray.Data)
            {
                var dataline = string.Join(separator, dataElement);
                writer.WriteLine(dataline);
            }
        }

        /// <summary>
        /// Imports data from a csv file
        /// </summary>
        /// <param name="stream"></param>
        /// <param name="separator"></param>
        public static void FromCsvStream(this C2dArray c2DArray, Stream stream, char separator = ',')
        {
            using var sr = new StreamReader(stream);

            // first line is the header
            c2DArray.Headers.Clear();
            var headerline = sr.ReadLine();
            if (string.IsNullOrEmpty(headerline))
            {
                return;
            }

            var array = headerline.Split(separator);
            for (var i = 0; i < array.Length; i++)
            {
                c2DArray.Headers.Add(array[i]);
                c2DArray.CompiledHeaders.Add(array[i]);
            }

            // read elements
            string? line;
            var cnt = 0;
            while ((line = sr.ReadLine()) != null)
            {
                // check if same columns as header
                var columns = line.Split(separator);
                if (columns.Length != c2DArray.Headers.Count)
                {
                    throw new SerializationException();
                }

                var row = new CArray<CString>();
                for (var i = 0; i < columns.Length; i++)
                {
                    row.Add(columns[i]);
                }

                c2DArray.Data.Add(row);
                c2DArray.CompiledData.Add(row);
                cnt++;
            }
        }


    }
}
