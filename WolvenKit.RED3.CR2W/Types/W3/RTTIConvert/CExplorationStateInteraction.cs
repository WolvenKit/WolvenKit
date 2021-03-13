using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CExplorationStateInteraction : CExplorationStateAbstract
	{
		[Ordinal(1)] [RED("explorationType")] 		public CEnum<ExplorationInteractionType> ExplorationType { get; set;}

		[Ordinal(2)] [RED("autointeract")] 		public CBool Autointeract { get; set;}

		[Ordinal(3)] [RED("safetyTimeToExit")] 		public CFloat SafetyTimeToExit { get; set;}

		[Ordinal(4)] [RED("useAutomaticExploration")] 		public CBool UseAutomaticExploration { get; set;}

		[Ordinal(5)] [RED("allowOnDiving")] 		public CBool AllowOnDiving { get; set;}

		[Ordinal(6)] [RED("timeBeforeExploring")] 		public CFloat TimeBeforeExploring { get; set;}

		[Ordinal(7)] [RED("ladderCheckSides")] 		public CBool LadderCheckSides { get; set;}

		[Ordinal(8)] [RED("ladderImpulseBack")] 		public CFloat LadderImpulseBack { get; set;}

		[Ordinal(9)] [RED("ladderRangeFreeOfNPCs")] 		public CFloat LadderRangeFreeOfNPCs { get; set;}

		[Ordinal(10)] [RED("cameraSetClimb")] 		public CHandle<CCameraParametersSet> CameraSetClimb { get; set;}

		[Ordinal(11)] [RED("cameraOffsetBack")] 		public CFloat CameraOffsetBack { get; set;}

		[Ordinal(12)] [RED("cameraOffsetUp")] 		public CFloat CameraOffsetUp { get; set;}

		[Ordinal(13)] [RED("cameraPichInput")] 		public CFloat CameraPichInput { get; set;}

		[Ordinal(14)] [RED("cameraBlendSpeedTrans")] 		public CFloat CameraBlendSpeedTrans { get; set;}

		[Ordinal(15)] [RED("cameraBlendSpeedYaw")] 		public CFloat CameraBlendSpeedYaw { get; set;}

		[Ordinal(16)] [RED("cameraBlendSpeedPitch")] 		public CFloat CameraBlendSpeedPitch { get; set;}

		[Ordinal(17)] [RED("camPosOriginal")] 		public Vector CamPosOriginal { get; set;}

		[Ordinal(18)] [RED("camInitialized")] 		public CBool CamInitialized { get; set;}

		[Ordinal(19)] [RED("cachedWeapon")] 		public CEnum<EPlayerWeapon> CachedWeapon { get; set;}

		[Ordinal(20)] [RED("restoreUsableItemLAtEnd")] 		public CBool RestoreUsableItemLAtEnd { get; set;}

		public CExplorationStateInteraction(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CExplorationStateInteraction(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}