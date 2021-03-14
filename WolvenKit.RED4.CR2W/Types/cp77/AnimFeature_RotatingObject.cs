using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AnimFeature_RotatingObject : animAnimFeature
	{
		private CBool _rotateClockwise;
		private CBool _randomizeBladesRotation;
		private CFloat _maxRotationSpeed;
		private CFloat _timeToMaxRotation;

		[Ordinal(0)] 
		[RED("rotateClockwise")] 
		public CBool RotateClockwise
		{
			get
			{
				if (_rotateClockwise == null)
				{
					_rotateClockwise = (CBool) CR2WTypeManager.Create("Bool", "rotateClockwise", cr2w, this);
				}
				return _rotateClockwise;
			}
			set
			{
				if (_rotateClockwise == value)
				{
					return;
				}
				_rotateClockwise = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("randomizeBladesRotation")] 
		public CBool RandomizeBladesRotation
		{
			get
			{
				if (_randomizeBladesRotation == null)
				{
					_randomizeBladesRotation = (CBool) CR2WTypeManager.Create("Bool", "randomizeBladesRotation", cr2w, this);
				}
				return _randomizeBladesRotation;
			}
			set
			{
				if (_randomizeBladesRotation == value)
				{
					return;
				}
				_randomizeBladesRotation = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("maxRotationSpeed")] 
		public CFloat MaxRotationSpeed
		{
			get
			{
				if (_maxRotationSpeed == null)
				{
					_maxRotationSpeed = (CFloat) CR2WTypeManager.Create("Float", "maxRotationSpeed", cr2w, this);
				}
				return _maxRotationSpeed;
			}
			set
			{
				if (_maxRotationSpeed == value)
				{
					return;
				}
				_maxRotationSpeed = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("timeToMaxRotation")] 
		public CFloat TimeToMaxRotation
		{
			get
			{
				if (_timeToMaxRotation == null)
				{
					_timeToMaxRotation = (CFloat) CR2WTypeManager.Create("Float", "timeToMaxRotation", cr2w, this);
				}
				return _timeToMaxRotation;
			}
			set
			{
				if (_timeToMaxRotation == value)
				{
					return;
				}
				_timeToMaxRotation = value;
				PropertySet(this);
			}
		}

		public AnimFeature_RotatingObject(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
