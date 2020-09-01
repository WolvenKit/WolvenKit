using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class BTTaskFrostSnakeAttack : CBTTaskAttack
	{
		[Ordinal(0)] [RED("useActionTarget")] 		public CBool UseActionTarget { get; set;}

		[Ordinal(0)] [RED("spawnedEntityTemplates", 2,0)] 		public CArray<CHandle<CEntityTemplate>> SpawnedEntityTemplates { get; set;}

		[Ordinal(0)] [RED("duration")] 		public SRangeF Duration { get; set;}

		[Ordinal(0)] [RED("clampDurationWhenTargetReached")] 		public CFloat ClampDurationWhenTargetReached { get; set;}

		[Ordinal(0)] [RED("speed")] 		public CFloat Speed { get; set;}

		[Ordinal(0)] [RED("radius")] 		public CFloat Radius { get; set;}

		[Ordinal(0)] [RED("spawnAtOnce")] 		public SRange SpawnAtOnce { get; set;}

		[Ordinal(0)] [RED("spawnAttackDelay")] 		public SRangeF SpawnAttackDelay { get; set;}

		[Ordinal(0)] [RED("maxDistance")] 		public CFloat MaxDistance { get; set;}

		[Ordinal(0)] [RED("abortAttackOnTargetReached")] 		public CBool AbortAttackOnTargetReached { get; set;}

		[Ordinal(0)] [RED("ThreeStateAttack")] 		public CBool ThreeStateAttack { get; set;}

		[Ordinal(0)] [RED("loopHeadFX")] 		public CBool LoopHeadFX { get; set;}

		[Ordinal(0)] [RED("waitForAnimEventToSummon")] 		public CName WaitForAnimEventToSummon { get; set;}

		[Ordinal(0)] [RED("snakeHeadTemplate")] 		public CHandle<CEntityTemplate> SnakeHeadTemplate { get; set;}

		[Ordinal(0)] [RED("playEffectOnOwner")] 		public CName PlayEffectOnOwner { get; set;}

		[Ordinal(0)] [RED("additionalSnakeHeadFXName")] 		public CName AdditionalSnakeHeadFXName { get; set;}

		[Ordinal(0)] [RED("destroyEffectDelay")] 		public CFloat DestroyEffectDelay { get; set;}

		[Ordinal(0)] [RED("canTriggerFrenzySlowmo")] 		public CBool CanTriggerFrenzySlowmo { get; set;}

		[Ordinal(0)] [RED("m_Npc")] 		public CHandle<CNewNPC> M_Npc { get; set;}

		[Ordinal(0)] [RED("m_SnakeHead")] 		public CHandle<CEntity> M_SnakeHead { get; set;}

		[Ordinal(0)] [RED("m_SnakeHeadPos")] 		public Vector M_SnakeHeadPos { get; set;}

		[Ordinal(0)] [RED("m_LastSnakeHeadPos")] 		public Vector M_LastSnakeHeadPos { get; set;}

		[Ordinal(0)] [RED("m_effectDummyComp")] 		public CHandle<CEffectDummyComponent> M_effectDummyComp { get; set;}

		[Ordinal(0)] [RED("m_PlayEffect")] 		public CBool M_PlayEffect { get; set;}

		[Ordinal(0)] [RED("m_CanStartSummon")] 		public CBool M_CanStartSummon { get; set;}

		public BTTaskFrostSnakeAttack(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new BTTaskFrostSnakeAttack(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}