using System;
using System.IO;
using System.Runtime.InteropServices;
using WolvenKit.Core.CRC;

namespace WolvenKit.Core.Extensions
{
    public static class StreamExtensions
    {
        //https://stackoverflow.com/a/13022108
        public static void CopyToWithLength(this Stream input, Stream output, int bytes)
        {
            var buffer = new byte[4096];
            int read;
            while (bytes > 0 &&
                   (read = input.Read(buffer, 0, Math.Min(buffer.Length, bytes))) > 0)
            {
                output.Write(buffer, 0, read);
                bytes -= read;
            }
        }

        public static byte[] ToByteArray(this Stream input, bool keepPosition = false)
        {
            if (input is MemoryStream memoryStream)
            {
                return memoryStream.ToArray();
            }
            else
            {
                using var ms = new MemoryStream();
                if (!keepPosition)
                {
                    input.Position = 0;
                }
                input.CopyTo(ms);
                return ms.ToArray();

            }
        }

        public static uint PeekFourCC(this Stream m_stream)
        {
            var startPos = m_stream.Position;
            var fourcc = m_stream.ReadStruct<uint>();
            m_stream.Position = startPos;

            return fourcc;
        }

        public static T ReadStruct<T>(this Stream m_stream, Crc32Algorithm? crc32 = null) where T : struct
        {
            var size = Marshal.SizeOf<T>();

            var m_temp = new byte[size];
            m_stream.Read(m_temp, 0, size);

            var handle = GCHandle.Alloc(m_temp, GCHandleType.Pinned);
            var item = Marshal.PtrToStructure<T>(handle.AddrOfPinnedObject());

            crc32?.Append(m_temp);

            handle.Free();

            return item;
        }

        public static void WriteStruct<T>(this Stream m_stream, T value, Crc32Algorithm? crc32 = null) where T : struct
        {
            var m_temp = new byte[Marshal.SizeOf<T>()];
            var handle = GCHandle.Alloc(m_temp, GCHandleType.Pinned);

            Marshal.StructureToPtr(value, handle.AddrOfPinnedObject(), true);
            m_stream.Write(m_temp, 0, m_temp.Length);

            crc32?.Append(m_temp);

            handle.Free();
        }

        public static T[] ReadStructs<T>(this Stream m_stream, uint count, Crc32Algorithm? crc32 = null) where T : struct
        {
            var size = Marshal.SizeOf<T>();
            var items = new T[count];

            var m_temp = new byte[size];
            for (uint i = 0; i < count; i++)
            {
                m_stream.Read(m_temp, 0, size);

                var handle = GCHandle.Alloc(m_temp, GCHandleType.Pinned);
                items[i] = Marshal.PtrToStructure<T>(handle.AddrOfPinnedObject());

                crc32?.Append(m_temp);

                handle.Free();
            }

            return items;
        }

        public static void WriteStructs<T>(this Stream m_stream, T[] array, Crc32Algorithm? crc32 = null) where T : struct
        {
            var size = Marshal.SizeOf<T>();
            var m_temp = new byte[size];
            for (var i = 0; i < array.Length; i++)
            {
                var handle = GCHandle.Alloc(m_temp, GCHandleType.Pinned);

                Marshal.StructureToPtr(array[i], handle.AddrOfPinnedObject(), true);
                m_stream.Write(m_temp, 0, m_temp.Length);

                crc32?.Append(m_temp);

                handle.Free();
            }
        }
    }
}
