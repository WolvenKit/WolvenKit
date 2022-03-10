
namespace WolvenKit.RED4.Types
{
	public partial class gamedataCrackAction_Record
	{
		[RED("effector")]
		[REDProperty(IsIgnored = true)]
		public TweakDBID Effector
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}
		
		[RED("effectorToApply")]
		[REDProperty(IsIgnored = true)]
		public TweakDBID EffectorToApply
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}
		
		[RED("factToCheck")]
		[REDProperty(IsIgnored = true)]
		public CName FactToCheck
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}
	}
}
