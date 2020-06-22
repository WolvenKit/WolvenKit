using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class BTTaskFrostAreaAttack : IBehTreeTask
	{
		[RED("duration")] 		public SRangeF Duration { get; set;}

		[RED("spreadingSpeed")] 		public CFloat SpreadingSpeed { get; set;}

		[RED("maxRadius")] 		public CFloat MaxRadius { get; set;}

		[RED("spawnAtOnce")] 		public SRange SpawnAtOnce { get; set;}

		[RED("createArena")] 		public CBool CreateArena { get; set;}

		[RED("arenaAngle")] 		public CFloat ArenaAngle { get; set;}

		[RED("scaleSpawnQuantityWithRadius")] 		public CBool ScaleSpawnQuantityWithRadius { get; set;}

		[RED("spawnAttackDelay")] 		public SRangeF SpawnAttackDelay { get; set;}

		[RED("spawnAttackOnTargetDelay")] 		public SRangeF SpawnAttackOnTargetDelay { get; set;}

		[RED("spawnedEntityTemplates", 2,0)] 		public CArray<CHandle<CEntityTemplate>> SpawnedEntityTemplates { get; set;}

		[RED("frostWallReloadDelay")] 		public CFloat FrostWallReloadDelay { get; set;}

		[RED("m_Npc")] 		public CHandle<CNewNPC> M_Npc { get; set;}

		[RED("m_MinAttackRange")] 		public CFloat M_MinAttackRange { get; set;}

		[RED("m_FrostRange")] 		public CFloat M_FrostRange { get; set;}

		[RED("m_TimeToAttackOnTarget")] 		public CFloat M_TimeToAttackOnTarget { get; set;}

		[RED("m_PostFxOnGroundCmp")] 		public CHandle<W3PostFXOnGroundComponent> M_PostFxOnGroundCmp { get; set;}

		public BTTaskFrostAreaAttack(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new BTTaskFrostAreaAttack(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}