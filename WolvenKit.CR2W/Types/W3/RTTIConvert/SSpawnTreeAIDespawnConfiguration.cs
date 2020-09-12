using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class SSpawnTreeAIDespawnConfiguration : CVariable
	{
		[Ordinal(1)] [RED("canDespawnOnSight")] 		public CBool CanDespawnOnSight { get; set;}

		[Ordinal(2)] [RED("minDespawnRange")] 		public CFloat MinDespawnRange { get; set;}

		[Ordinal(3)] [RED("maxDespawnRange")] 		public CFloat MaxDespawnRange { get; set;}

		[Ordinal(4)] [RED("forceDespawnRange")] 		public CFloat ForceDespawnRange { get; set;}

		[Ordinal(5)] [RED("despawnDelayMin")] 		public CFloat DespawnDelayMin { get; set;}

		[Ordinal(6)] [RED("despawnDelayMax")] 		public CFloat DespawnDelayMax { get; set;}

		[Ordinal(7)] [RED("despawnTime")] 		public CFloat DespawnTime { get; set;}

		public SSpawnTreeAIDespawnConfiguration(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new SSpawnTreeAIDespawnConfiguration(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}