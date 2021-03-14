using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class VehicleListItemData : IScriptable
	{
		private CName _displayName;
		private vehiclePlayerVehicle _data;
		private wCHandle<gamedataUIIcon_Record> _icon;

		[Ordinal(0)] 
		[RED("displayName")] 
		public CName DisplayName
		{
			get
			{
				if (_displayName == null)
				{
					_displayName = (CName) CR2WTypeManager.Create("CName", "displayName", cr2w, this);
				}
				return _displayName;
			}
			set
			{
				if (_displayName == value)
				{
					return;
				}
				_displayName = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("data")] 
		public vehiclePlayerVehicle Data
		{
			get
			{
				if (_data == null)
				{
					_data = (vehiclePlayerVehicle) CR2WTypeManager.Create("vehiclePlayerVehicle", "data", cr2w, this);
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

		[Ordinal(2)] 
		[RED("icon")] 
		public wCHandle<gamedataUIIcon_Record> Icon
		{
			get
			{
				if (_icon == null)
				{
					_icon = (wCHandle<gamedataUIIcon_Record>) CR2WTypeManager.Create("whandle:gamedataUIIcon_Record", "icon", cr2w, this);
				}
				return _icon;
			}
			set
			{
				if (_icon == value)
				{
					return;
				}
				_icon = value;
				PropertySet(this);
			}
		}

		public VehicleListItemData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
