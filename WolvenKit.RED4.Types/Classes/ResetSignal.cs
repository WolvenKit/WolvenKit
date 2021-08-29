using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class ResetSignal : redEvent
	{
		private CName _signalName;
		private CHandle<gameBoolSignalTable> _signalTable;

		[Ordinal(0)] 
		[RED("signalName")] 
		public CName SignalName
		{
			get => GetProperty(ref _signalName);
			set => SetProperty(ref _signalName, value);
		}

		[Ordinal(1)] 
		[RED("signalTable")] 
		public CHandle<gameBoolSignalTable> SignalTable
		{
			get => GetProperty(ref _signalTable);
			set => SetProperty(ref _signalTable, value);
		}
	}
}
