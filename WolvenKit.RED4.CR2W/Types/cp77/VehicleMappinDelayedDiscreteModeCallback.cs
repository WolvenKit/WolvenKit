using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class VehicleMappinDelayedDiscreteModeCallback : gameDelaySystemScriptedDelayCallbackWrapper
	{
		private wCHandle<VehicleMappinComponent> _vehicleMappinComponent;

		[Ordinal(0)] 
		[RED("vehicleMappinComponent")] 
		public wCHandle<VehicleMappinComponent> VehicleMappinComponent
		{
			get
			{
				if (_vehicleMappinComponent == null)
				{
					_vehicleMappinComponent = (wCHandle<VehicleMappinComponent>) CR2WTypeManager.Create("whandle:VehicleMappinComponent", "vehicleMappinComponent", cr2w, this);
				}
				return _vehicleMappinComponent;
			}
			set
			{
				if (_vehicleMappinComponent == value)
				{
					return;
				}
				_vehicleMappinComponent = value;
				PropertySet(this);
			}
		}

		public VehicleMappinDelayedDiscreteModeCallback(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
