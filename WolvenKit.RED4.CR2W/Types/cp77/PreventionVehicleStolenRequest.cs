using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class PreventionVehicleStolenRequest : gameScriptableSystemRequest
	{
		private Vector4 _requesterPosition;
		private CEnum<gamedataAffiliation> _vehicleAffiliation;

		[Ordinal(0)] 
		[RED("requesterPosition")] 
		public Vector4 RequesterPosition
		{
			get
			{
				if (_requesterPosition == null)
				{
					_requesterPosition = (Vector4) CR2WTypeManager.Create("Vector4", "requesterPosition", cr2w, this);
				}
				return _requesterPosition;
			}
			set
			{
				if (_requesterPosition == value)
				{
					return;
				}
				_requesterPosition = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("vehicleAffiliation")] 
		public CEnum<gamedataAffiliation> VehicleAffiliation
		{
			get
			{
				if (_vehicleAffiliation == null)
				{
					_vehicleAffiliation = (CEnum<gamedataAffiliation>) CR2WTypeManager.Create("gamedataAffiliation", "vehicleAffiliation", cr2w, this);
				}
				return _vehicleAffiliation;
			}
			set
			{
				if (_vehicleAffiliation == value)
				{
					return;
				}
				_vehicleAffiliation = value;
				PropertySet(this);
			}
		}

		public PreventionVehicleStolenRequest(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
