using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questFollowObject_NodeType : questIVehicleManagerNodeType
	{
		private gameEntityReference _vehicleRef;
		private gameEntityReference _followObjectRef;
		private Vector3 _offset;
		private CFloat _positionLerpSpeed;
		private CFloat _rotationLerpSpeed;

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
		[RED("followObjectRef")] 
		public gameEntityReference FollowObjectRef
		{
			get
			{
				if (_followObjectRef == null)
				{
					_followObjectRef = (gameEntityReference) CR2WTypeManager.Create("gameEntityReference", "followObjectRef", cr2w, this);
				}
				return _followObjectRef;
			}
			set
			{
				if (_followObjectRef == value)
				{
					return;
				}
				_followObjectRef = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("offset")] 
		public Vector3 Offset
		{
			get
			{
				if (_offset == null)
				{
					_offset = (Vector3) CR2WTypeManager.Create("Vector3", "offset", cr2w, this);
				}
				return _offset;
			}
			set
			{
				if (_offset == value)
				{
					return;
				}
				_offset = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("positionLerpSpeed")] 
		public CFloat PositionLerpSpeed
		{
			get
			{
				if (_positionLerpSpeed == null)
				{
					_positionLerpSpeed = (CFloat) CR2WTypeManager.Create("Float", "positionLerpSpeed", cr2w, this);
				}
				return _positionLerpSpeed;
			}
			set
			{
				if (_positionLerpSpeed == value)
				{
					return;
				}
				_positionLerpSpeed = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("rotationLerpSpeed")] 
		public CFloat RotationLerpSpeed
		{
			get
			{
				if (_rotationLerpSpeed == null)
				{
					_rotationLerpSpeed = (CFloat) CR2WTypeManager.Create("Float", "rotationLerpSpeed", cr2w, this);
				}
				return _rotationLerpSpeed;
			}
			set
			{
				if (_rotationLerpSpeed == value)
				{
					return;
				}
				_rotationLerpSpeed = value;
				PropertySet(this);
			}
		}

		public questFollowObject_NodeType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
