using System;
using System.IO;

namespace WolvenKit.Wwise.Wwise
{
    class FileManage
    {
    }
    // completed
    public class FileRead
    {
        public string _path;
        public string _name;
        public long _size;
        public BinaryReader _file;

        public FileRead(string fileName)
        {
            _path = fileName;

            _file = new BinaryReader(new FileStream(fileName, FileMode.Open));
            _name = fileName;
            FileInfo fi = new FileInfo(fileName);
            _size = fi.Length;
        }
        ~FileRead()
        {
            if (_file != null)
            {
                _file.Close();
            }
        }

        public bool read_bool()
        {
            return (_file.ReadByte() == 1);
        }

        public byte read_one_byte()
        {
            return _file.ReadByte();
        }
        public string read_uchar(uint size = 0)
        {
            if (size == 0)
            {
                byte[] t = new byte[1];
                return _file.ReadBytes(1).ToString();
            }
            else
            {
                // need to check 
                byte[] t = new byte[size];
                var bt = _file.ReadBytes((int)size);

                return System.Text.Encoding.Default.GetString(bt);
            }
        }

        public string read_header()
        {
            //_file.BaseStream.Seek(0, SeekOrigin.Begin);
            var bt = _file.ReadBytes(4);

            return System.Text.Encoding.Default.GetString(bt);
        }

        // this funciton is not used
        public string read_until(string end)
        {
            string data = "";
            while (_file.BaseStream.Position != _file.BaseStream.Length)
            {
                data += read_uchar(1);
                if (data.EndsWith(end))
                {
                    return data;
                }
            }
            Console.WriteLine(end + " was not found --EOF");
            return "";
        }

        public string read_data()
        {
            return _file.ReadString();
        }

        public void seekPosition(long offset, int whence = 0)
        {
            if (whence == 0)
            {
                _file.BaseStream.Seek(offset, SeekOrigin.Begin);
            }
            else if (whence == 1)
            {
                _file.BaseStream.Seek(offset, SeekOrigin.Current);
            }
            else if (whence == 2)
            {
                _file.BaseStream.Seek(offset, SeekOrigin.End);
            }

        }

        public long getPosition()
        {
            return _file.BaseStream.Position;
        }
        public ushort read_uint16()
        {
            return _file.ReadUInt16();
        }
        public short read_int16()
        {
            return _file.ReadInt16();
        }
        public uint read_uint32()
        {
            return _file.ReadUInt32();
        }
        public int read_int32()
        {
            return _file.ReadInt32();
        }
        public float read_float()
        {
            return _file.ReadSingle();
        }
        public ulong read_uint64()
        {
            return _file.ReadUInt64();
        }
        public long read_int64()
        {
            return _file.ReadInt64();
        }
        public double read_double()
        {
            return _file.ReadDouble();
        }

        public void closeFile()
        {
            _file.Close();
        }

    }
    // completed
    public class FileWrite
    {
        public BinaryWriter _file;
        public string _path;
        public FileWrite(string fileName, bool isBuffer = false, string mode = "wb")
        {
            if (!isBuffer)
            {
                _file = new BinaryWriter(new FileStream(fileName, FileMode.OpenOrCreate, FileAccess.Write));
                _path = fileName;

            }
            else
            {
                _path = "";
            }
        }
        ~FileWrite()
        {
            if (_file != null)
            {
                _file.Close();
            }
        }

        public void seekPosition(int offset, int whence = 0)
        {
            if (whence == 0)
            {
                _file.BaseStream.Seek(offset, SeekOrigin.Begin);
            }
            else if (whence == 1)
            {
                _file.BaseStream.Seek(offset, SeekOrigin.Current);
            }
            else if (whence == 2)
            {
                _file.BaseStream.Seek(offset, SeekOrigin.End);
            }

        }

        public long getPosition()
        {
            return _file.BaseStream.Position;
        }
    }

}
