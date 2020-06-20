using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CCombatCameraPositionController : ICustomCameraPositionController
	{
		[RED("defaultCameraAngle")] 		public CFloat DefaultCameraAngle { get; set;}

		[RED("defaultCameraZOffset")] 		public CFloat DefaultCameraZOffset { get; set;}

		[RED("flipCameraAngle")] 		public CFloat FlipCameraAngle { get; set;}

		[RED("followRotation")] 		public CPtr<CCurve> FollowRotation { get; set;}

		[RED("followRotationSprint")] 		public CPtr<CCurve> FollowRotationSprint { get; set;}

		[RED("followRotationFlip")] 		public CPtr<CCurve> FollowRotationFlip { get; set;}

		[RED("slopeCameraAngleChange")] 		public CPtr<CCurve> SlopeCameraAngleChange { get; set;}

		[RED("slopeAngleCameraSpaceMultiplier")] 		public CPtr<CCurve> SlopeAngleCameraSpaceMultiplier { get; set;}

		[RED("slopeResetTimeout")] 		public CPtr<CCurve> SlopeResetTimeout { get; set;}

		[RED("cameraPivotDampMult")] 		public CPtr<CCurve> CameraPivotDampMult { get; set;}

		[RED("combatPivotDampMult")] 		public CFloat CombatPivotDampMult { get; set;}

		[RED("bigMonsterHeightThreshold")] 		public CFloat BigMonsterHeightThreshold { get; set;}

		[RED("180FlipThreshold")] 		public CFloat _180FlipThreshold { get; set;}

		[RED("explorationRotationCtrlName")] 		public CName ExplorationRotationCtrlName { get; set;}

		[RED("combatRotationCtrlName")] 		public CName CombatRotationCtrlName { get; set;}

		[RED("offsetSmoothTime")] 		public CFloat OffsetSmoothTime { get; set;}

		[RED("combatPitch")] 		public CFloat CombatPitch { get; set;}

		[RED("combatEnemiesToDistanceMap", 2,0)] 		public CArray<SCameraDistanceInfo> CombatEnemiesToDistanceMap { get; set;}

		[RED("bigMonsterCountMultiplier")] 		public CUInt32 BigMonsterCountMultiplier { get; set;}

		[RED("monsterSizeAdditiveOffset")] 		public CPtr<CCurve> MonsterSizeAdditiveOffset { get; set;}

		[RED("monsterSizeAdditivePitch")] 		public CPtr<CCurve> MonsterSizeAdditivePitch { get; set;}

		[RED("1v1Pitch")] 		public CPtr<CCurve> _1v1Pitch { get; set;}

		[RED("1v1AdditivePitch")] 		public CPtr<CCurve> _1v1AdditivePitch { get; set;}

		[RED("1v1BigMonsterPitch")] 		public CPtr<CCurve> _1v1BigMonsterPitch { get; set;}

		[RED("1v1BMAdditivePitch")] 		public CPtr<CCurve> _1v1BMAdditivePitch { get; set;}

		[RED("1v1Distance")] 		public CPtr<CCurve> _1v1Distance { get; set;}

		[RED("1v1SignificanceAddDistance")] 		public CPtr<CCurve> _1v1SignificanceAddDistance { get; set;}

		[RED("1v1ZOffset")] 		public CPtr<CCurve> _1v1ZOffset { get; set;}

		[RED("1v1BigMonsterZOffset")] 		public CPtr<CCurve> _1v1BigMonsterZOffset { get; set;}

		[RED("1v1PivotMultiplier")] 		public CFloat _1v1PivotMultiplier { get; set;}

		[RED("1v1KeepAngle")] 		public CFloat _1v1KeepAngle { get; set;}

		[RED("1v1OffScreenMult")] 		public CFloat _1v1OffScreenMult { get; set;}

		[RED("oneOnOneCtrlName")] 		public CName OneOnOneCtrlName { get; set;}

		[RED("screenSpaceXRatio")] 		public CFloat ScreenSpaceXRatio { get; set;}

		[RED("screenSpaceYRatio")] 		public CFloat ScreenSpaceYRatio { get; set;}

		[RED("ssCorrectionXTreshold")] 		public CFloat SsCorrectionXTreshold { get; set;}

		[RED("ssCorrectionYTreshold")] 		public CFloat SsCorrectionYTreshold { get; set;}

		[RED("ssPivotCorrSmooth")] 		public CFloat SsPivotCorrSmooth { get; set;}

		[RED("ssDistCorrSmooth")] 		public CFloat SsDistCorrSmooth { get; set;}

		[RED("useExplorationCamInSprint")] 		public CBool UseExplorationCamInSprint { get; set;}

		[RED("collisionController")] 		public CPtr<ICustomCameraCollisionController> CollisionController { get; set;}

		[RED("collisionController2")] 		public CPtr<ICustomCameraCollisionController> CollisionController2 { get; set;}

		[RED("defaultCollisionOriginOffset")] 		public Vector DefaultCollisionOriginOffset { get; set;}

		public CCombatCameraPositionController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CCombatCameraPositionController(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}