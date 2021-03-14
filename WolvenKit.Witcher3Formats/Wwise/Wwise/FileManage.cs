using System;
using System.IO;

namespace WolvenKit.Wwise.Wwise
{
    public class FileRead
    {
        #region Fields

        public BinaryReader _file;
        public string _name;
        public string _path;
        public long _size;

        #endregion Fields

        #region Constructors

        public FileRead(string fileName)
        {
            _path = fileName;

            _file = new BinaryReader(new FileStream(fileName, FileMode.Open));
            _name = fileName;
            FileInfo fi = new FileInfo(fileName);
            _size = fi.Length;
        }

        #endregion Constructors

        #region Destructors

        ~FileRead()
        {
            if (_file != null)
            {
                _file.Close();
            }
        }

        #endregion Destructors

        #region Methods

        public void closeFile()
        {
            _file.Close();
        }

        public long getPosition()
        {
            return _file.BaseStream.Position;
        }

        public bool read_bool()
        {
            return (_file.ReadByte() == 1);
        }

        public string read_data()
        {
            return _file.ReadString();
        }

        public double read_double()
        {
            return _file.ReadDouble();
        }

        public float read_float()
        {
            return _file.ReadSingle();
        }

        public string read_header()
        {
            //_file.BaseStream.Seek(0, SeekOrigin.Begin);
            var bt = _file.ReadBytes(4);

            return System.Text.Encoding.Default.GetString(bt);
        }

        public short read_int16()
        {
            return _file.ReadInt16();
        }

        public int read_int32()
        {
            return _file.ReadInt32();
        }

        public long read_int64()
        {
            return _file.ReadInt64();
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

        public ushort read_uint16()
        {
            return _file.ReadUInt16();
        }

        public uint read_uint32()
        {
            return _file.ReadUInt32();
        }

        public ulong read_uint64()
        {
            return _file.ReadUInt64();
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

        #endregion Methods
    }

    public class FileWrite
    {
        #region Fields

        public BinaryWriter _file;
        public string _path;

        #endregion Fields

        #region Constructors

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

        public FileWrite(Stream s)
        {
            _file = new BinaryWriter(s);
            _path = "";
        }

        #endregion Constructors

        #region Destructors

        ~FileWrite()
        {
            if (_file != null)
            {
                _file.Close();
            }
        }

        #endregion Destructors

        #region Methods

        public long getPosition()
        {
            return _file.BaseStream.Position;
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

        #endregion Methods
    }

    internal class FileManage
    {
    }
}
