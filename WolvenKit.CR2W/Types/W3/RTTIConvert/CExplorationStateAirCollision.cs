using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CExplorationStateAirCollision : CExplorationStateAbstract
	{
		[Ordinal(1)] [RED("enabled")] 		public CBool Enabled { get; set;}

		[Ordinal(2)] [RED("speedMinToCollide")] 		public CFloat SpeedMinToCollide { get; set;}

		[Ordinal(3)] [RED("heightMinToCollide")] 		public CFloat HeightMinToCollide { get; set;}

		[Ordinal(4)] [RED("heightMaxToStop")] 		public CFloat HeightMaxToStop { get; set;}

		[Ordinal(5)] [RED("dotToHardHit")] 		public CFloat DotToHardHit { get; set;}

		[Ordinal(6)] [RED("collisionAngle")] 		public CFloat CollisionAngle { get; set;}

		[Ordinal(7)] [RED("collisionSide")] 		public CEnum<EAirCollisionSide> CollisionSide { get; set;}

		[Ordinal(8)] [RED("m_NormalMaxZToHitF")] 		public CFloat M_NormalMaxZToHitF { get; set;}

		[Ordinal(9)] [RED("angleMinToCollide")] 		public CFloat AngleMinToCollide { get; set;}

		[Ordinal(10)] [RED("angleMinToCollideFront")] 		public CFloat AngleMinToCollideFront { get; set;}

		[Ordinal(11)] [RED("swipeDistance")] 		public CFloat SwipeDistance { get; set;}

		[Ordinal(12)] [RED("swipeRadius")] 		public CFloat SwipeRadius { get; set;}

		[Ordinal(13)] [RED("swipeHeightRequired")] 		public CFloat SwipeHeightRequired { get; set;}

		[Ordinal(14)] [RED("timeStopped")] 		public CFloat TimeStopped { get; set;}

		[Ordinal(15)] [RED("timeToRotate")] 		public CFloat TimeToRotate { get; set;}

		[Ordinal(16)] [RED("timeToCheckClimb")] 		public CFloat TimeToCheckClimb { get; set;}

		[Ordinal(17)] [RED("timeToCheckLand")] 		public CFloat TimeToCheckLand { get; set;}

		[Ordinal(18)] [RED("exitAngleLeft")] 		public CFloat ExitAngleLeft { get; set;}

		[Ordinal(19)] [RED("exitAngleRight")] 		public CFloat ExitAngleRight { get; set;}

		[Ordinal(20)] [RED("exitAngleExtra")] 		public CFloat ExitAngleExtra { get; set;}

		[Ordinal(21)] [RED("orientingSpeed")] 		public CFloat OrientingSpeed { get; set;}

		[Ordinal(22)] [RED("targetYaw")] 		public CFloat TargetYaw { get; set;}

		[Ordinal(23)] [RED("verticalSpeedConserveCoef")] 		public CFloat VerticalSpeedConserveCoef { get; set;}

		[Ordinal(24)] [RED("verticalMovementParams")] 		public SVerticalMovementParams VerticalMovementParams { get; set;}

		[Ordinal(25)] [RED("impulseForwardCenter")] 		public CFloat ImpulseForwardCenter { get; set;}

		[Ordinal(26)] [RED("impulseDownCenter")] 		public CFloat ImpulseDownCenter { get; set;}

		[Ordinal(27)] [RED("impulseForwardSide")] 		public CFloat ImpulseForwardSide { get; set;}

		[Ordinal(28)] [RED("impulseDownSide")] 		public CFloat ImpulseDownSide { get; set;}

		[Ordinal(29)] [RED("interactAlways")] 		public CBool InteractAlways { get; set;}

		[Ordinal(30)] [RED("interactionTimeMin")] 		public CFloat InteractionTimeMin { get; set;}

		[Ordinal(31)] [RED("interactionMaxHeight")] 		public CFloat InteractionMaxHeight { get; set;}

		[Ordinal(32)] [RED("timeToHitToLand")] 		public CFloat TimeToHitToLand { get; set;}

		[Ordinal(33)] [RED("behEventHitToLand")] 		public CName BehEventHitToLand { get; set;}

		[Ordinal(34)] [RED("behVarSide")] 		public CName BehVarSide { get; set;}

		[Ordinal(35)] [RED("behVarHands")] 		public CName BehVarHands { get; set;}

		[Ordinal(36)] [RED("behAnimCanFall")] 		public CName BehAnimCanFall { get; set;}

		public CExplorationStateAirCollision(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CExplorationStateAirCollision(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}