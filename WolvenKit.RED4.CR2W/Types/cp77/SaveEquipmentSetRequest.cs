using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class SaveEquipmentSetRequest : gamePlayerScriptableSystemRequest
	{
		private CString _setName;
		private CEnum<gameEquipmentSetType> _setType;

		[Ordinal(1)] 
		[RED("setName")] 
		public CString SetName
		{
			get
			{
				if (_setName == null)
				{
					_setName = (CString) CR2WTypeManager.Create("String", "setName", cr2w, this);
				}
				return _setName;
			}
			set
			{
				if (_setName == value)
				{
					return;
				}
				_setName = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("setType")] 
		public CEnum<gameEquipmentSetType> SetType
		{
			get
			{
				if (_setType == null)
				{
					_setType = (CEnum<gameEquipmentSetType>) CR2WTypeManager.Create("gameEquipmentSetType", "setType", cr2w, this);
				}
				return _setType;
			}
			set
			{
				if (_setType == value)
				{
					return;
				}
				_setType = value;
				PropertySet(this);
			}
		}

		public SaveEquipmentSetRequest(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
