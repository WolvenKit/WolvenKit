
namespace WolvenKit.RED4.Types
{
	public partial class gamedataMappinUIGlobalProfile_Record
	{
		[RED("completedPOIOpacity")]
		[REDProperty(IsIgnored = true)]
		public CFloat CompletedPOIOpacity
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("gpsPortalIconScale")]
		[REDProperty(IsIgnored = true)]
		public CFloat GpsPortalIconScale
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("nameplateVisibleInBraindance")]
		[REDProperty(IsIgnored = true)]
		public CBool NameplateVisibleInBraindance
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}
		
		[RED("nameplateVisibleInTier")]
		[REDProperty(IsIgnored = true)]
		public CArray<CBool> NameplateVisibleInTier
		{
			get => GetPropertyValue<CArray<CBool>>();
			set => SetPropertyValue<CArray<CBool>>(value);
		}
		
		[RED("verticalRelationTolerance")]
		[REDProperty(IsIgnored = true)]
		public CFloat VerticalRelationTolerance
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("verticalRelationVisibleRangeMax")]
		[REDProperty(IsIgnored = true)]
		public CFloat VerticalRelationVisibleRangeMax
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("verticalRelationVisibleRangeMin")]
		[REDProperty(IsIgnored = true)]
		public CFloat VerticalRelationVisibleRangeMin
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
	}
}
