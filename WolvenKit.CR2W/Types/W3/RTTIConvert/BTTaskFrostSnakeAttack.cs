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
		[RED("useActionTarget")] 		public CBool UseActionTarget { get; set;}

		[RED("spawnedEntityTemplates", 2,0)] 		public CArray<CHandle<CEntityTemplate>> SpawnedEntityTemplates { get; set;}

		[RED("duration")] 		public SRangeF Duration { get; set;}

		[RED("clampDurationWhenTargetReached")] 		public CFloat ClampDurationWhenTargetReached { get; set;}

		[RED("speed")] 		public CFloat Speed { get; set;}

		[RED("radius")] 		public CFloat Radius { get; set;}

		[RED("spawnAtOnce")] 		public SRange SpawnAtOnce { get; set;}

		[RED("spawnAttackDelay")] 		public SRangeF SpawnAttackDelay { get; set;}

		[RED("maxDistance")] 		public CFloat MaxDistance { get; set;}

		[RED("abortAttackOnTargetReached")] 		public CBool AbortAttackOnTargetReached { get; set;}

		[RED("ThreeStateAttack")] 		public CBool ThreeStateAttack { get; set;}

		[RED("loopHeadFX")] 		public CBool LoopHeadFX { get; set;}

		[RED("waitForAnimEventToSummon")] 		public CName WaitForAnimEventToSummon { get; set;}

		[RED("snakeHeadTemplate")] 		public CHandle<CEntityTemplate> SnakeHeadTemplate { get; set;}

		[RED("playEffectOnOwner")] 		public CName PlayEffectOnOwner { get; set;}

		[RED("additionalSnakeHeadFXName")] 		public CName AdditionalSnakeHeadFXName { get; set;}

		[RED("destroyEffectDelay")] 		public CFloat DestroyEffectDelay { get; set;}

		[RED("canTriggerFrenzySlowmo")] 		public CBool CanTriggerFrenzySlowmo { get; set;}

		[RED("m_Npc")] 		public CHandle<CNewNPC> M_Npc { get; set;}

		[RED("m_SnakeHead")] 		public CHandle<CEntity> M_SnakeHead { get; set;}

		[RED("m_SnakeHeadPos")] 		public Vector M_SnakeHeadPos { get; set;}

		[RED("m_LastSnakeHeadPos")] 		public Vector M_LastSnakeHeadPos { get; set;}

		[RED("m_effectDummyComp")] 		public CHandle<CEffectDummyComponent> M_effectDummyComp { get; set;}

		[RED("m_PlayEffect")] 		public CBool M_PlayEffect { get; set;}

		[RED("m_CanStartSummon")] 		public CBool M_CanStartSummon { get; set;}

		public BTTaskFrostSnakeAttack(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new BTTaskFrostSnakeAttack(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}