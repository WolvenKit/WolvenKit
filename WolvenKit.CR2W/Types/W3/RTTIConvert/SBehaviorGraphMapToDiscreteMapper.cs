using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class SBehaviorGraphMapToDiscreteMapper : CVariable
	{
		[Ordinal(0)] [RED("("Min input value")] 		public CFloat Min_input_value { get; set;}

		[Ordinal(0)] [RED("("Max input value")] 		public CFloat Max_input_value { get; set;}

		[Ordinal(0)] [RED("("outValue")] 		public CFloat OutValue { get; set;}

		public SBehaviorGraphMapToDiscreteMapper(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new SBehaviorGraphMapToDiscreteMapper(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}