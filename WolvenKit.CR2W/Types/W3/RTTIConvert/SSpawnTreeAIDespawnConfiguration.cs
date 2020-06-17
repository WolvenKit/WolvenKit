using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class SSpawnTreeAIDespawnConfiguration : CVariable
	{
		[RED("canDespawnOnSight")] 		public CBool CanDespawnOnSight { get; set;}

		[RED("minDespawnRange")] 		public CFloat MinDespawnRange { get; set;}

		[RED("maxDespawnRange")] 		public CFloat MaxDespawnRange { get; set;}

		[RED("forceDespawnRange")] 		public CFloat ForceDespawnRange { get; set;}

		[RED("despawnDelayMin")] 		public CFloat DespawnDelayMin { get; set;}

		[RED("despawnDelayMax")] 		public CFloat DespawnDelayMax { get; set;}

		[RED("despawnTime")] 		public CFloat DespawnTime { get; set;}

		public SSpawnTreeAIDespawnConfiguration(CR2WFile cr2w) : base(cr2w){ }

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

		public override CVariable Create(CR2WFile cr2w) => new SSpawnTreeAIDespawnConfiguration(cr2w);

	}
}