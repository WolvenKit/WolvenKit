using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questUIElement_ConditionType : questIUIConditionType
	{
		private TweakDBID _element;
		private CEnum<gamedataUICondition> _condition;
		private CBool _value;

		[Ordinal(0)] 
		[RED("element")] 
		public TweakDBID Element
		{
			get
			{
				if (_element == null)
				{
					_element = (TweakDBID) CR2WTypeManager.Create("TweakDBID", "element", cr2w, this);
				}
				return _element;
			}
			set
			{
				if (_element == value)
				{
					return;
				}
				_element = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("condition")] 
		public CEnum<gamedataUICondition> Condition
		{
			get
			{
				if (_condition == null)
				{
					_condition = (CEnum<gamedataUICondition>) CR2WTypeManager.Create("gamedataUICondition", "condition", cr2w, this);
				}
				return _condition;
			}
			set
			{
				if (_condition == value)
				{
					return;
				}
				_condition = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("value")] 
		public CBool Value
		{
			get
			{
				if (_value == null)
				{
					_value = (CBool) CR2WTypeManager.Create("Bool", "value", cr2w, this);
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

		public questUIElement_ConditionType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
