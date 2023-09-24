
namespace WolvenKit.RED4.Types
{
	public partial class gamedataTankLevelGameplay_Record
	{
		[RED("duration")]
		[REDProperty(IsIgnored = true)]
		public CFloat Duration
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("preLoadedResourceList")]
		[REDProperty(IsIgnored = true)]
		public CArray<CResourceAsyncReference<CResource>> PreLoadedResourceList
		{
			get => GetPropertyValue<CArray<CResourceAsyncReference<CResource>>>();
			set => SetPropertyValue<CArray<CResourceAsyncReference<CResource>>>(value);
		}
		
		[RED("startSFX")]
		[REDProperty(IsIgnored = true)]
		public CName StartSFX
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}
	}
}
