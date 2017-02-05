using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W3Edit.Video
{
    public sealed class ByteConversion
    {
        /// <summary>
        /// Codepage value for Shift JIS (Jp)
        /// </summary>
        public const int CodePageJapan = 932;
        /// <summary>
        /// Codepage value for Cyrillic (US)
        /// </summary>
        public const int CodePageUnitedStates = 1251;

        /// <summary>
        /// Codepage value for OEM DOS
        /// </summary>
        public const int CodePageOEM = 437;

        private ByteConversion() { }

        /// <summary>
        /// Get string from bytes.
        /// </summary>
        /// <param name="pBytes">Bytes to convert to a string.</param>
        /// <param name="codePage">Codepage to use in converting bytes.</param>
        /// <returns>String encoding using the input Codepage.</returns>
        public static string GetEncodedText(byte[] value, int codePage)
        {
            //return Encoding.Unicode.GetString(value);
            return System.Text.Encoding.GetEncoding(codePage).GetString(value);
        }

        /// <summary>
        /// Get text encoded in Shift JIS
        /// </summary>
        /// <param name="pBytes">Bytes to decode.</param>
        /// <returns>String encoded using the Shift JIS codepage.</returns>
        public static string GetJapaneseEncodedText(byte[] value)
        {
            return GetEncodedText(value, CodePageJapan);
        }
        /// <summary>
        /// Get text encoded in Cyrillic
        /// </summary>
        /// <param name="pBytes">Bytes to decode.</param>
        /// <returns>String encoded using the Cyrillic codepage.</returns>
        public static string GetUnitedStatesEncodedText(byte[] value)
        {
            return GetEncodedText(value, CodePageUnitedStates);
        }

        /// <summary>
        /// Get text encoded in ASCII
        /// </summary>
        /// <param name="pBytes">Bytes to decode.</param>
        /// <returns>String encoded using ASCII.</returns>
        public static string GetAsciiText(byte[] value)
        {
            System.Text.Encoding ascii = System.Text.Encoding.ASCII;
            return ascii.GetString(value);
        }

        /// <summary>
        /// Get text encoded in ASCII, stops at null.
        /// </summary>
        /// <param name="pBytes">Bytes to decode.</param>
        /// <param name="offset">Offet within byte array of string.</param>
        /// <returns>String encoded using ASCII.</returns>
        public static string GetAsciiText(byte[] value, long offset)
        {
            StringBuilder sb = new StringBuilder();
            System.Text.Encoding ascii = System.Text.Encoding.ASCII;

            for (long i = offset; i < value.Length; i++)
            {
                if (value[i] == 0)
                {
                    break;
                }
                else
                {
                    sb.Append((char)value[i]);
                }
            }

            return sb.ToString();
        }

        public static string GetUtf16LeText(byte[] value)
        {
            System.Text.Encoding encoding = System.Text.Encoding.Unicode;
            return encoding.GetString(value);
        }


        /// <summary>
        /// Convert input string to a long.  Works for Decimal and Hexidecimal (use 0x prefix).
        /// </summary>
        /// <param name="pStringNumber">String containing a Decimal and Hexidecimal number.</param>
        /// <returns>Long representing the input string.</returns>
        public static long GetLongValueFromString(string value)
        {
            long ret;
            bool isNegative = false;
            string parseValue;

            if (value.StartsWith("-"))
            {
                parseValue = value.Substring(1);
                isNegative = true;
            }
            else
            {
                parseValue = value;
            }

            if (parseValue.StartsWith("0x", StringComparison.CurrentCultureIgnoreCase))
            {
                parseValue = parseValue.Substring(2);
                ret = long.Parse(parseValue, System.Globalization.NumberStyles.HexNumber, null);
            }
            else
            {
                ret = long.Parse(parseValue, System.Globalization.NumberStyles.Integer, null);
            }

            if (isNegative)
            {
                ret *= -1;
            }

            return ret;
        }

        /// <summary>
        /// Get the UInt32 Value of the Incoming Byte Array, which is in Big Endian order.
        /// </summary>
        /// <param name="pBytes">Bytes to convert.</param>
        /// <returns>The UInt32 Value of the Incoming Byte Array.</returns>
        public static UInt32 GetUInt32BigEndian(byte[] value)
        {
            byte[] workingArray = new byte[value.Length];
            Array.Copy(value, 0, workingArray, 0, value.Length);

            if (BitConverter.IsLittleEndian)
            {
                Array.Reverse(workingArray);
            }
            return BitConverter.ToUInt32(workingArray, 0);
        }

        /// <summary>
        /// Get the UInt16 Value of the Incoming Byte Array, which is in Big Endian order.
        /// </summary>
        /// <param name="pBytes">Bytes to convert.</param>
        /// <returns>The UInt16 Value of the Incoming Byte Array.</returns>
        public static UInt16 GetUInt16BigEndian(byte[] value)
        {
            byte[] workingArray = new byte[value.Length];
            Array.Copy(value, 0, workingArray, 0, value.Length);

            if (BitConverter.IsLittleEndian)
            {
                Array.Reverse(workingArray);
            }
            return BitConverter.ToUInt16(workingArray, 0);
        }

        /// <summary>
        /// Predicts Code Page between Cyrillic and Shift-JIS based on whether high ASCII is included or not.
        /// </summary>
        /// <param name="tagBytes">Bytes containing the tags in an unknown language.</param>
        /// <returns>Integer representing the predicted code page.</returns>
        public static int GetPredictedCodePageForTags(byte[] tagBytes)
        {
            int predictedCodePage = CodePageUnitedStates;

            foreach (byte b in tagBytes)
            {
                if ((int)b > 0x7F)
                {
                    predictedCodePage = CodePageJapan;
                    break;
                }
            }

            return predictedCodePage;
        }

        public static byte GetHighNibble(byte value)
        {
            return (byte)(((value) >> 4) & 0x0F);
        }

        public static byte GetLowNibble(byte value)
        {
            return (byte)((value) & 0x0F); ;
        }

        public static byte[] GetBytesFromHexString(string hexValue)
        {
            int j = 0;
            byte[] bytes = new byte[hexValue.Length / 2];

            // convert the string to bytes
            for (int i = 0; i < hexValue.Length; i += 2)
            {
                bytes[j] = BitConverter.GetBytes(Int16.Parse(hexValue.Substring(i, 2), System.Globalization.NumberStyles.AllowHexSpecifier, CultureInfo.CurrentCulture))[0];
                j++;
            }

            return bytes;
        }

        public static byte[] GetBytesBigEndian(uint value)
        {
            byte[] ret = BitConverter.GetBytes(value);
            Array.Reverse(ret);
            return ret;
        }

        public static DateTime GetDateTimeFromFAT32Date(int value)
        {
            short xDate = (short)(value >> 0x10);
            short xTime = (short)(value & 0xFFFF);

            if (xDate == 0 && xTime == 0)
            {
                return DateTime.Now;
            }
            else
            {
                return new DateTime(
                    (((xDate & 0xFE00) >> 9) + 0x7BC),
                    ((xDate & 0x1E0) >> 5),
                    (xDate & 0x1F),
                    ((xTime & 0xF800) >> 0xB),
                    ((xTime & 0x7E0) >> 5),
                    ((xTime & 0x1F) * 2));
            }
        }

    }
}
