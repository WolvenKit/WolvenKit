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
		[RED("cameraShakeStrMin")] 		public CFloat CameraShakeStrMin { get; set;}

		[RED("cameraShakeStrMax")] 		public CFloat CameraShakeStrMax { get; set;}

		[RED("cameraShakeRange")] 		public CFloat CameraShakeRange { get; set;}

		[RED("hitReactionType")] 		public CEnum<EHitReactionType> HitReactionType { get; set;}

		[RED("noLoopEffectIfHitWater")] 		public CBool NoLoopEffectIfHitWater { get; set;}

		[RED("dismemberOnKill")] 		public CBool DismemberOnKill { get; set;}

		[RED("componentsEnabledOnLoop", 2,0)] 		public CArray<CName> ComponentsEnabledOnLoop { get; set;}

		[RED("friendlyFire")] 		public CBool FriendlyFire { get; set;}

		[RED("impactParams")] 		public SPetardParams ImpactParams { get; set;}

		[RED("loopParams")] 		public SPetardParams LoopParams { get; set;}

		[RED("dodgeable")] 		public CBool Dodgeable { get; set;}

		[RED("audioImpactName")] 		public CName AudioImpactName { get; set;}

		[RED("ignoreBombSkills")] 		public CBool IgnoreBombSkills { get; set;}

		[RED("enableTrailFX")] 		public CBool EnableTrailFX { get; set;}

		[RED("alignToNormal")] 		public CBool AlignToNormal { get; set;}

		[RED("FX_TRAIL")] 		public CName FX_TRAIL { get; set;}

		[RED("FX_CLUSTER")] 		public CName FX_CLUSTER { get; set;}

		[RED("itemName")] 		public CName ItemName { get; set;}

		[RED("targetPos")] 		public Vector TargetPos { get; set;}

		[RED("isProximity")] 		public CBool IsProximity { get; set;}

		[RED("isInWater")] 		public CBool IsInWater { get; set;}

		[RED("isInDeepWater")] 		public CBool IsInDeepWater { get; set;}

		[RED("isStuck")] 		public CBool IsStuck { get; set;}

		[RED("isCluster")] 		public CBool IsCluster { get; set;}

		[RED("justPlayingFXs", 2,0)] 		public CArray<CName> JustPlayingFXs { get; set;}

		[RED("loopDuration")] 		public CFloat LoopDuration { get; set;}

		[RED("snapCollisionGroupNames", 2,0)] 		public CArray<CName> SnapCollisionGroupNames { get; set;}

		[RED("stopCollisions")] 		public CBool StopCollisions { get; set;}

		[RED("previousTargets", 2,0)] 		public CArray<CHandle<CGameplayEntity>> PreviousTargets { get; set;}

		[RED("targetsSinceLastCheck", 2,0)] 		public CArray<CHandle<CGameplayEntity>> TargetsSinceLastCheck { get; set;}

		[RED("wasInTutorialTrigger")] 		public CBool WasInTutorialTrigger { get; set;}

		[RED("decalRemainingTimes", 2,0)] 		public CArray<SPetardShownDecals> DecalRemainingTimes { get; set;}

		[RED("impactNormal")] 		public Vector ImpactNormal { get; set;}

		[RED("hasImpactFireDamage")] 		public CBool HasImpactFireDamage { get; set;}

		[RED("hasImpactFrostDamage")] 		public CBool HasImpactFrostDamage { get; set;}

		[RED("hasLoopFireDamage")] 		public CBool HasLoopFireDamage { get; set;}

		[RED("hasLoopFrostDamage")] 		public CBool HasLoopFrostDamage { get; set;}

		public W3Petard(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new W3Petard(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}