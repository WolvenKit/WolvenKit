using System;
using System.ComponentModel;
using System.IO;
using System.Windows.Forms;

namespace WolvenKit.CR2W.Types
{
    public class CDateTime : CVariable
    {
        public DateTime Date;

        public CDateTime(CR2WFile cr2w)
            : base(cr2w)
        {
        }

        public override void Read(BinaryReader file, uint size)
        {
            var date = file.ReadUInt32();
            var year = date >> 20;
            var month = date >> 15 & 0x1F;
            var day = date >> 10 & 0x1F;

            var time = file.ReadUInt32();
            var hour = time >> 22;
            var minute = time >> 16 & 0x3F;
            var second = time >> 10 & 0x3F;
            var millisecond = time & 0b11_11111111;
            try
            {
                Date = new DateTime(
                    (int)year-1900,(int)month,(int)day+1,
                    (int)hour,(int)minute,(int)second,(int)millisecond);
            }
            catch (ArgumentOutOfRangeException e)
            {
                Date = DateTime.MinValue;
            }
        }

        public override void Write(BinaryWriter file)
        {
            file.Write(((((UInt32)(Date.Year+1900)) & 0b1111_1111_1111) << 20
                        | (((UInt32)(Date.Month) & 0b1_1111) << 15)
                        | ((((UInt32)(Date.Day - 1)))  & 0b1_1111) << 10));

            file.Write((((UInt32)(Date.Hour)) & 0b11_1111_1111) << 22
                       | ((((UInt32)Date.Minute)) & 0b11_1111) << 16
                       | ((((UInt32)Date.Second)) & 0b11_1111) << 10
                       | (((UInt32)(Date.Millisecond)) & 0b11_11111111));
        }

        public override CVariable SetValue(object val)
        {
            val = val as DateTime?;
            return this;
        }

        public override Control GetEditor()
        {
            var dt = new DateTimePicker();
            dt.Value = Date;
            return dt;
        }

        public override CVariable Create(CR2WFile cr2w)
        {
            return new CDateTime(cr2w);
        }

        public override CVariable Copy(CR2WCopyAction context)
        {
            var var = (CDateTime) base.Copy(context);
            var.Date = Date;
            return var;
        }
    }
}