using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class ResetSignal : redEvent
	{
		[Ordinal(0)] 
		[RED("signalName")] 
		public CName SignalName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(1)] 
		[RED("signalTable")] 
		public CHandle<gameBoolSignalTable> SignalTable
		{
			get => GetPropertyValue<CHandle<gameBoolSignalTable>>();
			set => SetPropertyValue<CHandle<gameBoolSignalTable>>(value);
		}

		public ResetSignal()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
