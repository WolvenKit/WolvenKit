using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameActionRotateBaseState : gameActionReplicatedState
	{
		private CFloat _angleOffset;
		private CFloat _angleTolerance;
		private CBool _keepUpdatingTarget;
		private CBool _useRotationTime;
		private CFloat _rotationSpeed;
		private CFloat _rotationTime;

		[Ordinal(5)] 
		[RED("angleOffset")] 
		public CFloat AngleOffset
		{
			get
			{
				if (_angleOffset == null)
				{
					_angleOffset = (CFloat) CR2WTypeManager.Create("Float", "angleOffset", cr2w, this);
				}
				return _angleOffset;
			}
			set
			{
				if (_angleOffset == value)
				{
					return;
				}
				_angleOffset = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("angleTolerance")] 
		public CFloat AngleTolerance
		{
			get
			{
				if (_angleTolerance == null)
				{
					_angleTolerance = (CFloat) CR2WTypeManager.Create("Float", "angleTolerance", cr2w, this);
				}
				return _angleTolerance;
			}
			set
			{
				if (_angleTolerance == value)
				{
					return;
				}
				_angleTolerance = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("keepUpdatingTarget")] 
		public CBool KeepUpdatingTarget
		{
			get
			{
				if (_keepUpdatingTarget == null)
				{
					_keepUpdatingTarget = (CBool) CR2WTypeManager.Create("Bool", "keepUpdatingTarget", cr2w, this);
				}
				return _keepUpdatingTarget;
			}
			set
			{
				if (_keepUpdatingTarget == value)
				{
					return;
				}
				_keepUpdatingTarget = value;
				PropertySet(this);
			}
		}

		[Ordinal(8)] 
		[RED("useRotationTime")] 
		public CBool UseRotationTime
		{
			get
			{
				if (_useRotationTime == null)
				{
					_useRotationTime = (CBool) CR2WTypeManager.Create("Bool", "useRotationTime", cr2w, this);
				}
				return _useRotationTime;
			}
			set
			{
				if (_useRotationTime == value)
				{
					return;
				}
				_useRotationTime = value;
				PropertySet(this);
			}
		}

		[Ordinal(9)] 
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

		[Ordinal(10)] 
		[RED("rotationTime")] 
		public CFloat RotationTime
		{
			get
			{
				if (_rotationTime == null)
				{
					_rotationTime = (CFloat) CR2WTypeManager.Create("Float", "rotationTime", cr2w, this);
				}
				return _rotationTime;
			}
			set
			{
				if (_rotationTime == value)
				{
					return;
				}
				_rotationTime = value;
				PropertySet(this);
			}
		}

		public gameActionRotateBaseState(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
