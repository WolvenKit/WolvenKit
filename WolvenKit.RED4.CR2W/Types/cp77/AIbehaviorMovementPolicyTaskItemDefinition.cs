using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AIbehaviorMovementPolicyTaskItemDefinition : ISerializable
	{
		private CEnum<AIbehaviorMovementPolicyTaskFunctions> _function;
		private CStatic<CHandle<AIbehaviorExpressionSocket>> _params;

		[Ordinal(0)] 
		[RED("function")] 
		public CEnum<AIbehaviorMovementPolicyTaskFunctions> Function
		{
			get
			{
				if (_function == null)
				{
					_function = (CEnum<AIbehaviorMovementPolicyTaskFunctions>) CR2WTypeManager.Create("AIbehaviorMovementPolicyTaskFunctions", "function", cr2w, this);
				}
				return _function;
			}
			set
			{
				if (_function == value)
				{
					return;
				}
				_function = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("params", 4)] 
		public CStatic<CHandle<AIbehaviorExpressionSocket>> Params
		{
			get
			{
				if (_params == null)
				{
					_params = (CStatic<CHandle<AIbehaviorExpressionSocket>>) CR2WTypeManager.Create("static:4,handle:AIbehaviorExpressionSocket", "params", cr2w, this);
				}
				return _params;
			}
			set
			{
				if (_params == value)
				{
					return;
				}
				_params = value;
				PropertySet(this);
			}
		}

		public AIbehaviorMovementPolicyTaskItemDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
