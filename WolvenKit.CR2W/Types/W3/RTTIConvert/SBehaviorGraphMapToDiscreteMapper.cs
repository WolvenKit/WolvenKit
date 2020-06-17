using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class SBehaviorGraphMapToDiscreteMapper : CVariable
	{
		[RED("Min input value")] 		public CFloat Min_input_value { get; set;}

		[RED("Max input value")] 		public CFloat Max_input_value { get; set;}

		[RED("outValue")] 		public CFloat OutValue { get; set;}

		public SBehaviorGraphMapToDiscreteMapper(CR2WFile cr2w) : base(cr2w){ }

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

		public override CVariable Create(CR2WFile cr2w) => new SBehaviorGraphMapToDiscreteMapper(cr2w);

	}
}