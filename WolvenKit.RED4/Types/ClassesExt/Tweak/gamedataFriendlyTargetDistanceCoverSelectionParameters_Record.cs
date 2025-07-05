
namespace WolvenKit.RED4.Types
{
	public partial class gamedataFriendlyTargetDistanceCoverSelectionParameters_Record
	{
		[RED("distanceToFriendlyTargetMultiplier")]
		[REDProperty(IsIgnored = true)]
		public CFloat DistanceToFriendlyTargetMultiplier
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("friendlyTargetMaxDistance")]
		[REDProperty(IsIgnored = true)]
		public CFloat FriendlyTargetMaxDistance
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("friendlyTargetMinDistance")]
		[REDProperty(IsIgnored = true)]
		public CFloat FriendlyTargetMinDistance
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("friendlyTargetPreferredDistance")]
		[REDProperty(IsIgnored = true)]
		public CFloat FriendlyTargetPreferredDistance
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("friendlyTargetZLimit")]
		[REDProperty(IsIgnored = true)]
		public CFloat FriendlyTargetZLimit
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
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
