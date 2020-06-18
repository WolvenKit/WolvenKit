using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using WolvenKit.CR2W.Editors;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
    [DataContract(Namespace = "")]
    [REDMeta]
    public class CEvaluatorFloatCurve : IEvaluatorFloat
    {
        [REDBuffer] public CurveInfo curveInfo { get; set; }

        public CEvaluatorFloatCurve(CR2WFile cr2w) : base(cr2w)
        {
        }


        public override CVariable Create(CR2WFile cr2w)
        {
            return new CEvaluatorFloatCurve(cr2w);
        }

        public override void Read(BinaryReader file, uint size)
        {
            base.Read(file, size);
        }

        public override void Write(BinaryWriter file)
        {
            base.Write(file);
        }




        [REDMeta(EREDMetaInfo.REDStruct)]
        public class CurveInfo : CVariable
        {
            [RED] public CName someName { get; set; }
            [RED] public CUInt8 someByte { get; set; }
            public List<CurvePiece> pieces; // MAX LIMIT 4

            public CurveInfo(CR2WFile cr2w) : base(cr2w)
            {
                someName = new CName(cr2w) { Name = "someName",  };
                someByte = new CUInt8(cr2w) { Name = "someByte", };
                pieces = new List<CurvePiece>();
            }

            public override CVariable Copy(CR2WCopyAction context)
            {
                var copy = base.Copy(context) as CurveInfo;
                copy.someName = someName.Copy(context) as CName;
                copy.someByte = someByte.Copy(context) as CUInt8;

                foreach (var piece in pieces)
                {
                    copy.pieces.Add(piece.Copy(context) as CurvePiece);
                }

                return copy;
            }

            public override CVariable Create(CR2WFile cr2w)
            {
                return new CurveInfo(cr2w);
            }

            public override void Read(BinaryReader file, uint size)
            {
                someName.Read(file, size);

                byte count = file.ReadByte();

                if (count > 4)
                {
                    Debug.Print("Curve piece count out of bounds: " + count + ", using as 4");
                    count = 4;
                }

                someByte.Read(file, size);

                for (int i = 0; i < count; i++)
                {
                    var piece = new CurvePiece(cr2w) { Name = i.ToString()};
                    piece.Read(file, size);
                    pieces.Add(piece);
                }
            }

            public override void Write(BinaryWriter file)
            {
                byte pieceCount = (byte)pieces.Count;

                if (pieceCount > 4)
                {
                    Debug.Print("Cannot write more than 4 pieces (" + pieceCount + ") for curve info, limiting");
                    pieceCount = 4;
                }

                someName.Write(file);
                file.Write(pieceCount);
                someByte.Write(file);

                for (var i = 0; i < pieceCount; i++)
                {
                    pieces[i].Write(file);
                }
            }
        }




        [REDMeta(EREDMetaInfo.REDStruct)]
        public class CurvePiece : CVariable
        {
            [RED] public CUInt16 valueCount { get; set; }
            [RED] public CFloat[] values { get; set; }

            public CurvePiece(CR2WFile cr2w) : base(cr2w)
            {
                // This has a fixed size in memory, but for some reason file format is allowed to not provide all,
                // leaving the rest to zero values. Possibly has individual fields instead of an array.
                values = new CFloat[16];
                valueCount = new CUInt16(cr2w) { Name = "count",  val = (ushort)values.Length };

                for (var i = 0; i < values.Length; i++)
                {
                    values[i] = new CFloat(cr2w) { Name = i.ToString(), };
                }
            }

            public override CVariable Copy(CR2WCopyAction context)
            {
                var copy = base.Copy(context) as CurvePiece;
                copy.valueCount = valueCount.Copy(context) as CUInt16;

                for (var i = 0; i < values.Length; i++)
                {
                    copy.values[i] = values[i].Copy(context) as CFloat;
                }

                return copy;
            }

            public override CVariable Create(CR2WFile cr2w)
            {
                return new CurvePiece(cr2w);
            }

            public override void Read(BinaryReader file, uint size)
            {
                valueCount.Read(file, size);

                if (valueCount.val > values.Length)
                {
                    Debug.Print("Read: curve piece value count " + valueCount.val + " exceeds limit " + values.Length);
                }

                for (int i = 0; i < Math.Min(valueCount.val, values.Length); i++)
                {
                    values[i].Read(file, size);
                }
            }

            public override void Write(BinaryWriter file)
            {
                ushort writtenCount = Math.Min(valueCount.val, (ushort)values.Length);

                if (writtenCount != valueCount.val)
                {
                    Debug.Print("Write: curve piece value count " + valueCount.val + " exceeds limit " + values.Length);
                }

                file.Write(writtenCount);

                for (var i = 0; i < writtenCount; i++)
                {
                    values[i].Write(file);
                }
            }
        }
    }
}