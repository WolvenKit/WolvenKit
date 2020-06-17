using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class BTCondWaterDepthDef : IBehTreeConditionalTaskDefinition
	{
		[RED("checkedActor")] 		public EStatOwner CheckedActor { get; set;}

		[RED("value")] 		public CFloat Value { get; set;}

		[RED("operator")] 		public EOperator Operator { get; set;}

		[RED("frontalOffset")] 		public CFloat FrontalOffset { get; set;}

		public BTCondWaterDepthDef(CR2WFile cr2w) : base(cr2w){ }

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

		public override CVariable Create(CR2WFile cr2w) => new BTCondWaterDepthDef(cr2w);

	}
}