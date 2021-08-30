using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class AIbehaviorCommandConditionDefinition : AIbehaviorConditionDefinition
	{
		private CHandle<AIArgumentMapping> _commandName;
		private CBool _useInheritance;
		private CBool _isWaiting;
		private CBool _isExecuting;
		private CHandle<AIArgumentMapping> _commandOut;

		[Ordinal(1)] 
		[RED("commandName")] 
		public CHandle<AIArgumentMapping> CommandName
		{
			get => GetProperty(ref _commandName);
			set => SetProperty(ref _commandName, value);
		}

		[Ordinal(2)] 
		[RED("useInheritance")] 
		public CBool UseInheritance
		{
			get => GetProperty(ref _useInheritance);
			set => SetProperty(ref _useInheritance, value);
		}

		[Ordinal(3)] 
		[RED("isWaiting")] 
		public CBool IsWaiting
		{
			get => GetProperty(ref _isWaiting);
			set => SetProperty(ref _isWaiting, value);
		}

		[Ordinal(4)] 
		[RED("isExecuting")] 
		public CBool IsExecuting
		{
			get => GetProperty(ref _isExecuting);
			set => SetProperty(ref _isExecuting, value);
		}

		[Ordinal(5)] 
		[RED("commandOut")] 
		public CHandle<AIArgumentMapping> CommandOut
		{
			get => GetProperty(ref _commandOut);
			set => SetProperty(ref _commandOut, value);
		}

		public AIbehaviorCommandConditionDefinition()
		{
			_isWaiting = true;
			_isExecuting = true;
		}
	}
}
