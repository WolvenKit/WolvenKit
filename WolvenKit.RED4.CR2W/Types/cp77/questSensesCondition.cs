using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questSensesCondition : questTypedCondition
	{
		private CHandle<questISensesConditionType> _type;

		[Ordinal(0)] 
		[RED("type")] 
		public CHandle<questISensesConditionType> Type
		{
			get
			{
				if (_type == null)
				{
					_type = (CHandle<questISensesConditionType>) CR2WTypeManager.Create("handle:questISensesConditionType", "type", cr2w, this);
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

		public questSensesCondition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
