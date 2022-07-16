
namespace WolvenKit.RED4.Types
{
	public partial class gamedataDeviceScreenType_Record
	{
		[RED("contentRatio")]
		[REDProperty(IsIgnored = true)]
		public TweakDBID ContentRatio
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}
		
		[RED("libraryPath")]
		[REDProperty(IsIgnored = true)]
		public CResourceAsyncReference<CResource> LibraryPath
		{
			get => GetPropertyValue<CResourceAsyncReference<CResource>>();
			set => SetPropertyValue<CResourceAsyncReference<CResource>>(value);
		}
		
		[RED("ratio")]
		[REDProperty(IsIgnored = true)]
		public TweakDBID Ratio
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}
	}
}
