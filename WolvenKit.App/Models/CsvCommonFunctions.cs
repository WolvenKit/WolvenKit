using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using CsvHelper;
using CsvHelper.Configuration;
using WolvenKit.Common;
using WolvenKit.Common.Model.Cr2w;
using WolvenKit.Common.Services;
using WolvenKit.Functionality.Controllers;
using WolvenKit.RED3.CR2W.Types;

namespace WolvenKit.Models
{
    public static class CsvCommonFunctions
    {
        #region Methods

        public static IEnumerable<object> FromCsv(Type type, string csvstring, bool useHeader = false)
        {
            using var reader = new StringReader(csvstring);
            return FromCsvInner(type, reader, useHeader);
        }

        public static IEnumerable<object> FromCsv(Type type, FileInfo path, bool useHeader = true)
        {
            using var reader = new StreamReader(path.FullName);
            return FromCsvInner(type, reader, useHeader);
        }

        public static string ToCsvString(this IArrayAccessor wrappedArray, bool useHeader = false)
        {
            try
            {
                using var ms = new MemoryStream();
                using var writer = new StreamWriter(ms, Encoding.UTF8);
                using var reader = new StreamReader(ms);
                var config = new CsvConfiguration(CultureInfo.InvariantCulture)
                {
                    HasHeaderRecord = useHeader,
                };
                using var csv = new CsvWriter(writer, config);
                RegisterClassMap(wrappedArray.InnerType, csv);
                csv.WriteRecords(wrappedArray);

                writer.Flush();
                ms.Seek(0, SeekOrigin.Begin);

                var s = reader.ReadToEnd();
                return s;
            }
            catch (Exception)
            {
                MainController.LogString("Creating Csv file failed, please double-check your input.", Logtype.Error);
                return null;
            }
        }

        private static IEnumerable<object> FromCsvInner(Type type, TextReader reader, bool useHeader = false)
        {
            try
            {
                var config = new CsvConfiguration(CultureInfo.InvariantCulture)
                {
                    HasHeaderRecord = useHeader,
                };
                using var csv = new CsvReader(reader, config);
                RegisterClassMap(type, csv);

                var records = csv.GetRecords(type).ToList();
                // TODO: is there a way without recreating all?

                return records;
            }
            catch (Exception)
            {
                MainController.LogString("Creating Csv file failed, please double-check your input.", Logtype.Error);
                return null;
            }
        }

        private static void RegisterClassMap(Type type, CsvWriter csv)
        {
            if (type == typeof(CName))
            {
                csv.Context.RegisterClassMap<CNameMap>();
            }

            if (type == typeof(CString))
            {
                csv.Context.RegisterClassMap<CStringMap>();
            }

            if (type == typeof(CBool))
            {
                csv.Context.RegisterClassMap<CBoolMap>();
            }

            if (type == typeof(CFloat))
            {
                csv.Context.RegisterClassMap<CFloatMap>();
            }

            if (type == typeof(CUInt8))
            {
                csv.Context.RegisterClassMap<CUInt8Map>();
            }

            if (type == typeof(CUInt16))
            {
                csv.Context.RegisterClassMap<CUInt16Map>();
            }

            if (type == typeof(CUInt32))
            {
                csv.Context.RegisterClassMap<CUInt32Map>();
            }

            if (type == typeof(CUInt64))
            {
                csv.Context.RegisterClassMap<CUInt64Map>();
            }

            if (type == typeof(CInt8))
            {
                csv.Context.RegisterClassMap<CInt8Map>();
            }

            if (type == typeof(CInt16))
            {
                csv.Context.RegisterClassMap<CInt16Map>();
            }

            if (type == typeof(CInt32))
            {
                csv.Context.RegisterClassMap<CInt32Map>();
            }

            if (type == typeof(CInt64))
            {
                csv.Context.RegisterClassMap<CInt64Map>();
            }
        }

        private static void RegisterClassMap(Type type, CsvReader csv)
        {
            if (type == typeof(CName))
            {
                csv.Context.RegisterClassMap<CNameMap>();
            }
        }

        #endregion Methods
    }
}
