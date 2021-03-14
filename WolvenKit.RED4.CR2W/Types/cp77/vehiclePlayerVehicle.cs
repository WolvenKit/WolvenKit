using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class vehiclePlayerVehicle : CVariable
	{
		private CName _name;
		private TweakDBID _recordID;
		private CEnum<gamedataVehicleType> _vehicleType;
		private CBool _isUnlocked;

		[Ordinal(0)] 
		[RED("name")] 
		public CName Name
		{
			get
			{
				if (_name == null)
				{
					_name = (CName) CR2WTypeManager.Create("CName", "name", cr2w, this);
				}
				return _name;
			}
			set
			{
				if (_name == value)
				{
					return;
				}
				_name = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("recordID")] 
		public TweakDBID RecordID
		{
			get
			{
				if (_recordID == null)
				{
					_recordID = (TweakDBID) CR2WTypeManager.Create("TweakDBID", "recordID", cr2w, this);
				}
				return _recordID;
			}
			set
			{
				if (_recordID == value)
				{
					return;
				}
				_recordID = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("vehicleType")] 
		public CEnum<gamedataVehicleType> VehicleType
		{
			get
			{
				if (_vehicleType == null)
				{
					_vehicleType = (CEnum<gamedataVehicleType>) CR2WTypeManager.Create("gamedataVehicleType", "vehicleType", cr2w, this);
				}
				return _vehicleType;
			}
			set
			{
				if (_vehicleType == value)
				{
					return;
				}
				_vehicleType = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("isUnlocked")] 
		public CBool IsUnlocked
		{
			get
			{
				if (_isUnlocked == null)
				{
					_isUnlocked = (CBool) CR2WTypeManager.Create("Bool", "isUnlocked", cr2w, this);
				}
				return _isUnlocked;
			}
			set
			{
				if (_isUnlocked == value)
				{
					return;
				}
				_isUnlocked = value;
				PropertySet(this);
			}
		}

		public vehiclePlayerVehicle(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
