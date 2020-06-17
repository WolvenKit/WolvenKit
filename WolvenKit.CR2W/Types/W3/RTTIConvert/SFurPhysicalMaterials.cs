using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class SFurPhysicalMaterials : CVariable
	{
		[RED("simulation")] 		public SFurSimulation Simulation { get; set;}

		[RED("volume")] 		public SFurVolume Volume { get; set;}

		[RED("strandWidth")] 		public SFurStrandWidth StrandWidth { get; set;}

		[RED("stiffness")] 		public SFurStiffness Stiffness { get; set;}

		[RED("clumping")] 		public SFurClumping Clumping { get; set;}

		[RED("waveness")] 		public SFurWaveness Waveness { get; set;}

		public SFurPhysicalMaterials(CR2WFile cr2w) : base(cr2w){ }

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

		public override CVariable Create(CR2WFile cr2w) => new SFurPhysicalMaterials(cr2w);

	}
}