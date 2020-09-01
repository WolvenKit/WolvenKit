using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class BTTaskFrostSnakeAttackDef : CBTTaskAttackDef
	{
		[Ordinal(1)] [RED("useActionTarget")] 		public CBool UseActionTarget { get; set;}

		[Ordinal(2)] [RED("spawnedEntityTemplates", 2,0)] 		public CArray<CHandle<CEntityTemplate>> SpawnedEntityTemplates { get; set;}

		[Ordinal(3)] [RED("clampDurationWhenTargetReached")] 		public CBehTreeValFloat ClampDurationWhenTargetReached { get; set;}

		[Ordinal(4)] [RED("duration")] 		public SRangeF Duration { get; set;}

		[Ordinal(5)] [RED("maxDistance")] 		public CFloat MaxDistance { get; set;}

		[Ordinal(6)] [RED("speed")] 		public CFloat Speed { get; set;}

		[Ordinal(7)] [RED("radius")] 		public CFloat Radius { get; set;}

		[Ordinal(8)] [RED("spawnAtOnce")] 		public SRange SpawnAtOnce { get; set;}

		[Ordinal(9)] [RED("spawnAttackDelay")] 		public SRangeF SpawnAttackDelay { get; set;}

		[Ordinal(10)] [RED("snakeHeadTemplate")] 		public CHandle<CEntityTemplate> SnakeHeadTemplate { get; set;}

		[Ordinal(11)] [RED("additionalSnakeHeadFXName")] 		public CName AdditionalSnakeHeadFXName { get; set;}

		[Ordinal(12)] [RED("playEffectOnOwner")] 		public CName PlayEffectOnOwner { get; set;}

		[Ordinal(13)] [RED("ThreeStateAttack")] 		public CBool ThreeStateAttack { get; set;}

		[Ordinal(14)] [RED("loopHeadFX")] 		public CBool LoopHeadFX { get; set;}

		[Ordinal(15)] [RED("destroyEffectDelay")] 		public CFloat DestroyEffectDelay { get; set;}

		[Ordinal(16)] [RED("waitForAnimEventToSummon")] 		public CName WaitForAnimEventToSummon { get; set;}

		[Ordinal(17)] [RED("canTriggerFrenzySlowmo")] 		public CBool CanTriggerFrenzySlowmo { get; set;}

		public BTTaskFrostSnakeAttackDef(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new BTTaskFrostSnakeAttackDef(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}