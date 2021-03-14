using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questMoveOnSplineControlRubberbanding_NodeType : questIVehicleManagerNodeType
	{
		private CBool _enable;
		private gameEntityReference _vehicleRef;
		private gameEntityReference _keepDistanceFromRef;
		private CFloat _distance;
		private CFloat _minSpeed;
		private CBool _reduceSpeedOnTurns;

		[Ordinal(0)] 
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

		[Ordinal(1)] 
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

		[Ordinal(2)] 
		[RED("keepDistanceFromRef")] 
		public gameEntityReference KeepDistanceFromRef
		{
			get
			{
				if (_keepDistanceFromRef == null)
				{
					_keepDistanceFromRef = (gameEntityReference) CR2WTypeManager.Create("gameEntityReference", "keepDistanceFromRef", cr2w, this);
				}
				return _keepDistanceFromRef;
			}
			set
			{
				if (_keepDistanceFromRef == value)
				{
					return;
				}
				_keepDistanceFromRef = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("distance")] 
		public CFloat Distance
		{
			get
			{
				if (_distance == null)
				{
					_distance = (CFloat) CR2WTypeManager.Create("Float", "distance", cr2w, this);
				}
				return _distance;
			}
			set
			{
				if (_distance == value)
				{
					return;
				}
				_distance = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("minSpeed")] 
		public CFloat MinSpeed
		{
			get
			{
				if (_minSpeed == null)
				{
					_minSpeed = (CFloat) CR2WTypeManager.Create("Float", "minSpeed", cr2w, this);
				}
				return _minSpeed;
			}
			set
			{
				if (_minSpeed == value)
				{
					return;
				}
				_minSpeed = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("reduceSpeedOnTurns")] 
		public CBool ReduceSpeedOnTurns
		{
			get
			{
				if (_reduceSpeedOnTurns == null)
				{
					_reduceSpeedOnTurns = (CBool) CR2WTypeManager.Create("Bool", "reduceSpeedOnTurns", cr2w, this);
				}
				return _reduceSpeedOnTurns;
			}
			set
			{
				if (_reduceSpeedOnTurns == value)
				{
					return;
				}
				_reduceSpeedOnTurns = value;
				PropertySet(this);
			}
		}

		public questMoveOnSplineControlRubberbanding_NodeType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
