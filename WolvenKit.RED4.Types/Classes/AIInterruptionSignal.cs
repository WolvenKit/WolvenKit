using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class AIInterruptionSignal : RedBaseClass
	{
		private CEnum<AIEInterruptionImportance> _importance;
		private CName _signal;

		[Ordinal(0)] 
		[RED("importance")] 
		public CEnum<AIEInterruptionImportance> Importance
		{
			get => GetProperty(ref _importance);
			set => SetProperty(ref _importance, value);
		}

		[Ordinal(1)] 
		[RED("signal")] 
		public CName Signal
		{
			get => GetProperty(ref _signal);
			set => SetProperty(ref _signal, value);
		}
	}
}
