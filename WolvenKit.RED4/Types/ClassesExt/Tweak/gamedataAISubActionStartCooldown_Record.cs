
namespace WolvenKit.RED4.Types
{
	public partial class gamedataAISubActionStartCooldown_Record
	{
		[RED("cooldowns")]
		[REDProperty(IsIgnored = true)]
		public CArray<TweakDBID> Cooldowns
		{
			get => GetPropertyValue<CArray<TweakDBID>>();
			set => SetPropertyValue<CArray<TweakDBID>>(value);
		}
		
		[RED("delay")]
		[REDProperty(IsIgnored = true)]
		public CFloat Delay
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("minActionDuration")]
		[REDProperty(IsIgnored = true)]
		public CFloat MinActionDuration
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
	}
}
