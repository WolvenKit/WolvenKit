using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class EffectExecutor_SendActionSignal : gameEffectExecutor_Scripted
	{
		[Ordinal(1)] 
		[RED("signalName")] 
		public CName SignalName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(2)] 
		[RED("signalDuration")] 
		public CFloat SignalDuration
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		public EffectExecutor_SendActionSignal()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
