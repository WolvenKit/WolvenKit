
namespace WolvenKit.RED4.Types
{
	public partial class gamedataStatusEffectAttackData_Record
	{
		[RED("applyImmediately")]
		[REDProperty(IsIgnored = true)]
		public CBool ApplyImmediately
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}
		
		[RED("resistPool")]
		[REDProperty(IsIgnored = true)]
		public TweakDBID ResistPool
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}
		
		[RED("stacksToApply")]
		[REDProperty(IsIgnored = true)]
		public CFloat StacksToApply
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
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
