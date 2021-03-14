using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class GetOnWindowCombatDecorator : AIVehicleTaskAbstract
	{
		private CHandle<VehicleExternalWindowRequestEvent> _windowOpenEvent;
		private gamemountingMountingInfo _mountInfo;
		private wCHandle<gameObject> _vehicle;
		private CName _slotName;

		[Ordinal(0)] 
		[RED("windowOpenEvent")] 
		public CHandle<VehicleExternalWindowRequestEvent> WindowOpenEvent
		{
			get
			{
				if (_windowOpenEvent == null)
				{
					_windowOpenEvent = (CHandle<VehicleExternalWindowRequestEvent>) CR2WTypeManager.Create("handle:VehicleExternalWindowRequestEvent", "windowOpenEvent", cr2w, this);
				}
				return _windowOpenEvent;
			}
			set
			{
				if (_windowOpenEvent == value)
				{
					return;
				}
				_windowOpenEvent = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("mountInfo")] 
		public gamemountingMountingInfo MountInfo
		{
			get
			{
				if (_mountInfo == null)
				{
					_mountInfo = (gamemountingMountingInfo) CR2WTypeManager.Create("gamemountingMountingInfo", "mountInfo", cr2w, this);
				}
				return _mountInfo;
			}
			set
			{
				if (_mountInfo == value)
				{
					return;
				}
				_mountInfo = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("vehicle")] 
		public wCHandle<gameObject> Vehicle
		{
			get
			{
				if (_vehicle == null)
				{
					_vehicle = (wCHandle<gameObject>) CR2WTypeManager.Create("whandle:gameObject", "vehicle", cr2w, this);
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

		[Ordinal(3)] 
		[RED("slotName")] 
		public CName SlotName
		{
			get
			{
				if (_slotName == null)
				{
					_slotName = (CName) CR2WTypeManager.Create("CName", "slotName", cr2w, this);
				}
				return _slotName;
			}
			set
			{
				if (_slotName == value)
				{
					return;
				}
				_slotName = value;
				PropertySet(this);
			}
		}

		public GetOnWindowCombatDecorator(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
