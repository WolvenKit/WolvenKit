
namespace WolvenKit.RED4.Types
{
	public partial class gamedataUIAnimation_Record
	{
		[RED("animationName")]
		[REDProperty(IsIgnored = true)]
		public CName AnimationName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}
		
		[RED("loop")]
		[REDProperty(IsIgnored = true)]
		public CBool Loop
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}
		
		[RED("profile")]
		[REDProperty(IsIgnored = true)]
		public TweakDBID Profile
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}
		
		[RED("widgetResource")]
		[REDProperty(IsIgnored = true)]
		public CResourceAsyncReference<CResource> WidgetResource
		{
			get => GetPropertyValue<CResourceAsyncReference<CResource>>();
			set => SetPropertyValue<CResourceAsyncReference<CResource>>(value);
		}
	}
}
