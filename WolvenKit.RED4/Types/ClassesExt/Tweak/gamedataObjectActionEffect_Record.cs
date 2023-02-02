
namespace WolvenKit.RED4.Types
{
	public partial class gamedataObjectActionEffect_Record
	{
		[RED("effectorToTrigger")]
		[REDProperty(IsIgnored = true)]
		public TweakDBID EffectorToTrigger
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}
		
		[RED("recipient")]
		[REDProperty(IsIgnored = true)]
		public TweakDBID Recipient
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}
		
		[RED("statusEffect")]
		[REDProperty(IsIgnored = true)]
		public TweakDBID StatusEffect
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}
	}
}
