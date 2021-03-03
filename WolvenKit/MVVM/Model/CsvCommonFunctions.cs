using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using CsvHelper;

namespace WolvenKit.MVVM.Model
{
    using Common.Services;
    using CR2W.Types;
    using WolvenKit.Common.Model.Cr2w;
    using WolvenKit.Functionality.Controllers;

    public static class CsvCommonFunctions
    {

        public static string ToCsvString(this IArrayAccessor wrappedArray, bool useHeader = false)
        {
            try
            {
                using (var ms = new MemoryStream())
                using (var writer = new StreamWriter(ms, Encoding.UTF8))
                using (var reader = new StreamReader(ms))
                using (var csv = new CsvWriter(writer, CultureInfo.InvariantCulture))
                {
                    RegisterClassMap(wrappedArray.InnerType, csv);
                    csv.Configuration.HasHeaderRecord = useHeader;
                    csv.WriteRecords(wrappedArray);

                    writer.Flush();
                    ms.Seek(0, SeekOrigin.Begin);

                    var s = reader.ReadToEnd();
                    return s;
                }
            }
            catch (Exception)
            {
                MainController.LogString("Creating Csv file failed, please double-check your input.", Logtype.Error);
                return null;
            }

        }

        public static IEnumerable<object> FromCsv(Type type, string csvstring, bool useHeader = false)
        {
            using (var reader = new StringReader(csvstring))
            {
                return FromCsvInner(type, reader, useHeader);
            }
        }
        public static IEnumerable<object> FromCsv(Type type, FileInfo path, bool useHeader = true)
        {
            using (var reader = new StreamReader(path.FullName))
            {
                return FromCsvInner(type, reader, useHeader);
            }
        }

        private static IEnumerable<object> FromCsvInner(Type type, TextReader reader, bool useHeader = false)
        {
            try
            {
                using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
                {
                    RegisterClassMap(type, csv);
                    csv.Configuration.HasHeaderRecord = useHeader;

                    var records = csv.GetRecords(type).ToList();
                    // TODO: is there a way without recreating all?

                    return records;
                }
            }
            catch (Exception)
            {
                MainController.LogString("Creating Csv file failed, please double-check your input.", Logtype.Error);
                return null;
            }
        }

        private static void RegisterClassMap(Type type, CsvWriter csv)
        {
            if (type == typeof(CName)) csv.Configuration.RegisterClassMap<CNameMap>();
            if (type == typeof(CString)) csv.Configuration.RegisterClassMap<CStringMap>();
            if (type == typeof(CBool)) csv.Configuration.RegisterClassMap<CBoolMap>();
            if (type == typeof(CFloat)) csv.Configuration.RegisterClassMap<CFloatMap>();

            if (type == typeof(CUInt8)) csv.Configuration.RegisterClassMap<CUInt8Map>();
            if (type == typeof(CUInt16)) csv.Configuration.RegisterClassMap<CUInt16Map>();
            if (type == typeof(CUInt32)) csv.Configuration.RegisterClassMap<CUInt32Map>();
            if (type == typeof(CUInt64)) csv.Configuration.RegisterClassMap<CUInt64Map>();
            if (type == typeof(CInt8)) csv.Configuration.RegisterClassMap<CInt8Map>();
            if (type == typeof(CInt16)) csv.Configuration.RegisterClassMap<CInt16Map>();
            if (type == typeof(CInt32)) csv.Configuration.RegisterClassMap<CInt32Map>();
            if (type == typeof(CInt64)) csv.Configuration.RegisterClassMap<CInt64Map>();

        }
        private static void RegisterClassMap(Type type, CsvReader csv)
        {
            if (type == typeof(CName)) csv.Configuration.RegisterClassMap<CNameMap>();

        }

    }
}
