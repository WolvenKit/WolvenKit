using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class EffectExecutor_SendActionSignal : gameEffectExecutor_Scripted
	{
		private CName _signalName;
		private CFloat _signalDuration;

		[Ordinal(1)] 
		[RED("signalName")] 
		public CName SignalName
		{
			get => GetProperty(ref _signalName);
			set => SetProperty(ref _signalName, value);
		}

		[Ordinal(2)] 
		[RED("signalDuration")] 
		public CFloat SignalDuration
		{
			get => GetProperty(ref _signalDuration);
			set => SetProperty(ref _signalDuration, value);
		}
	}
}
