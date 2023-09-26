
namespace WolvenKit.RED4.Types
{
	public partial class gamedataVendor_Record
	{
		[RED("accessPrereqs")]
		[REDProperty(IsIgnored = true)]
		public CArray<TweakDBID> AccessPrereqs
		{
			get => GetPropertyValue<CArray<TweakDBID>>();
			set => SetPropertyValue<CArray<TweakDBID>>(value);
		}
		
		[RED("craftbooks")]
		[REDProperty(IsIgnored = true)]
		public CArray<TweakDBID> Craftbooks
		{
			get => GetPropertyValue<CArray<TweakDBID>>();
			set => SetPropertyValue<CArray<TweakDBID>>(value);
		}
		
		[RED("customerFilterTags")]
		[REDProperty(IsIgnored = true)]
		public CArray<CName> CustomerFilterTags
		{
			get => GetPropertyValue<CArray<CName>>();
			set => SetPropertyValue<CArray<CName>>(value);
		}
		
		[RED("customerInverseFilterTags")]
		[REDProperty(IsIgnored = true)]
		public CArray<CName> CustomerInverseFilterTags
		{
			get => GetPropertyValue<CArray<CName>>();
			set => SetPropertyValue<CArray<CName>>(value);
		}
		
		[RED("experienceStock")]
		[REDProperty(IsIgnored = true)]
		public CArray<TweakDBID> ExperienceStock
		{
			get => GetPropertyValue<CArray<TweakDBID>>();
			set => SetPropertyValue<CArray<TweakDBID>>(value);
		}
		
		[RED("faction")]
		[REDProperty(IsIgnored = true)]
		public TweakDBID Faction
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}
		
		[RED("inGameTimeToRestock")]
		[REDProperty(IsIgnored = true)]
		public CFloat InGameTimeToRestock
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("itemQueries")]
		[REDProperty(IsIgnored = true)]
		public CArray<TweakDBID> ItemQueries
		{
			get => GetPropertyValue<CArray<TweakDBID>>();
			set => SetPropertyValue<CArray<TweakDBID>>(value);
		}
		
		[RED("itemStock")]
		[REDProperty(IsIgnored = true)]
		public CArray<TweakDBID> ItemStock
		{
			get => GetPropertyValue<CArray<TweakDBID>>();
			set => SetPropertyValue<CArray<TweakDBID>>(value);
		}
		
		[RED("localizedDescription")]
		[REDProperty(IsIgnored = true)]
		public CString LocalizedDescription
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}
		
		[RED("localizedName")]
		[REDProperty(IsIgnored = true)]
		public CString LocalizedName
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}
		
		[RED("mapVisibilityPrereqs")]
		[REDProperty(IsIgnored = true)]
		public CArray<TweakDBID> MapVisibilityPrereqs
		{
			get => GetPropertyValue<CArray<TweakDBID>>();
			set => SetPropertyValue<CArray<TweakDBID>>(value);
		}
		
		[RED("vendorFilterTags")]
		[REDProperty(IsIgnored = true)]
		public CArray<CName> VendorFilterTags
		{
			get => GetPropertyValue<CArray<CName>>();
			set => SetPropertyValue<CArray<CName>>(value);
		}
		
		[RED("vendorInverseFilterTags")]
		[REDProperty(IsIgnored = true)]
		public CArray<CName> VendorInverseFilterTags
		{
			get => GetPropertyValue<CArray<CName>>();
			set => SetPropertyValue<CArray<CName>>(value);
		}
		
		[RED("vendorType")]
		[REDProperty(IsIgnored = true)]
		public TweakDBID VendorType
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}
	}
}
