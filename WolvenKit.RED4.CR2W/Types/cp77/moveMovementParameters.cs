using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class moveMovementParameters : CVariable
	{
		private CEnum<moveMovementType> _type;
		private CFloat _maxSpeed;
		private CFloat _acceleration;
		private CFloat _deceleration;
		private CFloat _rotationSpeed;

		[Ordinal(0)] 
		[RED("type")] 
		public CEnum<moveMovementType> Type
		{
			get
			{
				if (_type == null)
				{
					_type = (CEnum<moveMovementType>) CR2WTypeManager.Create("moveMovementType", "type", cr2w, this);
				}
				return _type;
			}
			set
			{
				if (_type == value)
				{
					return;
				}
				_type = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("maxSpeed")] 
		public CFloat MaxSpeed
		{
			get
			{
				if (_maxSpeed == null)
				{
					_maxSpeed = (CFloat) CR2WTypeManager.Create("Float", "maxSpeed", cr2w, this);
				}
				return _maxSpeed;
			}
			set
			{
				if (_maxSpeed == value)
				{
					return;
				}
				_maxSpeed = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("acceleration")] 
		public CFloat Acceleration
		{
			get
			{
				if (_acceleration == null)
				{
					_acceleration = (CFloat) CR2WTypeManager.Create("Float", "acceleration", cr2w, this);
				}
				return _acceleration;
			}
			set
			{
				if (_acceleration == value)
				{
					return;
				}
				_acceleration = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("deceleration")] 
		public CFloat Deceleration
		{
			get
			{
				if (_deceleration == null)
				{
					_deceleration = (CFloat) CR2WTypeManager.Create("Float", "deceleration", cr2w, this);
				}
				return _deceleration;
			}
			set
			{
				if (_deceleration == value)
				{
					return;
				}
				_deceleration = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("rotationSpeed")] 
		public CFloat RotationSpeed
		{
			get
			{
				if (_rotationSpeed == null)
				{
					_rotationSpeed = (CFloat) CR2WTypeManager.Create("Float", "rotationSpeed", cr2w, this);
				}
				return _rotationSpeed;
			}
			set
			{
				if (_rotationSpeed == value)
				{
					return;
				}
				_rotationSpeed = value;
				PropertySet(this);
			}
		}

		public moveMovementParameters(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
