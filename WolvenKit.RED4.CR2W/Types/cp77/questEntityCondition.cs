using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questEntityCondition : questTypedCondition
	{
		private CHandle<questIEntityConditionType> _type;

		[Ordinal(0)] 
		[RED("type")] 
		public CHandle<questIEntityConditionType> Type
		{
			get
			{
				if (_type == null)
				{
					_type = (CHandle<questIEntityConditionType>) CR2WTypeManager.Create("handle:questIEntityConditionType", "type", cr2w, this);
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

		public questEntityCondition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
