
namespace WolvenKit.RED4.Types
{
	public partial class gamedataAdvertisementGroup_Record
	{
		[RED("advertisements")]
		[REDProperty(IsIgnored = true)]
		public CArray<TweakDBID> Advertisements
		{
			get => GetPropertyValue<CArray<TweakDBID>>();
			set => SetPropertyValue<CArray<TweakDBID>>(value);
		}
		
		[RED("advertTintColor")]
		[REDProperty(IsIgnored = true)]
		public Vector3 AdvertTintColor
		{
			get => GetPropertyValue<Vector3>();
			set => SetPropertyValue<Vector3>(value);
		}
		
		[RED("fallbackAtlasResource")]
		[REDProperty(IsIgnored = true)]
		public CResourceAsyncReference<CResource> FallbackAtlasResource
		{
			get => GetPropertyValue<CResourceAsyncReference<CResource>>();
			set => SetPropertyValue<CResourceAsyncReference<CResource>>(value);
		}
		
		[RED("includedGroups")]
		[REDProperty(IsIgnored = true)]
		public CArray<TweakDBID> IncludedGroups
		{
			get => GetPropertyValue<CArray<TweakDBID>>();
			set => SetPropertyValue<CArray<TweakDBID>>(value);
		}
		
		[RED("lightTintColor")]
		[REDProperty(IsIgnored = true)]
		public Vector3 LightTintColor
		{
			get => GetPropertyValue<Vector3>();
			set => SetPropertyValue<Vector3>(value);
		}
	}
}
