using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class StatPoolSpentPrereqState : gamePrereqState
	{
		[Ordinal(0)] 
		[RED("neededValue")] 
		public CFloat NeededValue
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(1)] 
		[RED("listener")] 
		public CHandle<BaseStatPoolPrereqListener> Listener
		{
			get => GetPropertyValue<CHandle<BaseStatPoolPrereqListener>>();
			set => SetPropertyValue<CHandle<BaseStatPoolPrereqListener>>(value);
		}

		public StatPoolSpentPrereqState()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
