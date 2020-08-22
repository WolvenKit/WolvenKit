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
		[RED("useActionTarget")] 		public CBool UseActionTarget { get; set;}

		[RED("spawnedEntityTemplates", 2,0)] 		public CArray<CHandle<CEntityTemplate>> SpawnedEntityTemplates { get; set;}

		[RED("clampDurationWhenTargetReached")] 		public CBehTreeValFloat ClampDurationWhenTargetReached { get; set;}

		[RED("duration")] 		public SRangeF Duration { get; set;}

		[RED("maxDistance")] 		public CFloat MaxDistance { get; set;}

		[RED("speed")] 		public CFloat Speed { get; set;}

		[RED("radius")] 		public CFloat Radius { get; set;}

		[RED("spawnAtOnce")] 		public SRange SpawnAtOnce { get; set;}

		[RED("spawnAttackDelay")] 		public SRangeF SpawnAttackDelay { get; set;}

		[RED("snakeHeadTemplate")] 		public CHandle<CEntityTemplate> SnakeHeadTemplate { get; set;}

		[RED("additionalSnakeHeadFXName")] 		public CName AdditionalSnakeHeadFXName { get; set;}

		[RED("playEffectOnOwner")] 		public CName PlayEffectOnOwner { get; set;}

		[RED("ThreeStateAttack")] 		public CBool ThreeStateAttack { get; set;}

		[RED("loopHeadFX")] 		public CBool LoopHeadFX { get; set;}

		[RED("destroyEffectDelay")] 		public CFloat DestroyEffectDelay { get; set;}

		[RED("waitForAnimEventToSummon")] 		public CName WaitForAnimEventToSummon { get; set;}

		[RED("canTriggerFrenzySlowmo")] 		public CBool CanTriggerFrenzySlowmo { get; set;}

		public BTTaskFrostSnakeAttackDef(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new BTTaskFrostSnakeAttackDef(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}