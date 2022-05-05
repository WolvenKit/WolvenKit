
namespace WolvenKit.RED4.Types
{
	public partial class gamedataRule_Record
	{
		[RED("cooldown")]
		[REDProperty(IsIgnored = true)]
		public CFloat Cooldown
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("output")]
		[REDProperty(IsIgnored = true)]
		public TweakDBID Output
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}
		
		[RED("stimulus")]
		[REDProperty(IsIgnored = true)]
		public TweakDBID Stimulus
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}
		
		[RED("workspotOutput")]
		[REDProperty(IsIgnored = true)]
		public CName WorkspotOutput
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}
	}
}
