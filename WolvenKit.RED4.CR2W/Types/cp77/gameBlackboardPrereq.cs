using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameBlackboardPrereq : gameIComparisonPrereq
	{
		private gameBlackboardPropertyBindingDefinition _blackboardValue;
		private CVariant _value;

		[Ordinal(1)] 
		[RED("blackboardValue")] 
		public gameBlackboardPropertyBindingDefinition BlackboardValue
		{
			get
			{
				if (_blackboardValue == null)
				{
					_blackboardValue = (gameBlackboardPropertyBindingDefinition) CR2WTypeManager.Create("gameBlackboardPropertyBindingDefinition", "blackboardValue", cr2w, this);
				}
				return _blackboardValue;
			}
			set
			{
				if (_blackboardValue == value)
				{
					return;
				}
				_blackboardValue = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("value")] 
		public CVariant Value
		{
			get
			{
				if (_value == null)
				{
					_value = (CVariant) CR2WTypeManager.Create("Variant", "value", cr2w, this);
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

		public gameBlackboardPrereq(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
