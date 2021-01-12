using RED.CRC32;
using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.InteropServices;
using WolvenKit.CR2W.Types;

namespace WolvenKit.CR2W
{
    public static class StreamExtensions
    {
        public static T ReadStruct<T>(this Stream m_stream, Crc32Algorithm crc32 = null) where T : struct
        {
            try
            {
                var size = Marshal.SizeOf<T>();

                var m_temp = new byte[size];
                m_stream.Read(m_temp, 0, size);

                var handle = GCHandle.Alloc(m_temp, GCHandleType.Pinned);
                var item = Marshal.PtrToStructure<T>(handle.AddrOfPinnedObject());

                if (crc32 != null)
                    crc32.Append(m_temp);

                handle.Free();

                return item;
            }
            catch (Exception ex)
            {

                throw ex;
            }
            
        }
        public static T[] ReadStructs<T>(this Stream m_stream, uint count, Crc32Algorithm crc32 = null) where T : struct
        {
            var size = Marshal.SizeOf<T>();
            var items = new T[count];

            var m_temp = new byte[size];
            for (uint i = 0; i < count; i++)
            {
                m_stream.Read(m_temp, 0, size);

                var handle = GCHandle.Alloc(m_temp, GCHandleType.Pinned);
                items[i] = Marshal.PtrToStructure<T>(handle.AddrOfPinnedObject());

                if (crc32 != null)
                    crc32.Append(m_temp);

                handle.Free();
            }

            return items;
        }
        public static void WriteStruct<T>(this Stream m_stream, T value, Crc32Algorithm crc32 = null) where T : struct
        {
            var m_temp = new byte[Marshal.SizeOf<T>()];
            var handle = GCHandle.Alloc(m_temp, GCHandleType.Pinned);

            Marshal.StructureToPtr(value, handle.AddrOfPinnedObject(), true);
            m_stream.Write(m_temp, 0, m_temp.Length);

            if (crc32 != null)
                crc32.Append(m_temp);

            handle.Free();
        }
        public static void WriteStructs<T>(this Stream m_stream, T[] array, Crc32Algorithm crc32 = null) where T : struct
        {
            var size = Marshal.SizeOf<T>();
            var m_temp = new byte[size];
            for (int i = 0; i < array.Length; i++)
            {
                var handle = GCHandle.Alloc(m_temp, GCHandleType.Pinned);

                Marshal.StructureToPtr(array[i], handle.AddrOfPinnedObject(), true);
                m_stream.Write(m_temp, 0, m_temp.Length);

                if (crc32 != null)
                    crc32.Append(m_temp);

                handle.Free();
            }
        }
    }
}