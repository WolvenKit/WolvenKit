using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class ConsumableChargesPrereqListener : gameScriptStatPoolsListener
	{
		[Ordinal(0)] 
		[RED("state")] 
		public CWeakHandle<ConsumableChargesPrereqState> State
		{
			get => GetPropertyValue<CWeakHandle<ConsumableChargesPrereqState>>();
			set => SetPropertyValue<CWeakHandle<ConsumableChargesPrereqState>>(value);
		}

		public ConsumableChargesPrereqListener()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
