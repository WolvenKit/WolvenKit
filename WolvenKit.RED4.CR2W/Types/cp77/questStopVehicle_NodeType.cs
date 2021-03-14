using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questStopVehicle_NodeType : questIVehicleManagerNodeType
	{
		private gameEntityReference _vehicleRef;
		private CFloat _time;
		private CBool _detachFromSpline;

		[Ordinal(0)] 
		[RED("vehicleRef")] 
		public gameEntityReference VehicleRef
		{
			get
			{
				if (_vehicleRef == null)
				{
					_vehicleRef = (gameEntityReference) CR2WTypeManager.Create("gameEntityReference", "vehicleRef", cr2w, this);
				}
				return _vehicleRef;
			}
			set
			{
				if (_vehicleRef == value)
				{
					return;
				}
				_vehicleRef = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("time")] 
		public CFloat Time
		{
			get
			{
				if (_time == null)
				{
					_time = (CFloat) CR2WTypeManager.Create("Float", "time", cr2w, this);
				}
				return _time;
			}
			set
			{
				if (_time == value)
				{
					return;
				}
				_time = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("detachFromSpline")] 
		public CBool DetachFromSpline
		{
			get
			{
				if (_detachFromSpline == null)
				{
					_detachFromSpline = (CBool) CR2WTypeManager.Create("Bool", "detachFromSpline", cr2w, this);
				}
				return _detachFromSpline;
			}
			set
			{
				if (_detachFromSpline == value)
				{
					return;
				}
				_detachFromSpline = value;
				PropertySet(this);
			}
		}

		public questStopVehicle_NodeType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
