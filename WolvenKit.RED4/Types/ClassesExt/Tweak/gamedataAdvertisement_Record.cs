
namespace WolvenKit.RED4.Types
{
	public partial class gamedataAdvertisement_Record
	{
		[RED("definitions")]
		[REDProperty(IsIgnored = true)]
		public CArray<TweakDBID> Definitions
		{
			get => GetPropertyValue<CArray<TweakDBID>>();
			set => SetPropertyValue<CArray<TweakDBID>>(value);
		}
		
		[RED("localizationKey")]
		[REDProperty(IsIgnored = true)]
		public gamedataLocKeyWrapper LocalizationKey
		{
			get => GetPropertyValue<gamedataLocKeyWrapper>();
			set => SetPropertyValue<gamedataLocKeyWrapper>(value);
		}
		
		[RED("resource")]
		[REDProperty(IsIgnored = true)]
		public CResourceAsyncReference<CResource> Resource
		{
			get => GetPropertyValue<CResourceAsyncReference<CResource>>();
			set => SetPropertyValue<CResourceAsyncReference<CResource>>(value);
		}
	}
}
