using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBehTreeNodeProbabilitySelectorDefinition : IBehTreeNodeCompositeDefinition
	{
		[Ordinal(1)] [RED("testAvailability")] 		public CBool TestAvailability { get; set;}

		[Ordinal(2)] [RED("probability0")] 		public CUInt8 Probability0 { get; set;}

		[Ordinal(3)] [RED("probability1")] 		public CUInt8 Probability1 { get; set;}

		[Ordinal(4)] [RED("probability2")] 		public CUInt8 Probability2 { get; set;}

		[Ordinal(5)] [RED("probability3")] 		public CUInt8 Probability3 { get; set;}

		[Ordinal(6)] [RED("probability4")] 		public CUInt8 Probability4 { get; set;}

		[Ordinal(7)] [RED("probability5")] 		public CUInt8 Probability5 { get; set;}

		public CBehTreeNodeProbabilitySelectorDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CBehTreeNodeProbabilitySelectorDefinition(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}