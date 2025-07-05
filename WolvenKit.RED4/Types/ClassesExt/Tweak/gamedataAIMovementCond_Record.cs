
namespace WolvenKit.RED4.Types
{
	public partial class gamedataAIMovementCond_Record
	{
		[RED("constrainedByRestrictedArea")]
		[REDProperty(IsIgnored = true)]
		public CInt32 ConstrainedByRestrictedArea
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}
		
		[RED("destination")]
		[REDProperty(IsIgnored = true)]
		public TweakDBID Destination
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}
		
		[RED("distanceToDestination")]
		[REDProperty(IsIgnored = true)]
		public Vector2 DistanceToDestination
		{
			get => GetPropertyValue<Vector2>();
			set => SetPropertyValue<Vector2>(value);
		}
		
		[RED("isDestinationCalculated")]
		[REDProperty(IsIgnored = true)]
		public CInt32 IsDestinationCalculated
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}
		
		[RED("isDestinationChanged")]
		[REDProperty(IsIgnored = true)]
		public CInt32 IsDestinationChanged
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}
		
		[RED("isEvaluated")]
		[REDProperty(IsIgnored = true)]
		public CInt32 IsEvaluated
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}
		
		[RED("isMoving")]
		[REDProperty(IsIgnored = true)]
		public CInt32 IsMoving
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}
		
		[RED("isPauseByDynamicCollision")]
		[REDProperty(IsIgnored = true)]
		public CInt32 IsPauseByDynamicCollision
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}
		
		[RED("isUsingOffMeshLink")]
		[REDProperty(IsIgnored = true)]
		public CInt32 IsUsingOffMeshLink
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}
		
		[RED("lineOfSightFailed")]
		[REDProperty(IsIgnored = true)]
		public CInt32 LineOfSightFailed
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}
		
		[RED("moveLocomotionAction")]
		[REDProperty(IsIgnored = true)]
		public CName MoveLocomotionAction
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}
		
		[RED("movementType")]
		[REDProperty(IsIgnored = true)]
		public CName MovementType
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}
		
		[RED("offMeshLinkType")]
		[REDProperty(IsIgnored = true)]
		public CName OffMeshLinkType
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}
		
		[RED("pathFindingFailed")]
		[REDProperty(IsIgnored = true)]
		public CInt32 PathFindingFailed
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}
		
		[RED("slope")]
		[REDProperty(IsIgnored = true)]
		public Vector2 Slope
		{
			get => GetPropertyValue<Vector2>();
			set => SetPropertyValue<Vector2>(value);
		}
		
		[RED("spatialHintMults")]
		[REDProperty(IsIgnored = true)]
		public Vector3 SpatialHintMults
		{
			get => GetPropertyValue<Vector3>();
			set => SetPropertyValue<Vector3>(value);
		}
	}
}
