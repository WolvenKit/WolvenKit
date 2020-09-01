using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class SFurPhysicalMaterials : CVariable
	{
		[Ordinal(0)] [RED("("simulation")] 		public SFurSimulation Simulation { get; set;}

		[Ordinal(0)] [RED("("volume")] 		public SFurVolume Volume { get; set;}

		[Ordinal(0)] [RED("("strandWidth")] 		public SFurStrandWidth StrandWidth { get; set;}

		[Ordinal(0)] [RED("("stiffness")] 		public SFurStiffness Stiffness { get; set;}

		[Ordinal(0)] [RED("("clumping")] 		public SFurClumping Clumping { get; set;}

		[Ordinal(0)] [RED("("waveness")] 		public SFurWaveness Waveness { get; set;}

		public SFurPhysicalMaterials(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new SFurPhysicalMaterials(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}