using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class VendorRequirementsNotMetNotificationData : IScriptable
	{
		private gameSItemStackRequirementData _data;

		[Ordinal(0)] 
		[RED("data")] 
		public gameSItemStackRequirementData Data
		{
			get
			{
				if (_data == null)
				{
					_data = (gameSItemStackRequirementData) CR2WTypeManager.Create("gameSItemStackRequirementData", "data", cr2w, this);
				}
				return _data;
			}
			set
			{
				if (_data == value)
				{
					return;
				}
				_data = value;
				PropertySet(this);
			}
		}

		public VendorRequirementsNotMetNotificationData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
