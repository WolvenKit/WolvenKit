
namespace WolvenKit.RED4.Types
{
	public partial class gamedataAISubActionGeneratePointOfInterestTarget_Record
	{
		[RED("choosingClosestThreatChanceWeight")]
		[REDProperty(IsIgnored = true)]
		public CFloat ChoosingClosestThreatChanceWeight
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("choosingFriendlyTargetChanceWeight")]
		[REDProperty(IsIgnored = true)]
		public CFloat ChoosingFriendlyTargetChanceWeight
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("choosingRandomPointChanceWeight")]
		[REDProperty(IsIgnored = true)]
		public CFloat ChoosingRandomPointChanceWeight
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("choosingSquadMateChanceWeight")]
		[REDProperty(IsIgnored = true)]
		public CFloat ChoosingSquadMateChanceWeight
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("closestThreatDurationRange")]
		[REDProperty(IsIgnored = true)]
		public Vector2 ClosestThreatDurationRange
		{
			get => GetPropertyValue<Vector2>();
			set => SetPropertyValue<Vector2>(value);
		}
		
		[RED("closestThreatWatchingMaxAngle")]
		[REDProperty(IsIgnored = true)]
		public CFloat ClosestThreatWatchingMaxAngle
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("friendlyTargetDurationRange")]
		[REDProperty(IsIgnored = true)]
		public Vector2 FriendlyTargetDurationRange
		{
			get => GetPropertyValue<Vector2>();
			set => SetPropertyValue<Vector2>(value);
		}
		
		[RED("friendlyTargetWatchingMaxAngle")]
		[REDProperty(IsIgnored = true)]
		public CFloat FriendlyTargetWatchingMaxAngle
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("randomPointDurationRange")]
		[REDProperty(IsIgnored = true)]
		public Vector2 RandomPointDurationRange
		{
			get => GetPropertyValue<Vector2>();
			set => SetPropertyValue<Vector2>(value);
		}
		
		[RED("randomPointYRotationAngleRange")]
		[REDProperty(IsIgnored = true)]
		public Vector2 RandomPointYRotationAngleRange
		{
			get => GetPropertyValue<Vector2>();
			set => SetPropertyValue<Vector2>(value);
		}
		
		[RED("randomPointZRotationAngleRange")]
		[REDProperty(IsIgnored = true)]
		public Vector2 RandomPointZRotationAngleRange
		{
			get => GetPropertyValue<Vector2>();
			set => SetPropertyValue<Vector2>(value);
		}
		
		[RED("squadMateDurationRange")]
		[REDProperty(IsIgnored = true)]
		public Vector2 SquadMateDurationRange
		{
			get => GetPropertyValue<Vector2>();
			set => SetPropertyValue<Vector2>(value);
		}
		
		[RED("squadMateWatchingMaxAngle")]
		[REDProperty(IsIgnored = true)]
		public CFloat SquadMateWatchingMaxAngle
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
	}
}
