using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CMoveSTMoveWithOffset : CMoveSTRotate
	{
		[Ordinal(1)] [RED("headingImportance")] 		public CFloat HeadingImportance { get; set;}

		[Ordinal(2)] [RED("speedImportance")] 		public CFloat SpeedImportance { get; set;}

		[Ordinal(3)] [RED("offset")] 		public CFloat Offset { get; set;}

		public CMoveSTMoveWithOffset(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CMoveSTMoveWithOffset(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}