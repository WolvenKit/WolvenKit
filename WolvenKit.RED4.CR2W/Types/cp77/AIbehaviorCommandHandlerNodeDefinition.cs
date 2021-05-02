using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AIbehaviorCommandHandlerNodeDefinition : AIbehaviorDecoratorNodeDefinition
	{
		private CName _commandName;
		private CBool _useInheritance;
		private CArray<CEnum<AICommandContextsType>> _contexts;
		private CHandle<AIArgumentMapping> _commandOut;
		private CName _runningSignal;
		private CBool _waitForCommand;
		private CBool _retryIfCommandEnqueued;
		private CEnum<AIbehaviorCompletionStatus> _resultIfNoCommand;
		private CEnum<AIbehaviorCompletionStatus> _resultIfChildFailed;

		[Ordinal(1)] 
		[RED("commandName")] 
		public CName CommandName
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
		[RED("contexts")] 
		public CArray<CEnum<AICommandContextsType>> Contexts
		{
			get => GetProperty(ref _contexts);
			set => SetProperty(ref _contexts, value);
		}

		[Ordinal(4)] 
		[RED("commandOut")] 
		public CHandle<AIArgumentMapping> CommandOut
		{
			get => GetProperty(ref _commandOut);
			set => SetProperty(ref _commandOut, value);
		}

		[Ordinal(5)] 
		[RED("runningSignal")] 
		public CName RunningSignal
		{
			get => GetProperty(ref _runningSignal);
			set => SetProperty(ref _runningSignal, value);
		}

		[Ordinal(6)] 
		[RED("waitForCommand")] 
		public CBool WaitForCommand
		{
			get => GetProperty(ref _waitForCommand);
			set => SetProperty(ref _waitForCommand, value);
		}

		[Ordinal(7)] 
		[RED("retryIfCommandEnqueued")] 
		public CBool RetryIfCommandEnqueued
		{
			get => GetProperty(ref _retryIfCommandEnqueued);
			set => SetProperty(ref _retryIfCommandEnqueued, value);
		}

		[Ordinal(8)] 
		[RED("resultIfNoCommand")] 
		public CEnum<AIbehaviorCompletionStatus> ResultIfNoCommand
		{
			get => GetProperty(ref _resultIfNoCommand);
			set => SetProperty(ref _resultIfNoCommand, value);
		}

		[Ordinal(9)] 
		[RED("resultIfChildFailed")] 
		public CEnum<AIbehaviorCompletionStatus> ResultIfChildFailed
		{
			get => GetProperty(ref _resultIfChildFailed);
			set => SetProperty(ref _resultIfChildFailed, value);
		}

		public AIbehaviorCommandHandlerNodeDefinition(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
