using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Serilog;
using WolvenKit.Core.Exceptions;
using WolvenKit.Core.Extensions;

namespace WolvenKit.Core.Compression;

public static class Oodle
{
    public enum Compressor : int
    {
        LZH = 0,
        LZHLW = 1,
        LZNIB = 2,
        None = 3,
        LZB16 = 4,
        LZBLW = 5,
        LZA = 6,
        LZNA = 7,
        Kraken = 8,
        Mermaid = 9,
        BitKnit = 10,
        Selkie = 11,
        Akkorokamui = 12,
    }

    public enum CompressionLevel
    {
        None = 0,
        SuperFast = 1,
        VeryFast = 2,
        Fast = 3,
        Normal = 4,
        Optimal1 = 5,
        Optimal2 = 6,
        Optimal3 = 7,
        Optimal4 = 8,
        Optimal5 = 9,
    }

    public enum FuzzSafe
    {
        No = 0,
        Yes = 1
    }

    public enum CheckCRC
    {
        No = 0,
        Yes = 1
    }

    public enum Verbosity
    {
        None = 0,
        Minimal = 1,
        Some = 2,
        Lots = 3
    }

    public enum ThreadPhase
    {
        ThreadPhase1 = 1,
        ThreadPhase2 = 2,
        ThreadPhaseAll = 3,
        Unthreaded = ThreadPhaseAll
    }

    public enum Status
    {
        Uncompressed,
        Compressed
    }

    public const uint KARK = 1263681867; // 0x4b, 0x41, 0x52, 0x4b

    public static bool Load()
    {
        if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
        {
            // try get oodle dll from game
            if (TryCopyOodleLib())
            {
                var result = OodleLib.Load(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "oo2ext_7_win64.dll"));
                if (result)
                {
                    CompressionSettings.Get().CompressionLevel = CompressionLevel.Optimal2;
                    CompressionSettings.Get().UseOodle = true;
                    return true;
                }
            }

            return true;
        }

        return RuntimeInformation.IsOSPlatform(OSPlatform.OSX)
|| (RuntimeInformation.IsOSPlatform(OSPlatform.Linux) ? true : throw new NotImplementedException());
    }

    public static bool IsCompressed(byte[] buf) => buf.Length >= 4 && buf[0] == 0x4B && buf[1] == 0x41 && buf[2] == 0x52 && buf[3] == 0x4B;
    public static bool IsCompressed(Stream stream) => stream.PeekFourCC() == 0x4B52414B;

    public static Status CompressBuffer(byte[] rawBuf, out byte[] compBuf) => CompressBuffer(rawBuf, out compBuf, CompressionSettings.Get().CompressionLevel);

    public static Status CompressBuffer(byte[] rawBuf, out byte[] compBuf, CompressionLevel compressionLevel)
    {
        if (rawBuf.Length > 256)
        {
            //var compressedBufferSizeNeeded = GetCompressedBufferSizeNeeded(rawBuf.Length);
            //var compressedBuffer = new byte[compressedBufferSizeNeeded];
            IEnumerable<byte> compressedBuffer = new List<byte>();

            var compressedSize = Oodle.Compress(rawBuf, ref compressedBuffer, false, compressionLevel);

            var outArray = new byte[compressedSize + 8];

            Array.Copy(BitConverter.GetBytes(KARK), 0, outArray, 0, 4);
            Array.Copy(BitConverter.GetBytes(rawBuf.Length), 0, outArray, 4, 4);
            Array.Copy(compressedBuffer.ToArray(), 0, outArray, 8, compressedSize);

            if (rawBuf.Length > outArray.Length)
            {
                compBuf = outArray;
                return Status.Compressed;
            }
        }

        compBuf = rawBuf;
        return Status.Uncompressed;
    }

    public static bool DecompressBuffer(byte[] compBuf, out byte[] rawBuf)
    {
        using var ms = new MemoryStream(compBuf);
        return DecompressBuffer(ms, out rawBuf);
    }

    public static bool DecompressBuffer(Stream inStream, out byte[] rawBuf)
    {
        if (inStream is not { CanRead: true })
        {
            throw new ArgumentException(nameof(inStream));
        }

        var header = inStream.ReadStruct<uint>();
        if (header == KARK)
        {
            var size = inStream.ReadStruct<uint>();

            var compressedData = new byte[inStream.Length - 8];
            inStream.Read(compressedData, 0, compressedData.Length);
            rawBuf = new byte[size];

            Decompress(compressedData, rawBuf);
            return true;
        }

        rawBuf = Array.Empty<byte>();
        return false;
    }

    public static int Compress(byte[] inputBuffer, ref IEnumerable<byte> outputBuffer, bool useRedHeader,
        CompressionLevel level = CompressionLevel.Normal, Compressor compressor = Compressor.Kraken)
    {
        if (inputBuffer == null)
        {
            throw new ArgumentNullException(nameof(inputBuffer));
        }
        var inputCount = inputBuffer.Length;
        if (inputCount <= 0 || inputCount > inputBuffer.Length)
        {
            throw new ArgumentOutOfRangeException(nameof(inputCount));
        }
        if (outputBuffer == null)
        {
            throw new ArgumentNullException(nameof(outputBuffer));
        }

        var result = 0;
        var compressedBufferSizeNeeded = Oodle.GetCompressedBufferSizeNeeded(inputCount);
        var compressedBuffer = new byte[compressedBufferSizeNeeded];

        if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
        {
            result = CompressionSettings.Get().UseOodle
                ? OodleLib.OodleLZ_Compress(inputBuffer, compressedBuffer, compressor, level)
                : KrakenNative.Compress(inputBuffer, compressedBuffer, (int)level);
        }
        else
        {
            result = RuntimeInformation.IsOSPlatform(OSPlatform.OSX)
                ? KrakenNative.Compress(inputBuffer, compressedBuffer, (int)level)
                : RuntimeInformation.IsOSPlatform(OSPlatform.Linux)
                            ? KrakenNative.Compress(inputBuffer, compressedBuffer, (int)level)
                            : throw new NotImplementedException();
        }


        if (result == 0 || inputCount <= (result + 8))
        {
            outputBuffer = inputBuffer;
            return outputBuffer.Count();
        }

        if (useRedHeader)
        {
            // write KARK header
            var writelist = new List<byte>()
                    {
                        0x4B, 0x41, 0x52, 0x4B  //KARK, TODO: make this dependent on the compression algo
                    };
            // write size
            writelist.AddRange(BitConverter.GetBytes(inputCount));
            // write compressed data
            writelist.AddRange(compressedBuffer.Take(result));

            outputBuffer = writelist;
        }
        else
        {
            outputBuffer = compressedBuffer.Take(result);
        }

        return outputBuffer.Count();
    }


    public static long Decompress(byte[] inputBuffer, byte[] outputBuffer)
    {
        var result = 0;

        if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
        {
            result = CompressionSettings.Get().UseOodle
                ? OodleLib.OodleLZ_Decompress(inputBuffer, outputBuffer)
                : KrakenNative.Decompress(inputBuffer, outputBuffer);
        }
        else
        {
            result = RuntimeInformation.IsOSPlatform(OSPlatform.OSX)
                ? KrakenNative.Decompress(inputBuffer, outputBuffer)
                : RuntimeInformation.IsOSPlatform(OSPlatform.Linux)
                            ? KrakenNative.Decompress(inputBuffer, outputBuffer)
                            : throw new NotImplementedException();
        }

        return result;
    }

    /// <summary>
    /// Decompresses and copies a segment of zsize bytes from a stream to another stream
    /// </summary>
    /// <param name="stream"></param>
    /// <param name="outStream"></param>
    /// <param name="zSize"></param>
    /// <param name="size"></param>
    /// <exception cref="Exception"></exception>
    /// <exception cref="DecompressionException"></exception>
    public static void DecompressAndCopySegment(this Stream stream, Stream outStream, uint zSize, uint size)
    {
        if (zSize == size)
        {
            stream.CopyToWithLength(outStream, (int)zSize);
        }
        else
        {
            var oodleCompression = stream.ReadStruct<uint>();
            if (oodleCompression == KARK)
            {
                var headerSize = stream.ReadStruct<uint>();
                if (headerSize != size)
                {
                    throw new DecompressionException($"Buffer size doesn't match size in info table. {headerSize} vs {size}");
                }

                //const int SPAN_LEN = 5333;//32768;
                var length = (int)zSize - 8;

                var inputBuffer = new byte[length];
                var read = stream.Read(inputBuffer);
                var outBuffer = new byte[size];
                var unpackedSize = Oodle.Decompress(inputBuffer, outBuffer);

                //var inputBufferSpan = length <= SPAN_LEN
                //    ? stackalloc byte[length]
                //    : new byte[length];
                //var outputBufferSpan = size <= SPAN_LEN ? stackalloc byte[(int)size] : new byte[size];

                //stream.Read(inputBufferSpan);

                //var unpackedSize = Oodle.Decompress(inputBufferSpan, outputBufferSpan);
                if (unpackedSize != size)
                {
                    throw new DecompressionException(
                        $"Unpacked size {unpackedSize} doesn't match real size {size}.");
                }

                //outStream.Write(outputBufferSpan);
                outStream.Write(outBuffer);
            }
            else
            {
                stream.Seek(0, SeekOrigin.Begin);
                stream.CopyToWithLength(outStream, (int)zSize);
            }
        }
    }

    /// <summary>
    /// Decompresses and copies a segment of zsize bytes from a stream to another stream
    /// </summary>
    /// <param name="stream"></param>
    /// <param name="outStream"></param>
    /// <param name="zSize"></param>
    /// <param name="size"></param>
    /// <exception cref="Exception"></exception>
    /// <exception cref="DecompressionException"></exception>
    public static async Task DecompressAndCopySegmentAsync(this Stream stream, Stream outStream, uint zSize, uint size)
    {
        if (zSize == size)
        {
            stream.CopyToWithLength(outStream, (int)zSize);
        }
        else
        {
            var oodleCompression = stream.ReadStruct<uint>();
            if (oodleCompression == KARK)
            {
                var headerSize = stream.ReadStruct<uint>();
                if (headerSize != size)
                {
                    throw new Exception($"Buffer size doesn't match size in info table. {headerSize} vs {size}");
                }

                var inputBuffer = new byte[(int)zSize - 8];

                var read = stream.Read(inputBuffer);
                var outputBuffer = new byte[size];

                var unpackedSize = await Task.Run(() => Oodle.Decompress(inputBuffer, outputBuffer));

                if (unpackedSize != size)
                {
                    throw new DecompressionException(
                        $"Unpacked size {unpackedSize} doesn't match real size {size}.");
                }

                outStream.Write(outputBuffer);
            }
            else
            {
                stream.Seek(0, SeekOrigin.Begin);
                stream.CopyToWithLength(outStream, (int)zSize);
            }
        }
    }

    /// <summary>
    /// Gets the max buffer size needed for oodle compression
    /// </summary>
    /// <param name="count"></param>
    /// <returns></returns>
    public static int GetCompressedBufferSizeNeeded(int count)
    {
        var n = (((count + 0x3ffff + ((uint)((count + 0x3ffff) >> 0x3f) & 0x3ffff))
                 >> 0x12) * 0x112) + count;
        //var n  = OodleNative.GetCompressedBufferSizeNeeded((long)count);
        return (int)n;
    }

    private static bool TryCopyOodleLib()
    {
        var ass = AppDomain.CurrentDomain.BaseDirectory;
        var destFileName = Path.Combine(ass, "oo2ext_7_win64.dll");
        if (File.Exists(destFileName))
        {
            return true;
        }

        var cp77BinDir = TryGetGameInstallDir();
        if (string.IsNullOrEmpty(cp77BinDir))
        {
            return false;
        }

        // copy oodle dll
        var oodleInfo = new FileInfo(Path.Combine(cp77BinDir, "oo2ext_7_win64.dll"));
        if (!oodleInfo.Exists)
        {
            return false;
        }

        if (!File.Exists(destFileName))
        {
            oodleInfo.CopyTo(destFileName);
        }

        return true;
    }

    private delegate void StrDelegate(string value);

    private static string TryGetGameInstallDir()
    {
        var cp77BinDir = "";

#pragma warning disable CA1416
#if _WINDOWS
        var cp77exe = "";
        // check for CP77_DIR environment variable first
        var CP77_DIR = Environment.GetEnvironmentVariable("CP77_DIR", EnvironmentVariableTarget.User);
        if (!string.IsNullOrEmpty(CP77_DIR) && new DirectoryInfo(CP77_DIR).Exists)
        {
            cp77BinDir = Path.Combine(CP77_DIR, "bin", "x64");
        }

        if (File.Exists(Path.Combine(cp77BinDir, "Cyberpunk2077.exe")))
        {
            return cp77BinDir;
        }

        // else: look for install location
        const string uninstallkey = "SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Uninstall\\";
        const string uninstallkey2 = "SOFTWARE\\Wow6432Node\\Microsoft\\Windows\\CurrentVersion\\Uninstall\\";
        const string gameName = "Cyberpunk 2077";
        const string exeName = "Cyberpunk2077.exe";
        var exePath = "";
        void strDelegate(string msg) => cp77exe = msg;

        try
        {
            Parallel.ForEach(Microsoft.Win32.Registry.LocalMachine.OpenSubKey(uninstallkey)?.GetSubKeyNames(), item =>
            {
                var programName = Microsoft.Win32.Registry.LocalMachine.OpenSubKey(uninstallkey + item)
                    ?.GetValue("DisplayName");
                var installLocation = Microsoft.Win32.Registry.LocalMachine.OpenSubKey(uninstallkey + item)
                    ?.GetValue("InstallLocation");
                if (programName != null && installLocation != null)
                {
                    if (programName.ToString().Contains(gameName) ||
                        programName.ToString().Contains(gameName))
                    {
                        exePath = Directory.GetFiles(installLocation.ToString(), exeName,
                            SearchOption.AllDirectories).First();
                    }
                }

                strDelegate(exePath);
            });
            Parallel.ForEach(Microsoft.Win32.Registry.LocalMachine.OpenSubKey(uninstallkey2)?.GetSubKeyNames(), item =>
            {
                var programName = Microsoft.Win32.Registry.LocalMachine.OpenSubKey(uninstallkey2 + item)
                    ?.GetValue("DisplayName");
                var installLocation = Microsoft.Win32.Registry.LocalMachine.OpenSubKey(uninstallkey2 + item)
                    ?.GetValue("InstallLocation");
                if (programName != null && installLocation != null)
                {
                    if (programName.ToString().Contains(gameName) ||
                        programName.ToString().Contains(gameName))
                    {
                        if (Directory.Exists(installLocation.ToString()))
                        {
                            exePath = Directory.GetFiles(installLocation.ToString(), exeName,
                                SearchOption.AllDirectories).First();
                        }
                    }
                }

                strDelegate(exePath);
            });

            if (File.Exists(cp77exe))
            {
                cp77BinDir = new FileInfo(cp77exe).Directory.FullName;
            }
        }
        catch (Exception)
        {
            return null;
        }

        if (string.IsNullOrEmpty(cp77BinDir))
        {
            return null;
        }

        if (!File.Exists(Path.Combine(cp77BinDir, "Cyberpunk2077.exe")))
        {
            return null;
        }
#endif
#pragma warning restore CA1416

        return cp77BinDir;
    }
}
