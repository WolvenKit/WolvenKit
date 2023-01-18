
namespace WolvenKit.RED4.Types
{
	public partial class gamedataFastTravelBinkData_Record
	{
		[RED("binkPath")]
		[REDProperty(IsIgnored = true)]
		public CResourceAsyncReference<CResource> BinkPath
		{
			get => GetPropertyValue<CResourceAsyncReference<CResource>>();
			set => SetPropertyValue<CResourceAsyncReference<CResource>>(value);
		}
		
		[RED("district")]
		[REDProperty(IsIgnored = true)]
		public TweakDBID District
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
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
