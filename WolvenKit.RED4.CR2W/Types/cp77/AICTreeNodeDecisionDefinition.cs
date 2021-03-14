using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AICTreeNodeDecisionDefinition : AICTreeNodeCompositeDefinition
	{
		private CHandle<LibTreeINodeDefinition> _child;
		private CArray<CHandle<LibTreeINodeDefinition>> _expressions;
		private AIInterruptionSignal _interruption;

		[Ordinal(0)] 
		[RED("child")] 
		public CHandle<LibTreeINodeDefinition> Child
		{
			get
			{
				if (_child == null)
				{
					_child = (CHandle<LibTreeINodeDefinition>) CR2WTypeManager.Create("handle:LibTreeINodeDefinition", "child", cr2w, this);
				}
				return _child;
			}
			set
			{
				if (_child == value)
				{
					return;
				}
				_child = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
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

		[Ordinal(2)] 
		[RED("interruption")] 
		public AIInterruptionSignal Interruption
		{
			get
			{
				if (_interruption == null)
				{
					_interruption = (AIInterruptionSignal) CR2WTypeManager.Create("AIInterruptionSignal", "interruption", cr2w, this);
				}
				return _interruption;
			}
			set
			{
				if (_interruption == value)
				{
					return;
				}
				_interruption = value;
				PropertySet(this);
			}
		}

		public AICTreeNodeDecisionDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
