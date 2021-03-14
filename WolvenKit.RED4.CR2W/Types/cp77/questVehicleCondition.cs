using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questVehicleCondition : questTypedCondition
	{
		private CHandle<questIVehicleConditionType> _type;

		[Ordinal(0)] 
		[RED("type")] 
		public CHandle<questIVehicleConditionType> Type
		{
			get
			{
				if (_type == null)
				{
					_type = (CHandle<questIVehicleConditionType>) CR2WTypeManager.Create("handle:questIVehicleConditionType", "type", cr2w, this);
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

		public questVehicleCondition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
