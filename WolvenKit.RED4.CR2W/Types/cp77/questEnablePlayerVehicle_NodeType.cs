using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questEnablePlayerVehicle_NodeType : questIVehicleManagerNodeType
	{
		private CString _vehicle;
		private CBool _enable;
		private CBool _despawn;
		private CBool _makePlayerActiveVehicle;

		[Ordinal(0)] 
		[RED("vehicle")] 
		public CString Vehicle
		{
			get
			{
				if (_vehicle == null)
				{
					_vehicle = (CString) CR2WTypeManager.Create("String", "vehicle", cr2w, this);
				}
				return _vehicle;
			}
			set
			{
				if (_vehicle == value)
				{
					return;
				}
				_vehicle = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("enable")] 
		public CBool Enable
		{
			get
			{
				if (_enable == null)
				{
					_enable = (CBool) CR2WTypeManager.Create("Bool", "enable", cr2w, this);
				}
				return _enable;
			}
			set
			{
				if (_enable == value)
				{
					return;
				}
				_enable = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("despawn")] 
		public CBool Despawn
		{
			get
			{
				if (_despawn == null)
				{
					_despawn = (CBool) CR2WTypeManager.Create("Bool", "despawn", cr2w, this);
				}
				return _despawn;
			}
			set
			{
				if (_despawn == value)
				{
					return;
				}
				_despawn = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("makePlayerActiveVehicle")] 
		public CBool MakePlayerActiveVehicle
		{
			get
			{
				if (_makePlayerActiveVehicle == null)
				{
					_makePlayerActiveVehicle = (CBool) CR2WTypeManager.Create("Bool", "makePlayerActiveVehicle", cr2w, this);
				}
				return _makePlayerActiveVehicle;
			}
			set
			{
				if (_makePlayerActiveVehicle == value)
				{
					return;
				}
				_makePlayerActiveVehicle = value;
				PropertySet(this);
			}
		}

		public questEnablePlayerVehicle_NodeType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
