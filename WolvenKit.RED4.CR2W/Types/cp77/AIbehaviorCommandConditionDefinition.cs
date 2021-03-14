using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AIbehaviorCommandConditionDefinition : AIbehaviorConditionDefinition
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
			get
			{
				if (_commandName == null)
				{
					_commandName = (CHandle<AIArgumentMapping>) CR2WTypeManager.Create("handle:AIArgumentMapping", "commandName", cr2w, this);
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
		[RED("isWaiting")] 
		public CBool IsWaiting
		{
			get
			{
				if (_isWaiting == null)
				{
					_isWaiting = (CBool) CR2WTypeManager.Create("Bool", "isWaiting", cr2w, this);
				}
				return _isWaiting;
			}
			set
			{
				if (_isWaiting == value)
				{
					return;
				}
				_isWaiting = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("isExecuting")] 
		public CBool IsExecuting
		{
			get
			{
				if (_isExecuting == null)
				{
					_isExecuting = (CBool) CR2WTypeManager.Create("Bool", "isExecuting", cr2w, this);
				}
				return _isExecuting;
			}
			set
			{
				if (_isExecuting == value)
				{
					return;
				}
				_isExecuting = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
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

		public AIbehaviorCommandConditionDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
