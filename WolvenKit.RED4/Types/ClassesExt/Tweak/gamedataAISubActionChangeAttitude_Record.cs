
namespace WolvenKit.RED4.Types
{
	public partial class gamedataAISubActionChangeAttitude_Record
	{
		[RED("attitude")]
		[REDProperty(IsIgnored = true)]
		public CName Attitude
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}
		
		[RED("delay")]
		[REDProperty(IsIgnored = true)]
		public CFloat Delay
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("target")]
		[REDProperty(IsIgnored = true)]
		public TweakDBID Target
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}
	}
}
