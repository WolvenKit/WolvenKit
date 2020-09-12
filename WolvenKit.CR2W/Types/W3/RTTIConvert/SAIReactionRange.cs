using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class SAIReactionRange : CVariable
	{
		[Ordinal(1)] [RED("enabled")] 		public CBool Enabled { get; set;}

		[Ordinal(2)] [RED("rangeMax")] 		public CFloat RangeMax { get; set;}

		[Ordinal(3)] [RED("rangeAngle")] 		public CFloat RangeAngle { get; set;}

		[Ordinal(4)] [RED("rangeBottom")] 		public CFloat RangeBottom { get; set;}

		[Ordinal(5)] [RED("rangeTop")] 		public CFloat RangeTop { get; set;}

		[Ordinal(6)] [RED("yaw")] 		public CFloat Yaw { get; set;}

		public SAIReactionRange(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new SAIReactionRange(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}