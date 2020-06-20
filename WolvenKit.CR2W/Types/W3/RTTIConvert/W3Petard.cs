using System.IO;using System.Runtime.Serialization;
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

		public W3Petard(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new W3Petard(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}