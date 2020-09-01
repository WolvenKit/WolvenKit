using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CGrassCellMask : CVariable
	{
		[Ordinal(1)] [RED("("srtFileName")] 		public CString SrtFileName { get; set;}

		[Ordinal(2)] [RED("("firstRow")] 		public CInt32 FirstRow { get; set;}

		[Ordinal(3)] [RED("("lastRow")] 		public CInt32 LastRow { get; set;}

		[Ordinal(4)] [RED("("firstCol")] 		public CInt32 FirstCol { get; set;}

		[Ordinal(5)] [RED("("lastCol")] 		public CInt32 LastCol { get; set;}

		[Ordinal(6)] [RED("("cellSize")] 		public CFloat CellSize { get; set;}

		[Ordinal(7)] [RED("("bitmap")] 		public LongBitField Bitmap { get; set;}

		public CGrassCellMask(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CGrassCellMask(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}