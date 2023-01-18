
namespace WolvenKit.RED4.Types
{
	public partial class gamedataApplyEffectorEffector_Record
	{
		[RED("applicationTarget")]
		[REDProperty(IsIgnored = true)]
		public CName ApplicationTarget
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}
		
		[RED("effectorToApply")]
		[REDProperty(IsIgnored = true)]
		public TweakDBID EffectorToApply
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}
	}
}
