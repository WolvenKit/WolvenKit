using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CMoveSTMoveWithOffset : CMoveSTRotate
	{
		[RED("headingImportance")] 		public CFloat HeadingImportance { get; set;}

		[RED("speedImportance")] 		public CFloat SpeedImportance { get; set;}

		[RED("offset")] 		public CFloat Offset { get; set;}

		public CMoveSTMoveWithOffset(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CMoveSTMoveWithOffset(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}