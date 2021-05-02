using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class SBehaviorGraphMapToDiscreteMapper : CVariable
	{
		[Ordinal(1)] [RED("Min input value")] 		public CFloat Min_input_value { get; set;}

		[Ordinal(2)] [RED("Max input value")] 		public CFloat Max_input_value { get; set;}

		[Ordinal(3)] [RED("outValue")] 		public CFloat OutValue { get; set;}

		public SBehaviorGraphMapToDiscreteMapper(IRed3EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new SBehaviorGraphMapToDiscreteMapper(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}