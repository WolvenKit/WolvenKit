
namespace WolvenKit.RED4.Types
{
	public partial class gamedataFastTravelScreenData_Record
	{
		[RED("district")]
		[REDProperty(IsIgnored = true)]
		public TweakDBID District
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}
		
		[RED("extendingResourcePath")]
		[REDProperty(IsIgnored = true)]
		public CResourceAsyncReference<CResource> ExtendingResourcePath
		{
			get => GetPropertyValue<CResourceAsyncReference<CResource>>();
			set => SetPropertyValue<CResourceAsyncReference<CResource>>(value);
		}
		
		[RED("resourcePath")]
		[REDProperty(IsIgnored = true)]
		public CResourceAsyncReference<CResource> ResourcePath
		{
			get => GetPropertyValue<CResourceAsyncReference<CResource>>();
			set => SetPropertyValue<CResourceAsyncReference<CResource>>(value);
		}
		
		[RED("time")]
		[REDProperty(IsIgnored = true)]
		public TweakDBID Time
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}
		
		[RED("weather")]
		[REDProperty(IsIgnored = true)]
		public TweakDBID Weather
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}
	}
}
