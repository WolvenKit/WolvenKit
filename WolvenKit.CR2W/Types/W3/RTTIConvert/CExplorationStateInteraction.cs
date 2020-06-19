using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CExplorationStateInteraction : CExplorationStateAbstract
	{
		[RED("autointeract")] 		public CBool Autointeract { get; set;}

		[RED("safetyTimeToExit")] 		public CFloat SafetyTimeToExit { get; set;}

		[RED("useAutomaticExploration")] 		public CBool UseAutomaticExploration { get; set;}

		[RED("allowOnDiving")] 		public CBool AllowOnDiving { get; set;}

		[RED("timeBeforeExploring")] 		public CFloat TimeBeforeExploring { get; set;}

		[RED("ladderCheckSides")] 		public CBool LadderCheckSides { get; set;}

		[RED("ladderImpulseBack")] 		public CFloat LadderImpulseBack { get; set;}

		[RED("ladderRangeFreeOfNPCs")] 		public CFloat LadderRangeFreeOfNPCs { get; set;}

		[RED("cameraSetClimb")] 		public CHandle<CCameraParametersSet> CameraSetClimb { get; set;}

		[RED("cameraOffsetBack")] 		public CFloat CameraOffsetBack { get; set;}

		[RED("cameraOffsetUp")] 		public CFloat CameraOffsetUp { get; set;}

		[RED("cameraPichInput")] 		public CFloat CameraPichInput { get; set;}

		[RED("cameraBlendSpeedTrans")] 		public CFloat CameraBlendSpeedTrans { get; set;}

		[RED("cameraBlendSpeedYaw")] 		public CFloat CameraBlendSpeedYaw { get; set;}

		[RED("cameraBlendSpeedPitch")] 		public CFloat CameraBlendSpeedPitch { get; set;}

		public CExplorationStateInteraction(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public override CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CExplorationStateInteraction(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}