
namespace WolvenKit.RED4.Types
{
	public partial class gamedataShooterLevel_Record
	{
		[RED("background")]
		[REDProperty(IsIgnored = true)]
		public TweakDBID Background
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}
		
		[RED("levelNumber")]
		[REDProperty(IsIgnored = true)]
		public CInt32 LevelNumber
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}
		
		[RED("levelWidget")]
		[REDProperty(IsIgnored = true)]
		public CString LevelWidget
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}
		
		[RED("platformLibrary")]
		[REDProperty(IsIgnored = true)]
		public CString PlatformLibrary
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}
		
		[RED("preLoadedResourceList")]
		[REDProperty(IsIgnored = true)]
		public CArray<CResourceAsyncReference<CResource>> PreLoadedResourceList
		{
			get => GetPropertyValue<CArray<CResourceAsyncReference<CResource>>>();
			set => SetPropertyValue<CArray<CResourceAsyncReference<CResource>>>(value);
		}
		
		[RED("variantType")]
		[REDProperty(IsIgnored = true)]
		public CString VariantType
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}
	}
}
