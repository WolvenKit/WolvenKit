using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AICTreeNodeConditionDefinition : AICTreeNodeCompositeDefinition
	{
		private CArray<CHandle<LibTreeINodeDefinition>> _expressions;
		private CHandle<LibTreeINodeDefinition> _trueBranch;
		private CHandle<LibTreeINodeDefinition> _falseBranch;
		private CBool _reevaluateOnExecution;

		[Ordinal(0)] 
		[RED("expressions")] 
		public CArray<CHandle<LibTreeINodeDefinition>> Expressions
		{
			get
			{
				if (_expressions == null)
				{
					_expressions = (CArray<CHandle<LibTreeINodeDefinition>>) CR2WTypeManager.Create("array:handle:LibTreeINodeDefinition", "expressions", cr2w, this);
				}
				return _expressions;
			}
			set
			{
				if (_expressions == value)
				{
					return;
				}
				_expressions = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("trueBranch")] 
		public CHandle<LibTreeINodeDefinition> TrueBranch
		{
			get
			{
				if (_trueBranch == null)
				{
					_trueBranch = (CHandle<LibTreeINodeDefinition>) CR2WTypeManager.Create("handle:LibTreeINodeDefinition", "trueBranch", cr2w, this);
				}
				return _trueBranch;
			}
			set
			{
				if (_trueBranch == value)
				{
					return;
				}
				_trueBranch = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("falseBranch")] 
		public CHandle<LibTreeINodeDefinition> FalseBranch
		{
			get
			{
				if (_falseBranch == null)
				{
					_falseBranch = (CHandle<LibTreeINodeDefinition>) CR2WTypeManager.Create("handle:LibTreeINodeDefinition", "falseBranch", cr2w, this);
				}
				return _falseBranch;
			}
			set
			{
				if (_falseBranch == value)
				{
					return;
				}
				_falseBranch = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("reevaluateOnExecution")] 
		public CBool ReevaluateOnExecution
		{
			get
			{
				if (_reevaluateOnExecution == null)
				{
					_reevaluateOnExecution = (CBool) CR2WTypeManager.Create("Bool", "reevaluateOnExecution", cr2w, this);
				}
				return _reevaluateOnExecution;
			}
			set
			{
				if (_reevaluateOnExecution == value)
				{
					return;
				}
				_reevaluateOnExecution = value;
				PropertySet(this);
			}
		}

		public AICTreeNodeConditionDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
