using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AIbehaviorEdgeConditionDefinition : AIbehaviorUnaryConditionDefinition
	{
		private CEnum<AIbehaviorEdgeConditionAction> _risingEdgeAction;
		private CEnum<AIbehaviorEdgeConditionAction> _fallingEdgeAction;
		private CBool _initialValue;

		[Ordinal(2)] 
		[RED("risingEdgeAction")] 
		public CEnum<AIbehaviorEdgeConditionAction> RisingEdgeAction
		{
			get
			{
				if (_risingEdgeAction == null)
				{
					_risingEdgeAction = (CEnum<AIbehaviorEdgeConditionAction>) CR2WTypeManager.Create("AIbehaviorEdgeConditionAction", "risingEdgeAction", cr2w, this);
				}
				return _risingEdgeAction;
			}
			set
			{
				if (_risingEdgeAction == value)
				{
					return;
				}
				_risingEdgeAction = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("fallingEdgeAction")] 
		public CEnum<AIbehaviorEdgeConditionAction> FallingEdgeAction
		{
			get
			{
				if (_fallingEdgeAction == null)
				{
					_fallingEdgeAction = (CEnum<AIbehaviorEdgeConditionAction>) CR2WTypeManager.Create("AIbehaviorEdgeConditionAction", "fallingEdgeAction", cr2w, this);
				}
				return _fallingEdgeAction;
			}
			set
			{
				if (_fallingEdgeAction == value)
				{
					return;
				}
				_fallingEdgeAction = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("initialValue")] 
		public CBool InitialValue
		{
			get
			{
				if (_initialValue == null)
				{
					_initialValue = (CBool) CR2WTypeManager.Create("Bool", "initialValue", cr2w, this);
				}
				return _initialValue;
			}
			set
			{
				if (_initialValue == value)
				{
					return;
				}
				_initialValue = value;
				PropertySet(this);
			}
		}

		public AIbehaviorEdgeConditionDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
