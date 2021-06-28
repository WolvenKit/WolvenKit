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
			get => GetProperty(ref _vehicleMappinComponent);
			set => SetProperty(ref _vehicleMappinComponent, value);
		}

		public VehicleMappinDelayedDiscreteModeCallback(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
