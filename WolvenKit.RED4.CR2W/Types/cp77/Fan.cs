using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class Fan : BasicDistractionDevice
	{
		private CEnum<EAnimationType> _animationType;
		private CBool _rotateClockwise;
		private CBool _randomizeBladesSpeed;
		private CFloat _maxRotationSpeed;
		private CFloat _timeToMaxRotation;
		private CHandle<AnimFeature_RotatingObject> _animFeature;
		private CHandle<UpdateComponent> _updateComp;

		[Ordinal(99)] 
		[RED("animationType")] 
		public CEnum<EAnimationType> AnimationType
		{
			get
			{
				if (_animationType == null)
				{
					_animationType = (CEnum<EAnimationType>) CR2WTypeManager.Create("EAnimationType", "animationType", cr2w, this);
				}
				return _animationType;
			}
			set
			{
				if (_animationType == value)
				{
					return;
				}
				_animationType = value;
				PropertySet(this);
			}
		}

		[Ordinal(100)] 
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

		[Ordinal(101)] 
		[RED("randomizeBladesSpeed")] 
		public CBool RandomizeBladesSpeed
		{
			get
			{
				if (_randomizeBladesSpeed == null)
				{
					_randomizeBladesSpeed = (CBool) CR2WTypeManager.Create("Bool", "randomizeBladesSpeed", cr2w, this);
				}
				return _randomizeBladesSpeed;
			}
			set
			{
				if (_randomizeBladesSpeed == value)
				{
					return;
				}
				_randomizeBladesSpeed = value;
				PropertySet(this);
			}
		}

		[Ordinal(102)] 
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

		[Ordinal(103)] 
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

		[Ordinal(104)] 
		[RED("animFeature")] 
		public CHandle<AnimFeature_RotatingObject> AnimFeature
		{
			get
			{
				if (_animFeature == null)
				{
					_animFeature = (CHandle<AnimFeature_RotatingObject>) CR2WTypeManager.Create("handle:AnimFeature_RotatingObject", "animFeature", cr2w, this);
				}
				return _animFeature;
			}
			set
			{
				if (_animFeature == value)
				{
					return;
				}
				_animFeature = value;
				PropertySet(this);
			}
		}

		[Ordinal(105)] 
		[RED("updateComp")] 
		public CHandle<UpdateComponent> UpdateComp
		{
			get
			{
				if (_updateComp == null)
				{
					_updateComp = (CHandle<UpdateComponent>) CR2WTypeManager.Create("handle:UpdateComponent", "updateComp", cr2w, this);
				}
				return _updateComp;
			}
			set
			{
				if (_updateComp == value)
				{
					return;
				}
				_updateComp = value;
				PropertySet(this);
			}
		}

		public Fan(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
