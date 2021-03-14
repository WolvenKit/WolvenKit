using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questSpawnerCondition : questTypedCondition
	{
		private CHandle<questISpawnerConditionType> _type;

		[Ordinal(0)] 
		[RED("type")] 
		public CHandle<questISpawnerConditionType> Type
		{
			get
			{
				if (_type == null)
				{
					_type = (CHandle<questISpawnerConditionType>) CR2WTypeManager.Create("handle:questISpawnerConditionType", "type", cr2w, this);
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

		public questSpawnerCondition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
