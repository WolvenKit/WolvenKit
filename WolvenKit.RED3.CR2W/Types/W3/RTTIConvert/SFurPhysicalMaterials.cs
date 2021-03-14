using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class SFurPhysicalMaterials : CVariable
	{
		[Ordinal(1)] [RED("simulation")] 		public SFurSimulation Simulation { get; set;}

		[Ordinal(2)] [RED("volume")] 		public SFurVolume Volume { get; set;}

		[Ordinal(3)] [RED("strandWidth")] 		public SFurStrandWidth StrandWidth { get; set;}

		[Ordinal(4)] [RED("stiffness")] 		public SFurStiffness Stiffness { get; set;}

		[Ordinal(5)] [RED("clumping")] 		public SFurClumping Clumping { get; set;}

		[Ordinal(6)] [RED("waveness")] 		public SFurWaveness Waveness { get; set;}

		public SFurPhysicalMaterials(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new SFurPhysicalMaterials(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}