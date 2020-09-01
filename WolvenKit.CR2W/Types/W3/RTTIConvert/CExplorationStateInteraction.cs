using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CExplorationStateInteraction : CExplorationStateAbstract
	{
		[Ordinal(0)] [RED("explorationType")] 		public CEnum<ExplorationInteractionType> ExplorationType { get; set;}

		[Ordinal(0)] [RED("autointeract")] 		public CBool Autointeract { get; set;}

		[Ordinal(0)] [RED("safetyTimeToExit")] 		public CFloat SafetyTimeToExit { get; set;}

		[Ordinal(0)] [RED("useAutomaticExploration")] 		public CBool UseAutomaticExploration { get; set;}

		[Ordinal(0)] [RED("allowOnDiving")] 		public CBool AllowOnDiving { get; set;}

		[Ordinal(0)] [RED("timeBeforeExploring")] 		public CFloat TimeBeforeExploring { get; set;}

		[Ordinal(0)] [RED("ladderCheckSides")] 		public CBool LadderCheckSides { get; set;}

		[Ordinal(0)] [RED("ladderImpulseBack")] 		public CFloat LadderImpulseBack { get; set;}

		[Ordinal(0)] [RED("ladderRangeFreeOfNPCs")] 		public CFloat LadderRangeFreeOfNPCs { get; set;}

		[Ordinal(0)] [RED("cameraSetClimb")] 		public CHandle<CCameraParametersSet> CameraSetClimb { get; set;}

		[Ordinal(0)] [RED("cameraOffsetBack")] 		public CFloat CameraOffsetBack { get; set;}

		[Ordinal(0)] [RED("cameraOffsetUp")] 		public CFloat CameraOffsetUp { get; set;}

		[Ordinal(0)] [RED("cameraPichInput")] 		public CFloat CameraPichInput { get; set;}

		[Ordinal(0)] [RED("cameraBlendSpeedTrans")] 		public CFloat CameraBlendSpeedTrans { get; set;}

		[Ordinal(0)] [RED("cameraBlendSpeedYaw")] 		public CFloat CameraBlendSpeedYaw { get; set;}

		[Ordinal(0)] [RED("cameraBlendSpeedPitch")] 		public CFloat CameraBlendSpeedPitch { get; set;}

		[Ordinal(0)] [RED("camPosOriginal")] 		public Vector CamPosOriginal { get; set;}

		[Ordinal(0)] [RED("camInitialized")] 		public CBool CamInitialized { get; set;}

		[Ordinal(0)] [RED("cachedWeapon")] 		public CEnum<EPlayerWeapon> CachedWeapon { get; set;}

		[Ordinal(0)] [RED("restoreUsableItemLAtEnd")] 		public CBool RestoreUsableItemLAtEnd { get; set;}

		public CExplorationStateInteraction(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CExplorationStateInteraction(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}