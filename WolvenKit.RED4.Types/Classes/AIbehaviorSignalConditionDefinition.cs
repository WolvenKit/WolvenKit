using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class AIbehaviorSignalConditionDefinition : AIbehaviorConditionDefinition
	{
		private CName _signalName;
		private CEnum<AIbehaviorSignalConditionModes> _mode;
		private CBool _tagSignal;

		[Ordinal(1)] 
		[RED("signalName")] 
		public CName SignalName
		{
			get => GetProperty(ref _signalName);
			set => SetProperty(ref _signalName, value);
		}

		[Ordinal(2)] 
		[RED("mode")] 
		public CEnum<AIbehaviorSignalConditionModes> Mode
		{
			get => GetProperty(ref _mode);
			set => SetProperty(ref _mode, value);
		}

		[Ordinal(3)] 
		[RED("tagSignal")] 
		public CBool TagSignal
		{
			get => GetProperty(ref _tagSignal);
			set => SetProperty(ref _tagSignal, value);
		}
	}
}
