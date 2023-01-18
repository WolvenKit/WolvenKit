
namespace WolvenKit.RED4.Types
{
	public partial class gamedataClosestToOwnerCoverSelectionParameters_Record
	{
		[RED("distanceToOwnerMultiplier")]
		[REDProperty(IsIgnored = true)]
		public CFloat DistanceToOwnerMultiplier
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("preferredOwnerDistance")]
		[REDProperty(IsIgnored = true)]
		public CFloat PreferredOwnerDistance
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
	}
}
