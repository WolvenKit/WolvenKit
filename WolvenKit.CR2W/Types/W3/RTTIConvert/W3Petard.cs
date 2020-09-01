using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class W3Petard : CThrowable
	{
		[Ordinal(0)] [RED("("cameraShakeStrMin")] 		public CFloat CameraShakeStrMin { get; set;}

		[Ordinal(0)] [RED("("cameraShakeStrMax")] 		public CFloat CameraShakeStrMax { get; set;}

		[Ordinal(0)] [RED("("cameraShakeRange")] 		public CFloat CameraShakeRange { get; set;}

		[Ordinal(0)] [RED("("hitReactionType")] 		public CEnum<EHitReactionType> HitReactionType { get; set;}

		[Ordinal(0)] [RED("("noLoopEffectIfHitWater")] 		public CBool NoLoopEffectIfHitWater { get; set;}

		[Ordinal(0)] [RED("("dismemberOnKill")] 		public CBool DismemberOnKill { get; set;}

		[Ordinal(0)] [RED("("componentsEnabledOnLoop", 2,0)] 		public CArray<CName> ComponentsEnabledOnLoop { get; set;}

		[Ordinal(0)] [RED("("friendlyFire")] 		public CBool FriendlyFire { get; set;}

		[Ordinal(0)] [RED("("impactParams")] 		public SPetardParams ImpactParams { get; set;}

		[Ordinal(0)] [RED("("loopParams")] 		public SPetardParams LoopParams { get; set;}

		[Ordinal(0)] [RED("("dodgeable")] 		public CBool Dodgeable { get; set;}

		[Ordinal(0)] [RED("("audioImpactName")] 		public CName AudioImpactName { get; set;}

		[Ordinal(0)] [RED("("ignoreBombSkills")] 		public CBool IgnoreBombSkills { get; set;}

		[Ordinal(0)] [RED("("enableTrailFX")] 		public CBool EnableTrailFX { get; set;}

		[Ordinal(0)] [RED("("alignToNormal")] 		public CBool AlignToNormal { get; set;}

		[Ordinal(0)] [RED("("FX_TRAIL")] 		public CName FX_TRAIL { get; set;}

		[Ordinal(0)] [RED("("FX_CLUSTER")] 		public CName FX_CLUSTER { get; set;}

		[Ordinal(0)] [RED("("itemName")] 		public CName ItemName { get; set;}

		[Ordinal(0)] [RED("("targetPos")] 		public Vector TargetPos { get; set;}

		[Ordinal(0)] [RED("("isProximity")] 		public CBool IsProximity { get; set;}

		[Ordinal(0)] [RED("("isInWater")] 		public CBool IsInWater { get; set;}

		[Ordinal(0)] [RED("("isInDeepWater")] 		public CBool IsInDeepWater { get; set;}

		[Ordinal(0)] [RED("("isStuck")] 		public CBool IsStuck { get; set;}

		[Ordinal(0)] [RED("("isCluster")] 		public CBool IsCluster { get; set;}

		[Ordinal(0)] [RED("("justPlayingFXs", 2,0)] 		public CArray<CName> JustPlayingFXs { get; set;}

		[Ordinal(0)] [RED("("loopDuration")] 		public CFloat LoopDuration { get; set;}

		[Ordinal(0)] [RED("("snapCollisionGroupNames", 2,0)] 		public CArray<CName> SnapCollisionGroupNames { get; set;}

		[Ordinal(0)] [RED("("stopCollisions")] 		public CBool StopCollisions { get; set;}

		[Ordinal(0)] [RED("("previousTargets", 2,0)] 		public CArray<CHandle<CGameplayEntity>> PreviousTargets { get; set;}

		[Ordinal(0)] [RED("("targetsSinceLastCheck", 2,0)] 		public CArray<CHandle<CGameplayEntity>> TargetsSinceLastCheck { get; set;}

		[Ordinal(0)] [RED("("wasInTutorialTrigger")] 		public CBool WasInTutorialTrigger { get; set;}

		[Ordinal(0)] [RED("("decalRemainingTimes", 2,0)] 		public CArray<SPetardShownDecals> DecalRemainingTimes { get; set;}

		[Ordinal(0)] [RED("("impactNormal")] 		public Vector ImpactNormal { get; set;}

		[Ordinal(0)] [RED("("hasImpactFireDamage")] 		public CBool HasImpactFireDamage { get; set;}

		[Ordinal(0)] [RED("("hasImpactFrostDamage")] 		public CBool HasImpactFrostDamage { get; set;}

		[Ordinal(0)] [RED("("hasLoopFireDamage")] 		public CBool HasLoopFireDamage { get; set;}

		[Ordinal(0)] [RED("("hasLoopFrostDamage")] 		public CBool HasLoopFrostDamage { get; set;}

		public W3Petard(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new W3Petard(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}