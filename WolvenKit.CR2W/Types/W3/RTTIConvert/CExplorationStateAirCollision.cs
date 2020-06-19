using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CExplorationStateAirCollision : CExplorationStateAbstract
	{
		[RED("enabled")] 		public CBool Enabled { get; set;}

		[RED("speedMinToCollide")] 		public CFloat SpeedMinToCollide { get; set;}

		[RED("heightMinToCollide")] 		public CFloat HeightMinToCollide { get; set;}

		[RED("heightMaxToStop")] 		public CFloat HeightMaxToStop { get; set;}

		[RED("dotToHardHit")] 		public CFloat DotToHardHit { get; set;}

		[RED("swipeDistance")] 		public CFloat SwipeDistance { get; set;}

		[RED("swipeRadius")] 		public CFloat SwipeRadius { get; set;}

		[RED("swipeHeightRequired")] 		public CFloat SwipeHeightRequired { get; set;}

		[RED("timeStopped")] 		public CFloat TimeStopped { get; set;}

		[RED("timeToRotate")] 		public CFloat TimeToRotate { get; set;}

		[RED("timeToCheckClimb")] 		public CFloat TimeToCheckClimb { get; set;}

		[RED("timeToCheckLand")] 		public CFloat TimeToCheckLand { get; set;}

		[RED("exitAngleLeft")] 		public CFloat ExitAngleLeft { get; set;}

		[RED("exitAngleRight")] 		public CFloat ExitAngleRight { get; set;}

		[RED("exitAngleExtra")] 		public CFloat ExitAngleExtra { get; set;}

		[RED("orientingSpeed")] 		public CFloat OrientingSpeed { get; set;}

		[RED("verticalSpeedConserveCoef")] 		public CFloat VerticalSpeedConserveCoef { get; set;}

		[RED("verticalMovementParams")] 		public SVerticalMovementParams VerticalMovementParams { get; set;}

		[RED("impulseForwardCenter")] 		public CFloat ImpulseForwardCenter { get; set;}

		[RED("impulseDownCenter")] 		public CFloat ImpulseDownCenter { get; set;}

		[RED("impulseForwardSide")] 		public CFloat ImpulseForwardSide { get; set;}

		[RED("impulseDownSide")] 		public CFloat ImpulseDownSide { get; set;}

		[RED("interactAlways")] 		public CBool InteractAlways { get; set;}

		[RED("interactionTimeMin")] 		public CFloat InteractionTimeMin { get; set;}

		[RED("interactionMaxHeight")] 		public CFloat InteractionMaxHeight { get; set;}

		[RED("timeToHitToLand")] 		public CFloat TimeToHitToLand { get; set;}

		[RED("behEventHitToLand")] 		public CName BehEventHitToLand { get; set;}

		[RED("behVarSide")] 		public CName BehVarSide { get; set;}

		[RED("behVarHands")] 		public CName BehVarHands { get; set;}

		[RED("behAnimCanFall")] 		public CName BehAnimCanFall { get; set;}

		public CExplorationStateAirCollision(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public override CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CExplorationStateAirCollision(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}