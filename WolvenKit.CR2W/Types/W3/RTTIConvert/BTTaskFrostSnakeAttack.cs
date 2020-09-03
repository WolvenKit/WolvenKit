using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class BTTaskFrostSnakeAttack : CBTTaskAttack
	{
		[Ordinal(1)] [RED("useActionTarget")] 		public CBool UseActionTarget { get; set;}

		[Ordinal(2)] [RED("spawnedEntityTemplates", 2,0)] 		public CArray<CHandle<CEntityTemplate>> SpawnedEntityTemplates { get; set;}

		[Ordinal(3)] [RED("duration")] 		public SRangeF Duration { get; set;}

		[Ordinal(4)] [RED("clampDurationWhenTargetReached")] 		public CFloat ClampDurationWhenTargetReached { get; set;}

		[Ordinal(5)] [RED("speed")] 		public CFloat Speed { get; set;}

		[Ordinal(6)] [RED("radius")] 		public CFloat Radius { get; set;}

		[Ordinal(7)] [RED("spawnAtOnce")] 		public SRange SpawnAtOnce { get; set;}

		[Ordinal(8)] [RED("spawnAttackDelay")] 		public SRangeF SpawnAttackDelay { get; set;}

		[Ordinal(9)] [RED("maxDistance")] 		public CFloat MaxDistance { get; set;}

		[Ordinal(10)] [RED("abortAttackOnTargetReached")] 		public CBool AbortAttackOnTargetReached { get; set;}

		[Ordinal(11)] [RED("ThreeStateAttack")] 		public CBool ThreeStateAttack { get; set;}

		[Ordinal(12)] [RED("loopHeadFX")] 		public CBool LoopHeadFX { get; set;}

		[Ordinal(13)] [RED("waitForAnimEventToSummon")] 		public CName WaitForAnimEventToSummon { get; set;}

		[Ordinal(14)] [RED("snakeHeadTemplate")] 		public CHandle<CEntityTemplate> SnakeHeadTemplate { get; set;}

		[Ordinal(15)] [RED("playEffectOnOwner")] 		public CName PlayEffectOnOwner { get; set;}

		[Ordinal(16)] [RED("additionalSnakeHeadFXName")] 		public CName AdditionalSnakeHeadFXName { get; set;}

		[Ordinal(17)] [RED("destroyEffectDelay")] 		public CFloat DestroyEffectDelay { get; set;}

		[Ordinal(18)] [RED("canTriggerFrenzySlowmo")] 		public CBool CanTriggerFrenzySlowmo { get; set;}

		[Ordinal(19)] [RED("m_Npc")] 		public CHandle<CNewNPC> M_Npc { get; set;}

		[Ordinal(20)] [RED("m_SnakeHead")] 		public CHandle<CEntity> M_SnakeHead { get; set;}

		[Ordinal(21)] [RED("m_SnakeHeadPos")] 		public Vector M_SnakeHeadPos { get; set;}

		[Ordinal(22)] [RED("m_LastSnakeHeadPos")] 		public Vector M_LastSnakeHeadPos { get; set;}

		[Ordinal(23)] [RED("m_effectDummyComp")] 		public CHandle<CEffectDummyComponent> M_effectDummyComp { get; set;}

		[Ordinal(24)] [RED("m_PlayEffect")] 		public CBool M_PlayEffect { get; set;}

		[Ordinal(25)] [RED("m_CanStartSummon")] 		public CBool M_CanStartSummon { get; set;}

		public BTTaskFrostSnakeAttack(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new BTTaskFrostSnakeAttack(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}