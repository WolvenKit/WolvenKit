using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameuiDistrictTriggerData : CVariable
	{
		private CEnum<gamedataDistrict> _district;
		private CName _triggerName;

		[Ordinal(0)] 
		[RED("district")] 
		public CEnum<gamedataDistrict> District
		{
			get
			{
				if (_district == null)
				{
					_district = (CEnum<gamedataDistrict>) CR2WTypeManager.Create("gamedataDistrict", "district", cr2w, this);
				}
				return _district;
			}
			set
			{
				if (_district == value)
				{
					return;
				}
				_district = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("triggerName")] 
		public CName TriggerName
		{
			get
			{
				if (_triggerName == null)
				{
					_triggerName = (CName) CR2WTypeManager.Create("CName", "triggerName", cr2w, this);
				}
				return _triggerName;
			}
			set
			{
				if (_triggerName == value)
				{
					return;
				}
				_triggerName = value;
				PropertySet(this);
			}
		}

		public gameuiDistrictTriggerData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
