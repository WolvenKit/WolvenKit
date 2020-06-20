using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class BTTaskFrostAreaAttackDef : IBehTreeTaskDefinition
	{
		[RED("spawnedEntities", 2,0)] 		public CArray<CName> SpawnedEntities { get; set;}

		[RED("duration")] 		public SRangeF Duration { get; set;}

		[RED("spreadingSpeed")] 		public CFloat SpreadingSpeed { get; set;}

		[RED("maxRadius")] 		public CFloat MaxRadius { get; set;}

		[RED("spawnAtOnce")] 		public SRange SpawnAtOnce { get; set;}

		[RED("createArena")] 		public CBool CreateArena { get; set;}

		[RED("arenaAngle")] 		public CFloat ArenaAngle { get; set;}

		[RED("scaleSpawnQuantityWithRadius")] 		public CBool ScaleSpawnQuantityWithRadius { get; set;}

		[RED("spawnAttackDelay")] 		public SRangeF SpawnAttackDelay { get; set;}

		[RED("spawnAttackOnTargetDelay")] 		public SRangeF SpawnAttackOnTargetDelay { get; set;}

		[RED("frostWallReloadDelay")] 		public CFloat FrostWallReloadDelay { get; set;}

		public BTTaskFrostAreaAttackDef(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new BTTaskFrostAreaAttackDef(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}