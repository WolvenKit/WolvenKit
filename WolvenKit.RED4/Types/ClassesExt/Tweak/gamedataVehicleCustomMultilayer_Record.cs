
namespace WolvenKit.RED4.Types
{
	public partial class gamedataVehicleCustomMultilayer_Record
	{
		[RED("affectedComponents")]
		[REDProperty(IsIgnored = true)]
		public CArray<CName> AffectedComponents
		{
			get => GetPropertyValue<CArray<CName>>();
			set => SetPropertyValue<CArray<CName>>(value);
		}
		
		[RED("coatLayerMax")]
		[REDProperty(IsIgnored = true)]
		public CFloat CoatLayerMax
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("coatLayerMin")]
		[REDProperty(IsIgnored = true)]
		public CFloat CoatLayerMin
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("customMlMask")]
		[REDProperty(IsIgnored = true)]
		public CResourceAsyncReference<CResource> CustomMlMask
		{
			get => GetPropertyValue<CResourceAsyncReference<CResource>>();
			set => SetPropertyValue<CResourceAsyncReference<CResource>>(value);
		}
		
		[RED("customMlSetup")]
		[REDProperty(IsIgnored = true)]
		public CResourceAsyncReference<CResource> CustomMlSetup
		{
			get => GetPropertyValue<CResourceAsyncReference<CResource>>();
			set => SetPropertyValue<CResourceAsyncReference<CResource>>(value);
		}
		
		[RED("excludedComponents")]
		[REDProperty(IsIgnored = true)]
		public CArray<CName> ExcludedComponents
		{
			get => GetPropertyValue<CArray<CName>>();
			set => SetPropertyValue<CArray<CName>>(value);
		}
	}
}
