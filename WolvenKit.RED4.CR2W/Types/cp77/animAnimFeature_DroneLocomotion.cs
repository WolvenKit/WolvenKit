using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animAnimFeature_DroneLocomotion : animAnimFeature
	{
		private CFloat _speed;
		private CFloat _angularSpeed;
		private CFloat _lookAtAngle;
		private CFloat _desiredSpeed;
		private CFloat _pathCurvative;

		[Ordinal(0)] 
		[RED("speed")] 
		public CFloat Speed
		{
			get
			{
				if (_speed == null)
				{
					_speed = (CFloat) CR2WTypeManager.Create("Float", "speed", cr2w, this);
				}
				return _speed;
			}
			set
			{
				if (_speed == value)
				{
					return;
				}
				_speed = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("angularSpeed")] 
		public CFloat AngularSpeed
		{
			get
			{
				if (_angularSpeed == null)
				{
					_angularSpeed = (CFloat) CR2WTypeManager.Create("Float", "angularSpeed", cr2w, this);
				}
				return _angularSpeed;
			}
			set
			{
				if (_angularSpeed == value)
				{
					return;
				}
				_angularSpeed = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("lookAtAngle")] 
		public CFloat LookAtAngle
		{
			get
			{
				if (_lookAtAngle == null)
				{
					_lookAtAngle = (CFloat) CR2WTypeManager.Create("Float", "lookAtAngle", cr2w, this);
				}
				return _lookAtAngle;
			}
			set
			{
				if (_lookAtAngle == value)
				{
					return;
				}
				_lookAtAngle = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("desiredSpeed")] 
		public CFloat DesiredSpeed
		{
			get
			{
				if (_desiredSpeed == null)
				{
					_desiredSpeed = (CFloat) CR2WTypeManager.Create("Float", "desiredSpeed", cr2w, this);
				}
				return _desiredSpeed;
			}
			set
			{
				if (_desiredSpeed == value)
				{
					return;
				}
				_desiredSpeed = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("pathCurvative")] 
		public CFloat PathCurvative
		{
			get
			{
				if (_pathCurvative == null)
				{
					_pathCurvative = (CFloat) CR2WTypeManager.Create("Float", "pathCurvative", cr2w, this);
				}
				return _pathCurvative;
			}
			set
			{
				if (_pathCurvative == value)
				{
					return;
				}
				_pathCurvative = value;
				PropertySet(this);
			}
		}

		public animAnimFeature_DroneLocomotion(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
