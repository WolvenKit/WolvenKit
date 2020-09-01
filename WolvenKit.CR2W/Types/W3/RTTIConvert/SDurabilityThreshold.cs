using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class SDurabilityThreshold : CVariable
	{
		[Ordinal(1)] [RED("("thresholdMax")] 		public CFloat ThresholdMax { get; set;}

		[Ordinal(2)] [RED("("multiplier")] 		public CFloat Multiplier { get; set;}

		[Ordinal(3)] [RED("("difficulty")] 		public CEnum<EDifficultyMode> Difficulty { get; set;}

		public SDurabilityThreshold(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new SDurabilityThreshold(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}