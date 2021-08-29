using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class AIInterruptionHandlerDefinition : LibTreeINodeDefinition
	{
		private AIInterruptionSignal _signal;
		private CBool _supportLessImportantSignals;

		[Ordinal(0)] 
		[RED("signal")] 
		public AIInterruptionSignal Signal
		{
			get => GetProperty(ref _signal);
			set => SetProperty(ref _signal, value);
		}

		[Ordinal(1)] 
		[RED("supportLessImportantSignals")] 
		public CBool SupportLessImportantSignals
		{
			get => GetProperty(ref _supportLessImportantSignals);
			set => SetProperty(ref _supportLessImportantSignals, value);
		}
	}
}
