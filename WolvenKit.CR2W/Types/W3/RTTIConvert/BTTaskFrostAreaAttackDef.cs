using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class BTTaskFrostAreaAttackDef : IBehTreeTaskDefinition
	{
		[Ordinal(1)] [RED("spawnedEntities", 2,0)] 		public CArray<CName> SpawnedEntities { get; set;}

		[Ordinal(2)] [RED("duration")] 		public SRangeF Duration { get; set;}

		[Ordinal(3)] [RED("spreadingSpeed")] 		public CFloat SpreadingSpeed { get; set;}

		[Ordinal(4)] [RED("maxRadius")] 		public CFloat MaxRadius { get; set;}

		[Ordinal(5)] [RED("spawnAtOnce")] 		public SRange SpawnAtOnce { get; set;}

		[Ordinal(6)] [RED("createArena")] 		public CBool CreateArena { get; set;}

		[Ordinal(7)] [RED("arenaAngle")] 		public CFloat ArenaAngle { get; set;}

		[Ordinal(8)] [RED("scaleSpawnQuantityWithRadius")] 		public CBool ScaleSpawnQuantityWithRadius { get; set;}

		[Ordinal(9)] [RED("spawnAttackDelay")] 		public SRangeF SpawnAttackDelay { get; set;}

		[Ordinal(10)] [RED("spawnAttackOnTargetDelay")] 		public SRangeF SpawnAttackOnTargetDelay { get; set;}

		[Ordinal(11)] [RED("frostWallReloadDelay")] 		public CFloat FrostWallReloadDelay { get; set;}

		public BTTaskFrostAreaAttackDef(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new BTTaskFrostAreaAttackDef(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}