
namespace WolvenKit.RED4.Types
{
	public partial class gamedataApplyStatGroupEffector_Record
	{
		[RED("applicationTarget")]
		[REDProperty(IsIgnored = true)]
		public CName ApplicationTarget
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}
		
		[RED("statGroup")]
		[REDProperty(IsIgnored = true)]
		public TweakDBID StatGroup
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}
	}
}
