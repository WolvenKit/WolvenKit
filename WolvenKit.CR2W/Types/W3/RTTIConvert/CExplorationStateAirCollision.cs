using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CExplorationStateAirCollision : CExplorationStateAbstract
	{
		[Ordinal(0)] [RED("enabled")] 		public CBool Enabled { get; set;}

		[Ordinal(0)] [RED("speedMinToCollide")] 		public CFloat SpeedMinToCollide { get; set;}

		[Ordinal(0)] [RED("heightMinToCollide")] 		public CFloat HeightMinToCollide { get; set;}

		[Ordinal(0)] [RED("heightMaxToStop")] 		public CFloat HeightMaxToStop { get; set;}

		[Ordinal(0)] [RED("dotToHardHit")] 		public CFloat DotToHardHit { get; set;}

		[Ordinal(0)] [RED("collisionAngle")] 		public CFloat CollisionAngle { get; set;}

		[Ordinal(0)] [RED("collisionSide")] 		public CEnum<EAirCollisionSide> CollisionSide { get; set;}

		[Ordinal(0)] [RED("m_NormalMaxZToHitF")] 		public CFloat M_NormalMaxZToHitF { get; set;}

		[Ordinal(0)] [RED("angleMinToCollide")] 		public CFloat AngleMinToCollide { get; set;}

		[Ordinal(0)] [RED("angleMinToCollideFront")] 		public CFloat AngleMinToCollideFront { get; set;}

		[Ordinal(0)] [RED("swipeDistance")] 		public CFloat SwipeDistance { get; set;}

		[Ordinal(0)] [RED("swipeRadius")] 		public CFloat SwipeRadius { get; set;}

		[Ordinal(0)] [RED("swipeHeightRequired")] 		public CFloat SwipeHeightRequired { get; set;}

		[Ordinal(0)] [RED("timeStopped")] 		public CFloat TimeStopped { get; set;}

		[Ordinal(0)] [RED("timeToRotate")] 		public CFloat TimeToRotate { get; set;}

		[Ordinal(0)] [RED("timeToCheckClimb")] 		public CFloat TimeToCheckClimb { get; set;}

		[Ordinal(0)] [RED("timeToCheckLand")] 		public CFloat TimeToCheckLand { get; set;}

		[Ordinal(0)] [RED("exitAngleLeft")] 		public CFloat ExitAngleLeft { get; set;}

		[Ordinal(0)] [RED("exitAngleRight")] 		public CFloat ExitAngleRight { get; set;}

		[Ordinal(0)] [RED("exitAngleExtra")] 		public CFloat ExitAngleExtra { get; set;}

		[Ordinal(0)] [RED("orientingSpeed")] 		public CFloat OrientingSpeed { get; set;}

		[Ordinal(0)] [RED("targetYaw")] 		public CFloat TargetYaw { get; set;}

		[Ordinal(0)] [RED("verticalSpeedConserveCoef")] 		public CFloat VerticalSpeedConserveCoef { get; set;}

		[Ordinal(0)] [RED("verticalMovementParams")] 		public SVerticalMovementParams VerticalMovementParams { get; set;}

		[Ordinal(0)] [RED("impulseForwardCenter")] 		public CFloat ImpulseForwardCenter { get; set;}

		[Ordinal(0)] [RED("impulseDownCenter")] 		public CFloat ImpulseDownCenter { get; set;}

		[Ordinal(0)] [RED("impulseForwardSide")] 		public CFloat ImpulseForwardSide { get; set;}

		[Ordinal(0)] [RED("impulseDownSide")] 		public CFloat ImpulseDownSide { get; set;}

		[Ordinal(0)] [RED("interactAlways")] 		public CBool InteractAlways { get; set;}

		[Ordinal(0)] [RED("interactionTimeMin")] 		public CFloat InteractionTimeMin { get; set;}

		[Ordinal(0)] [RED("interactionMaxHeight")] 		public CFloat InteractionMaxHeight { get; set;}

		[Ordinal(0)] [RED("timeToHitToLand")] 		public CFloat TimeToHitToLand { get; set;}

		[Ordinal(0)] [RED("behEventHitToLand")] 		public CName BehEventHitToLand { get; set;}

		[Ordinal(0)] [RED("behVarSide")] 		public CName BehVarSide { get; set;}

		[Ordinal(0)] [RED("behVarHands")] 		public CName BehVarHands { get; set;}

		[Ordinal(0)] [RED("behAnimCanFall")] 		public CName BehAnimCanFall { get; set;}

		public CExplorationStateAirCollision(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CExplorationStateAirCollision(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}