using System.Collections.Generic;
using System.IO;
using WolvenKit.Common.Model.Cr2w;
using System.Diagnostics;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;
using FastMember;

namespace WolvenKit.CR2W.Types
{
    [REDMeta(EREDMetaInfo.REDStruct)]
    public class CurveInfo : CVariable
    {
        [Ordinal(1)] [RED] public CName someName { get; set; }
        [Ordinal(2)] [RED] public CUInt8 someByte { get; set; }

        [Ordinal(3)] [RED] public CCompressedBuffer<CurvePiece> pieces { get; set; } // MAX LIMIT 4

        public CurveInfo(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name)
        {
            someName = new CName(cr2w, this, nameof(someName)) { IsSerialized = true };
            someByte = new CUInt8(cr2w, this, nameof(someByte)) { IsSerialized = true };
            pieces = new CCompressedBuffer<CurvePiece>(cr2w, this, nameof(pieces)) { IsSerialized = true };
        }

        public override CVariable Copy(ICR2WCopyAction context)
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

            pieces.Read(file, size, count);

            
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

            pieces.Write(file);
        }
    }

}