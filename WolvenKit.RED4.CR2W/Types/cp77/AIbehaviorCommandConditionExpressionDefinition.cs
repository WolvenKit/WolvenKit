using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AIbehaviorCommandConditionExpressionDefinition : AIbehaviorPassiveExpressionDefinition
	{
		private CName _commandName;
		private CBool _useInheritance;
		private CBool _isEnqueued;
		private CBool _isExecuting;

		[Ordinal(0)] 
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

		[Ordinal(1)] 
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

		[Ordinal(2)] 
		[RED("isEnqueued")] 
		public CBool IsEnqueued
		{
			get
			{
				if (_isEnqueued == null)
				{
					_isEnqueued = (CBool) CR2WTypeManager.Create("Bool", "isEnqueued", cr2w, this);
				}
				return _isEnqueued;
			}
			set
			{
				if (_isEnqueued == value)
				{
					return;
				}
				_isEnqueued = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
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

		public AIbehaviorCommandConditionExpressionDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
