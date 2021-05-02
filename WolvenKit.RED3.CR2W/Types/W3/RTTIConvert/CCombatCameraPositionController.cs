using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CCombatCameraPositionController : ICustomCameraPositionController
	{
		[Ordinal(1)] [RED("defaultCameraAngle")] 		public CFloat DefaultCameraAngle { get; set;}

		[Ordinal(2)] [RED("defaultCameraZOffset")] 		public CFloat DefaultCameraZOffset { get; set;}

		[Ordinal(3)] [RED("flipCameraAngle")] 		public CFloat FlipCameraAngle { get; set;}

		[Ordinal(4)] [RED("followRotation")] 		public CPtr<CCurve> FollowRotation { get; set;}

		[Ordinal(5)] [RED("followRotationSprint")] 		public CPtr<CCurve> FollowRotationSprint { get; set;}

		[Ordinal(6)] [RED("followRotationFlip")] 		public CPtr<CCurve> FollowRotationFlip { get; set;}

		[Ordinal(7)] [RED("slopeCameraAngleChange")] 		public CPtr<CCurve> SlopeCameraAngleChange { get; set;}

		[Ordinal(8)] [RED("slopeAngleCameraSpaceMultiplier")] 		public CPtr<CCurve> SlopeAngleCameraSpaceMultiplier { get; set;}

		[Ordinal(9)] [RED("slopeResetTimeout")] 		public CPtr<CCurve> SlopeResetTimeout { get; set;}

		[Ordinal(10)] [RED("cameraPivotDampMult")] 		public CPtr<CCurve> CameraPivotDampMult { get; set;}

		[Ordinal(11)] [RED("combatPivotDampMult")] 		public CFloat CombatPivotDampMult { get; set;}

		[Ordinal(12)] [RED("bigMonsterHeightThreshold")] 		public CFloat BigMonsterHeightThreshold { get; set;}

		[Ordinal(13)] [RED("180FlipThreshold")] 		public CFloat _180FlipThreshold { get; set;}

		[Ordinal(14)] [RED("explorationRotationCtrlName")] 		public CName ExplorationRotationCtrlName { get; set;}

		[Ordinal(15)] [RED("combatRotationCtrlName")] 		public CName CombatRotationCtrlName { get; set;}

		[Ordinal(16)] [RED("offsetSmoothTime")] 		public CFloat OffsetSmoothTime { get; set;}

		[Ordinal(17)] [RED("combatPitch")] 		public CFloat CombatPitch { get; set;}

		[Ordinal(18)] [RED("combatEnemiesToDistanceMap", 2,0)] 		public CArray<SCameraDistanceInfo> CombatEnemiesToDistanceMap { get; set;}

		[Ordinal(19)] [RED("bigMonsterCountMultiplier")] 		public CUInt32 BigMonsterCountMultiplier { get; set;}

		[Ordinal(20)] [RED("monsterSizeAdditiveOffset")] 		public CPtr<CCurve> MonsterSizeAdditiveOffset { get; set;}

		[Ordinal(21)] [RED("monsterSizeAdditivePitch")] 		public CPtr<CCurve> MonsterSizeAdditivePitch { get; set;}

		[Ordinal(22)] [RED("1v1Pitch")] 		public CPtr<CCurve> _1v1Pitch { get; set;}

		[Ordinal(23)] [RED("1v1AdditivePitch")] 		public CPtr<CCurve> _1v1AdditivePitch { get; set;}

		[Ordinal(24)] [RED("1v1BigMonsterPitch")] 		public CPtr<CCurve> _1v1BigMonsterPitch { get; set;}

		[Ordinal(25)] [RED("1v1BMAdditivePitch")] 		public CPtr<CCurve> _1v1BMAdditivePitch { get; set;}

		[Ordinal(26)] [RED("1v1Distance")] 		public CPtr<CCurve> _1v1Distance { get; set;}

		[Ordinal(27)] [RED("1v1SignificanceAddDistance")] 		public CPtr<CCurve> _1v1SignificanceAddDistance { get; set;}

		[Ordinal(28)] [RED("1v1ZOffset")] 		public CPtr<CCurve> _1v1ZOffset { get; set;}

		[Ordinal(29)] [RED("1v1BigMonsterZOffset")] 		public CPtr<CCurve> _1v1BigMonsterZOffset { get; set;}

		[Ordinal(30)] [RED("1v1PivotMultiplier")] 		public CFloat _1v1PivotMultiplier { get; set;}

		[Ordinal(31)] [RED("1v1KeepAngle")] 		public CFloat _1v1KeepAngle { get; set;}

		[Ordinal(32)] [RED("1v1OffScreenMult")] 		public CFloat _1v1OffScreenMult { get; set;}

		[Ordinal(33)] [RED("oneOnOneCtrlName")] 		public CName OneOnOneCtrlName { get; set;}

		[Ordinal(34)] [RED("screenSpaceXRatio")] 		public CFloat ScreenSpaceXRatio { get; set;}

		[Ordinal(35)] [RED("screenSpaceYRatio")] 		public CFloat ScreenSpaceYRatio { get; set;}

		[Ordinal(36)] [RED("ssCorrectionXTreshold")] 		public CFloat SsCorrectionXTreshold { get; set;}

		[Ordinal(37)] [RED("ssCorrectionYTreshold")] 		public CFloat SsCorrectionYTreshold { get; set;}

		[Ordinal(38)] [RED("ssPivotCorrSmooth")] 		public CFloat SsPivotCorrSmooth { get; set;}

		[Ordinal(39)] [RED("ssDistCorrSmooth")] 		public CFloat SsDistCorrSmooth { get; set;}

		[Ordinal(40)] [RED("useExplorationCamInSprint")] 		public CBool UseExplorationCamInSprint { get; set;}

		[Ordinal(41)] [RED("collisionController")] 		public CPtr<ICustomCameraCollisionController> CollisionController { get; set;}

		[Ordinal(42)] [RED("collisionController2")] 		public CPtr<ICustomCameraCollisionController> CollisionController2 { get; set;}

		[Ordinal(43)] [RED("defaultCollisionOriginOffset")] 		public Vector DefaultCollisionOriginOffset { get; set;}

		public CCombatCameraPositionController(IRed3EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CCombatCameraPositionController(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}