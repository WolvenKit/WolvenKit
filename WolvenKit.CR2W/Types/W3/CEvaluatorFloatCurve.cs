using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using WolvenKit.CR2W.Editors;

namespace WolvenKit.CR2W.Types
{
    [DataContract(Namespace = "")]
    class CEvaluatorFloatCurve : CVector
    {
        public CurveInfo curveInfo;

        public CEvaluatorFloatCurve(CR2WFile cr2w) : base(cr2w)
        {
            curveInfo = new CurveInfo(cr2w) { Name = "curveInfo", Type = "CurveInfo" };
        }

        public override CVariable Copy(CR2WCopyAction context)
        {
            var copy = base.Copy(context) as CEvaluatorFloatCurve;
            copy.curveInfo = curveInfo.Copy(context) as CurveInfo;
            return copy;
        }

        public override CVariable Create(CR2WFile cr2w)
        {
            return new CEvaluatorFloatCurve(cr2w);
        }

        public override List<IEditableVariable> GetEditableVariables()
        {
            return new List<IEditableVariable>(variables)
            {
                curveInfo
            };
        }

        public override void Read(BinaryReader file, uint size)
        {
            base.Read(file, size);
            curveInfo.Read(file, size);
        }

        public override void Write(BinaryWriter file)
        {
            base.Write(file);
            curveInfo.Write(file);
        }

        [DataContract(Namespace = "")]
        public class CurveInfo : CVariable
        {
            public CName someName;
            public CUInt8 someByte;
            public List<CurvePiece> pieces; // MAX LIMIT 4

            public CurveInfo(CR2WFile cr2w) : base(cr2w)
            {
                someName = new CName(cr2w) { Name = "someName", Type = "CName" };
                someByte = new CUInt8(cr2w) { Name = "someByte", Type = "CUInt8" };
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

            public override List<IEditableVariable> GetEditableVariables()
            {
                var editables = new List<IEditableVariable>()
                {
                    someName,
                    someByte
                };

                editables.AddRange(pieces);
                return editables;
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
                    var piece = new CurvePiece(cr2w) { Name = i.ToString(), Type = "CurvePiece" };
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

        [DataContract(Namespace = "")]
        public class CurvePiece : CVariable
        {
            public CUInt16 valueCount;
            public CFloat[] values;

            public CurvePiece(CR2WFile cr2w) : base(cr2w)
            {
                // This has a fixed size in memory, but for some reason file format is allowed to not provide all,
                // leaving the rest to zero values. Possibly has individual fields instead of an array.
                values = new CFloat[16];
                valueCount = new CUInt16(cr2w) { Name = "count", Type = "CUInt16", val = (ushort)values.Length };

                for (var i = 0; i < values.Length; i++)
                {
                    values[i] = new CFloat(cr2w) { Name = i.ToString(), Type = "CFloat" };
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

            public override List<IEditableVariable> GetEditableVariables()
            {
                var editables = new List<IEditableVariable>
                {
                    valueCount
                };

                editables.AddRange(values);
                return editables;
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