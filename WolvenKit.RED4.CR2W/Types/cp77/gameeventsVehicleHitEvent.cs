using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameeventsVehicleHitEvent : gameeventsHitEvent
	{
		private Vector4 _vehicleVelocity;
		private Vector4 _preyVelocity;

		[Ordinal(12)] 
		[RED("vehicleVelocity")] 
		public Vector4 VehicleVelocity
		{
			get => GetProperty(ref _vehicleVelocity);
			set => SetProperty(ref _vehicleVelocity, value);
		}

		[Ordinal(13)] 
		[RED("preyVelocity")] 
		public Vector4 PreyVelocity
		{
			get => GetProperty(ref _preyVelocity);
			set => SetProperty(ref _preyVelocity, value);
		}

		public gameeventsVehicleHitEvent(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
