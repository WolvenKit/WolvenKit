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
			get
			{
				if (_commandName == null)
				{
					_commandName = (CName) CR2WTypeManager.Create("CName", "commandName", cr2w, this);
				}
				return _commandName;
			}
			set
			{
				if (_commandName == value)
				{
					return;
				}
				_commandName = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("useInheritance")] 
		public CBool UseInheritance
		{
			get
			{
				if (_useInheritance == null)
				{
					_useInheritance = (CBool) CR2WTypeManager.Create("Bool", "useInheritance", cr2w, this);
				}
				return _useInheritance;
			}
			set
			{
				if (_useInheritance == value)
				{
					return;
				}
				_useInheritance = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("contexts")] 
		public CArray<CEnum<AICommandContextsType>> Contexts
		{
			get
			{
				if (_contexts == null)
				{
					_contexts = (CArray<CEnum<AICommandContextsType>>) CR2WTypeManager.Create("array:AICommandContextsType", "contexts", cr2w, this);
				}
				return _contexts;
			}
			set
			{
				if (_contexts == value)
				{
					return;
				}
				_contexts = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("commandOut")] 
		public CHandle<AIArgumentMapping> CommandOut
		{
			get
			{
				if (_commandOut == null)
				{
					_commandOut = (CHandle<AIArgumentMapping>) CR2WTypeManager.Create("handle:AIArgumentMapping", "commandOut", cr2w, this);
				}
				return _commandOut;
			}
			set
			{
				if (_commandOut == value)
				{
					return;
				}
				_commandOut = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("runningSignal")] 
		public CName RunningSignal
		{
			get
			{
				if (_runningSignal == null)
				{
					_runningSignal = (CName) CR2WTypeManager.Create("CName", "runningSignal", cr2w, this);
				}
				return _runningSignal;
			}
			set
			{
				if (_runningSignal == value)
				{
					return;
				}
				_runningSignal = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("waitForCommand")] 
		public CBool WaitForCommand
		{
			get
			{
				if (_waitForCommand == null)
				{
					_waitForCommand = (CBool) CR2WTypeManager.Create("Bool", "waitForCommand", cr2w, this);
				}
				return _waitForCommand;
			}
			set
			{
				if (_waitForCommand == value)
				{
					return;
				}
				_waitForCommand = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("retryIfCommandEnqueued")] 
		public CBool RetryIfCommandEnqueued
		{
			get
			{
				if (_retryIfCommandEnqueued == null)
				{
					_retryIfCommandEnqueued = (CBool) CR2WTypeManager.Create("Bool", "retryIfCommandEnqueued", cr2w, this);
				}
				return _retryIfCommandEnqueued;
			}
			set
			{
				if (_retryIfCommandEnqueued == value)
				{
					return;
				}
				_retryIfCommandEnqueued = value;
				PropertySet(this);
			}
		}

		[Ordinal(8)] 
		[RED("resultIfNoCommand")] 
		public CEnum<AIbehaviorCompletionStatus> ResultIfNoCommand
		{
			get
			{
				if (_resultIfNoCommand == null)
				{
					_resultIfNoCommand = (CEnum<AIbehaviorCompletionStatus>) CR2WTypeManager.Create("AIbehaviorCompletionStatus", "resultIfNoCommand", cr2w, this);
				}
				return _resultIfNoCommand;
			}
			set
			{
				if (_resultIfNoCommand == value)
				{
					return;
				}
				_resultIfNoCommand = value;
				PropertySet(this);
			}
		}

		[Ordinal(9)] 
		[RED("resultIfChildFailed")] 
		public CEnum<AIbehaviorCompletionStatus> ResultIfChildFailed
		{
			get
			{
				if (_resultIfChildFailed == null)
				{
					_resultIfChildFailed = (CEnum<AIbehaviorCompletionStatus>) CR2WTypeManager.Create("AIbehaviorCompletionStatus", "resultIfChildFailed", cr2w, this);
				}
				return _resultIfChildFailed;
			}
			set
			{
				if (_resultIfChildFailed == value)
				{
					return;
				}
				_resultIfChildFailed = value;
				PropertySet(this);
			}
		}

		public AIbehaviorCommandHandlerNodeDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
