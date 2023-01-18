using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class MonitorStatusEffectBehavior : StatusEffectTasks
	{
		[Ordinal(0)] 
		[RED("statusEffectID")] 
		public TweakDBID StatusEffectID
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}

		public MonitorStatusEffectBehavior()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
