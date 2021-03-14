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
			get
			{
				if (_vehicleVelocity == null)
				{
					_vehicleVelocity = (Vector4) CR2WTypeManager.Create("Vector4", "vehicleVelocity", cr2w, this);
				}
				return _vehicleVelocity;
			}
			set
			{
				if (_vehicleVelocity == value)
				{
					return;
				}
				_vehicleVelocity = value;
				PropertySet(this);
			}
		}

		[Ordinal(13)] 
		[RED("preyVelocity")] 
		public Vector4 PreyVelocity
		{
			get
			{
				if (_preyVelocity == null)
				{
					_preyVelocity = (Vector4) CR2WTypeManager.Create("Vector4", "preyVelocity", cr2w, this);
				}
				return _preyVelocity;
			}
			set
			{
				if (_preyVelocity == value)
				{
					return;
				}
				_preyVelocity = value;
				PropertySet(this);
			}
		}

		public gameeventsVehicleHitEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
