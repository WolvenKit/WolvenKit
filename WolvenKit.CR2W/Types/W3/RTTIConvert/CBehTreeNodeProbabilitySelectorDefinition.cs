using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBehTreeNodeProbabilitySelectorDefinition : IBehTreeNodeCompositeDefinition
	{
		[RED("testAvailability")] 		public CBool TestAvailability { get; set;}

		[RED("probability0")] 		public CUInt8 Probability0 { get; set;}

		[RED("probability1")] 		public CUInt8 Probability1 { get; set;}

		[RED("probability2")] 		public CUInt8 Probability2 { get; set;}

		[RED("probability3")] 		public CUInt8 Probability3 { get; set;}

		[RED("probability4")] 		public CUInt8 Probability4 { get; set;}

		[RED("probability5")] 		public CUInt8 Probability5 { get; set;}

		public CBehTreeNodeProbabilitySelectorDefinition(CR2WFile cr2w) : base(cr2w){ }

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

		public override CVariable Create(CR2WFile cr2w) => new CBehTreeNodeProbabilitySelectorDefinition(cr2w);

	}
}