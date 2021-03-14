using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AIbehaviorConstantExpressionDefinition : AIbehaviorPassiveExpressionDefinition
	{
		private AIbehaviorTypeRef _type;
		private CVariant _value;

		[Ordinal(0)] 
		[RED("type")] 
		public AIbehaviorTypeRef Type
		{
			get
			{
				if (_type == null)
				{
					_type = (AIbehaviorTypeRef) CR2WTypeManager.Create("AIbehaviorTypeRef", "type", cr2w, this);
				}
				return _type;
			}
			set
			{
				if (_type == value)
				{
					return;
				}
				_type = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
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

		public AIbehaviorConstantExpressionDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
