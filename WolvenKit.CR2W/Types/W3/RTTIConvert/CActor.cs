using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CActor : CGameplayEntity
	{
		[RED("actorGroups")] 		public CEnum<EPathEngineAgentType> ActorGroups { get; set;}

		[RED("aimOffset")] 		public CFloat AimOffset { get; set;}

		[RED("barOffset")] 		public CFloat BarOffset { get; set;}

		[RED("isAttackableByPlayer")] 		public CBool IsAttackableByPlayer { get; set;}

		[RED("losTestBoneIndex")] 		public CInt32 LosTestBoneIndex { get; set;}

		[RED("attackTarget")] 		public CHandle<CActor> AttackTarget { get; set;}

		[RED("attackTargetSetTime")] 		public EngineTime AttackTargetSetTime { get; set;}

		[RED("frontPushAnim")] 		public CName FrontPushAnim { get; set;}

		[RED("backPushAnim")] 		public CName BackPushAnim { get; set;}

		[RED("isCollidable")] 		public CBool IsCollidable { get; set;}

		[RED("isVisibileFromFar")] 		public CBool IsVisibileFromFar { get; set;}

		[RED("voiceTag")] 		public CName VoiceTag { get; set;}

		[RED("voiceToRandomize", 2,0)] 		public CArray<StringAnsi> VoiceToRandomize { get; set;}

		[RED("behTreeMachine")] 		public CPtr<CBehTreeMachine> BehTreeMachine { get; set;}

		[RED("useHiResShadows")] 		public CBool UseHiResShadows { get; set;}

		[RED("isInFFMiniGame")] 		public CBool IsInFFMiniGame { get; set;}

		[RED("pelvisBoneName")] 		public CName PelvisBoneName { get; set;}

		[RED("torsoBoneName")] 		public CName TorsoBoneName { get; set;}

		[RED("headBoneName")] 		public CName HeadBoneName { get; set;}

		[RED("useAnimationEventFilter")] 		public CBool UseAnimationEventFilter { get; set;}

		[RED("soundListenerOverride")] 		public CString SoundListenerOverride { get; set;}

		[RED("encounterGroupUsedToSpawn")] 		public CInt32 EncounterGroupUsedToSpawn { get; set;}

		[RED("isTargatebleByPlayer")] 		public CBool IsTargatebleByPlayer { get; set;}

		[RED("isUsingTooltip")] 		public CBool IsUsingTooltip { get; set;}

		[RED("damageDistanceNotReducing")] 		public CFloat DamageDistanceNotReducing { get; set;}

		[RED("deathDistNotReducing")] 		public CFloat DeathDistNotReducing { get; set;}

		[RED("damageDistanceReducing")] 		public CFloat DamageDistanceReducing { get; set;}

		[RED("deathDistanceReducing")] 		public CFloat DeathDistanceReducing { get; set;}

		[RED("fallDamageMinHealthPerc")] 		public CFloat FallDamageMinHealthPerc { get; set;}

		public CActor(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CActor(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}