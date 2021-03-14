using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameEffectParameter_CNameEvaluator_ValueOrBlackboard : gameIEffectParameter_CNameEvaluator
	{
		private gameBlackboardPropertyBindingDefinition _blackboardProperty;
		private CName _value;

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
		public CName Value
		{
			get
			{
				if (_value == null)
				{
					_value = (CName) CR2WTypeManager.Create("CName", "value", cr2w, this);
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

		public gameEffectParameter_CNameEvaluator_ValueOrBlackboard(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
