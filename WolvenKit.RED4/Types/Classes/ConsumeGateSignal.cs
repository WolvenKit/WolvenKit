using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class ConsumeGateSignal : GateSignal
	{
		[Ordinal(4)] 
		[RED("consumeCallName")] 
		public CName ConsumeCallName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(5)] 
		[RED("signalToConsume")] 
		public CHandle<GateSignal> SignalToConsume
		{
			get => GetPropertyValue<CHandle<GateSignal>>();
			set => SetPropertyValue<CHandle<GateSignal>>(value);
		}

		public ConsumeGateSignal()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
