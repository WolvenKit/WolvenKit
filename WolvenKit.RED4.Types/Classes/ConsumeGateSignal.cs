using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class ConsumeGateSignal : GateSignal
	{
		private CName _consumeCallName;
		private CHandle<GateSignal> _signalToConsume;

		[Ordinal(4)] 
		[RED("consumeCallName")] 
		public CName ConsumeCallName
		{
			get => GetProperty(ref _consumeCallName);
			set => SetProperty(ref _consumeCallName, value);
		}

		[Ordinal(5)] 
		[RED("signalToConsume")] 
		public CHandle<GateSignal> SignalToConsume
		{
			get => GetProperty(ref _signalToConsume);
			set => SetProperty(ref _signalToConsume, value);
		}
	}
}
