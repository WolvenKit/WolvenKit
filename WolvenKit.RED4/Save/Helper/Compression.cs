using K4os.Compression.LZ4;
using System.Diagnostics;
using System.Text;

namespace WolvenKit.RED4.Save;

public class Compression
{
    private delegate DataChunkInfo WriteDelegate(BinaryWriter writer, byte[] data);

    private static void WriteChunkTable(BinaryWriter writer, List<DataChunkInfo> chunkInfos, Settings compressionSettings)
    {
        writer.Write(Encoding.ASCII.GetBytes("FZLC"));
        writer.Write(chunkInfos.Count);
        foreach (var chunk in chunkInfos)
        {
            writer.Write(chunk.Offset);
            writer.Write(chunk.CompressedSize);
            writer.Write(chunk.DecompressedSize);
        }
        writer.Write(new byte[(compressionSettings.TableEntriesCount - chunkInfos.Count) * 12]);
    }

    public static void Write(BinaryWriter writer, byte[] data, Settings compressionSettings, bool compress)
    {
        if (compress)
            InternalWrite(writer, data, compressionSettings, WriteCompressedChunk);
        else
            InternalWrite(writer, data, compressionSettings, WriteUncompressedChunk);
    }

    private static DataChunkInfo WriteCompressedChunk(BinaryWriter writer, byte[] data)
    {
        var offset = (int)writer.BaseStream.Position;

        var outBuffer = new byte[LZ4Codec.MaximumOutputSize(data.Length)];
        var compressedSize = LZ4Codec.Encode(data, 0, data.Length, outBuffer, 0, outBuffer.Length);

        writer.Write(Encoding.ASCII.GetBytes("4ZLX"));
        writer.Write(data.Length);
        writer.Write(outBuffer, 0, compressedSize);

        return new DataChunkInfo
        {
            Offset = offset,
            CompressedSize = compressedSize + 8,
            DecompressedSize = data.Length
        };
    }

    private static DataChunkInfo WriteUncompressedChunk(BinaryWriter writer, byte[] data)
    {
        var offset = (int)writer.BaseStream.Position;

        writer.Write(data, 0, data.Length);

        return new DataChunkInfo
        {
            Offset = offset,
            CompressedSize = data.Length,
            DecompressedSize = data.Length
        };
    }

    private static void InternalWrite(BinaryWriter writer, byte[] data, Settings compressionSettings, WriteDelegate chunkWriter)
    {
        var startPos = (int)writer.BaseStream.Position;
        byte[] processedData;

        var chunks = new List<DataChunkInfo>();

        using (var ms = new MemoryStream())
        {
            using (var subWriter = new BinaryWriter(ms, Encoding.ASCII, true))
            {
                var chunkCount = data.Length / compressionSettings.ChunkSize;
                var chunkBytesLeft = data.Length % compressionSettings.ChunkSize;
                byte[] inBuffer;

                var index = 0;
                for (; index < chunkCount; index++)
                {
                    inBuffer = new byte[compressionSettings.ChunkSize];
                    Array.Copy(data, index * compressionSettings.ChunkSize, inBuffer, 0, inBuffer.Length);
                    chunks.Add(chunkWriter(subWriter, inBuffer));
                }

                inBuffer = new byte[chunkBytesLeft];
                Array.Copy(data, index * compressionSettings.ChunkSize, inBuffer, 0, inBuffer.Length);
                chunks.Add(chunkWriter(subWriter, inBuffer));
            }

            processedData = ms.ToArray();
        }

        var dataOffset = startPos + 8 + (compressionSettings.TableEntriesCount * 12);
        foreach (var chunk in chunks)
        {
            chunk.Offset += dataOffset;
        }

        WriteChunkTable(writer, chunks, compressionSettings);
        writer.Write(processedData);
    }

    //public static byte[] Recompress(Stream stream)
    //{
    //    byte[] resultBuffer;
    //
    //    var compressionTablePos = (int)stream.SeekMagicBytes(Constants.Magic.SECOND_FILE_HEADER_MAGIC);
    //
    //    stream.Position = stream.Length - 8;
    //    var intBuffer = new byte[4];
    //    stream.Read(intBuffer, 0, intBuffer.Length);
    //    var nodeInfoPos = BitConverter.ToInt32(intBuffer, 0);
    //
    //    stream.Position = compressionTablePos;
    //    var compressionHeader = ReadCompressionHeader(stream);
    //
    //    stream.Position = 0;
    //    var headerBuffer = stream.Read(25);
    //
    //    stream.Position += 8 + compressionHeader.Settings.TableEntriesCount * 12;
    //    var dataBuffer = stream.Read(nodeInfoPos - stream.Position);
    //    var footerBuffer = stream.Read(stream.Length - nodeInfoPos);
    //
    //    using (var ms = new MemoryStream())
    //    {
    //        using (var writer = new BinaryWriter(ms))
    //        {
    //            writer.Write(headerBuffer);
    //
    //            Write(writer, dataBuffer, compressionHeader.Settings, true);
    //
    //            var pos = (int)writer.BaseStream.Position;
    //            writer.Write(footerBuffer);
    //            writer.BaseStream.Seek(-8, SeekOrigin.End);
    //            writer.Write(pos);
    //        }
    //
    //        resultBuffer = ms.ToArray();
    //    }
    //
    //    return resultBuffer;
    //}

    private static CompressionHeader ReadCompressionHeader(Stream stream)
    {
        return ReadCompressionHeader(new BinaryReader(stream, Encoding.ASCII, true));
    }

    private static CompressionHeader ReadCompressionHeader(BinaryReader reader)
    {
        var position = reader.BaseStream.Position;
        
        var magicInt = BitConverter.ToUInt32(Encoding.ASCII.GetBytes("FZLC"), 0);
        if (reader.ReadUInt32() != magicInt)
            throw new Exception();

        var result = new CompressionHeader();

        var entryCount = reader.ReadInt32();
        for (int i = 0; i < entryCount; i++)
        {
            result.DataChunkInfos.Add(new DataChunkInfo
            {
                Offset = reader.ReadInt32(),
                CompressedSize = reader.ReadInt32(),
                DecompressedSize = reader.ReadInt32()
            });
        }

        result.MaxEntries = (result.DataChunkInfos[0].Offset - (int)(position + 8)) / 12;
        reader.BaseStream.Position = result.DataChunkInfos[0].Offset;

        return result;
    }

    public static byte[] Decompress(Stream stream)
    {
        byte[] buffer;

        using (var reader = new BinaryReader(stream))
        {
            var decompressedStream = Decompress(reader, out var compressionSettings);

            using (var writer = new BinaryWriter(decompressedStream, Encoding.ASCII, true))
            {
                writer.Seek(0, SeekOrigin.End);
                var pos = writer.BaseStream.Position;
                writer.Write(reader.ReadBytes((int)(reader.BaseStream.Length - reader.BaseStream.Position)));
                writer.Seek(-8, SeekOrigin.End);
                writer.Write((int)pos);
            }

            using (var ms = new MemoryStream())
            {
                decompressedStream.Position = 0;
                decompressedStream.CopyTo(ms);
                buffer = ms.ToArray();
            }
        }

        return buffer;
    }

    private static long SeekMagicBytes(Stream stream, string identifier)
    {
        return SeekMagicBytes(stream, Encoding.ASCII.GetBytes(identifier));
    }

    private static long SeekMagicBytes(Stream stream, byte[] magicBytes)
    {
        long oldPostion = stream.Position;
        long currentPosition;
        var buffer = new byte[magicBytes.Length - 1];

        stream.Position = 0;
        while ((currentPosition = stream.Position) < stream.Length)
        {
            if (stream.ReadByte() != magicBytes[0])
            {
                continue;
            }

            var tmpPos = stream.Position;
            if (stream.Read(buffer, 0, buffer.Length) < buffer.Length)
            {
                stream.Position = tmpPos;
                continue;
            }

            if (!buffer.SequenceEqual(magicBytes.Skip(1)))
            {
                stream.Position = tmpPos;
                continue;
            }

            stream.Position -= magicBytes.Length;
            return currentPosition;
        }

        stream.Position = oldPostion;
        return -1;
    }

    public static Stream Decompress(BinaryReader reader, out Settings compressionSettings)
    {
        var result = new MemoryStream();

        var compressionTablePos = SeekMagicBytes(reader.BaseStream, "FZLC");
        if (compressionTablePos == -1)
            throw new Exception();

        reader.BaseStream.Position = 0;
        result.Write(reader.ReadBytes((int)compressionTablePos));

        var compressionHeader = ReadCompressionHeader(reader);
        compressionSettings = compressionHeader.Settings;

        var magicInt = BitConverter.ToUInt32(Encoding.ASCII.GetBytes("4ZLX"), 0);
        using (var ms = new MemoryStream())
        {
            using (var writer = new BinaryWriter(ms))
            {
                foreach (var chunk in compressionHeader.DataChunkInfos)
                {
                    Debug.Assert(reader.BaseStream.Position == chunk.Offset);

                    byte[] outBuffer;

                    if (reader.ReadUInt32() == magicInt)
                    {
                        reader.ReadBytes(4); // decompressed size, again
                        var inBuffer = reader.ReadBytes(chunk.CompressedSize - 8);
                        outBuffer = new byte[chunk.DecompressedSize];
                        LZ4Codec.Decode(inBuffer, 0, inBuffer.Length, outBuffer, 0, outBuffer.Length);
                    }
                    else
                    {
                        reader.BaseStream.Position -= 4;
                        outBuffer = reader.ReadBytes(chunk.CompressedSize);
                    }

                    writer.Write(outBuffer);
                }
            }

            using (var writer = new BinaryWriter(result, Encoding.ASCII, true))
            {
                Write(writer, ms.ToArray(), compressionHeader.Settings, false);
            }
        }

        result.Position = 0;

        return result;
    }

    private class DataChunkInfo
    {
        public int Offset { get; set; }
        public int CompressedSize { get; set; }
        public int DecompressedSize { get; set; }
    }

    private class CompressionHeader
    {
        public CompressionHeader()
        {
            DataChunkInfos = new List<DataChunkInfo>();
        }

        public int MaxEntries { get; set; }
        public List<DataChunkInfo> DataChunkInfos { get; }

        public Settings Settings
        {
            get
            {
                if (MaxEntries == 0x100)
                {
                    return new Settings { TableEntriesCount = 0x100, ChunkSize = 0x00040000 };
                }

                if (MaxEntries == 0x200)
                {
                    return new Settings { TableEntriesCount = 0x200, ChunkSize = 0x00040000 };
                }

                if (MaxEntries == 0x400)
                {
                    return new Settings { TableEntriesCount = 0x400, ChunkSize = 0x00080000 };
                }

                throw new Exception();
            }
        }
    }

    public class Settings
    {
        public int TableEntriesCount { get; set; }
        public int ChunkSize { get; set; }
    }
}
