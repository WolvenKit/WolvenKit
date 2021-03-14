using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameEffectParameter_IntEvaluator_ValueOrBlackboard : gameIEffectParameter_IntEvaluator
	{
		private gameBlackboardPropertyBindingDefinition _blackboardProperty;
		private CUInt32 _value;

		[Ordinal(0)] 
		[RED("blackboardProperty")] 
		public gameBlackboardPropertyBindingDefinition BlackboardProperty
		{
			get
			{
				if (_blackboardProperty == null)
				{
					_blackboardProperty = (gameBlackboardPropertyBindingDefinition) CR2WTypeManager.Create("gameBlackboardPropertyBindingDefinition", "blackboardProperty", cr2w, this);
				}
				return _blackboardProperty;
			}
			set
			{
				if (_blackboardProperty == value)
				{
					return;
				}
				_blackboardProperty = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("value")] 
		public CUInt32 Value
		{
			get
			{
				if (_value == null)
				{
					_value = (CUInt32) CR2WTypeManager.Create("Uint32", "value", cr2w, this);
				}
				return _value;
			}
			set
			{
				if (_value == value)
				{
					return;
				}
				_value = value;
				PropertySet(this);
			}
		}

		public gameEffectParameter_IntEvaluator_ValueOrBlackboard(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
