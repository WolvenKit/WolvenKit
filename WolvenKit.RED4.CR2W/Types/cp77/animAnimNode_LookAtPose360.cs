using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animAnimNode_LookAtPose360 : animAnimNode_Base
	{
		private CFloat _speedInDegreesPerSecond;
		private animFloatLink _angleOffsetNode;
		private animFloatLink _targetAngleOffsetNode;
		private CName _animation;
		private CFloat _durationCut;

		[Ordinal(11)] 
		[RED("speedInDegreesPerSecond")] 
		public CFloat SpeedInDegreesPerSecond
		{
			get
			{
				if (_speedInDegreesPerSecond == null)
				{
					_speedInDegreesPerSecond = (CFloat) CR2WTypeManager.Create("Float", "speedInDegreesPerSecond", cr2w, this);
				}
				return _speedInDegreesPerSecond;
			}
			set
			{
				if (_speedInDegreesPerSecond == value)
				{
					return;
				}
				_speedInDegreesPerSecond = value;
				PropertySet(this);
			}
		}

		[Ordinal(12)] 
		[RED("angleOffsetNode")] 
		public animFloatLink AngleOffsetNode
		{
			get
			{
				if (_angleOffsetNode == null)
				{
					_angleOffsetNode = (animFloatLink) CR2WTypeManager.Create("animFloatLink", "angleOffsetNode", cr2w, this);
				}
				return _angleOffsetNode;
			}
			set
			{
				if (_angleOffsetNode == value)
				{
					return;
				}
				_angleOffsetNode = value;
				PropertySet(this);
			}
		}

		[Ordinal(13)] 
		[RED("targetAngleOffsetNode")] 
		public animFloatLink TargetAngleOffsetNode
		{
			get
			{
				if (_targetAngleOffsetNode == null)
				{
					_targetAngleOffsetNode = (animFloatLink) CR2WTypeManager.Create("animFloatLink", "targetAngleOffsetNode", cr2w, this);
				}
				return _targetAngleOffsetNode;
			}
			set
			{
				if (_targetAngleOffsetNode == value)
				{
					return;
				}
				_targetAngleOffsetNode = value;
				PropertySet(this);
			}
		}

		[Ordinal(14)] 
		[RED("animation")] 
		public CName Animation
		{
			get
			{
				if (_animation == null)
				{
					_animation = (CName) CR2WTypeManager.Create("CName", "animation", cr2w, this);
				}
				return _animation;
			}
			set
			{
				if (_animation == value)
				{
					return;
				}
				_animation = value;
				PropertySet(this);
			}
		}

		[Ordinal(15)] 
		[RED("durationCut")] 
		public CFloat DurationCut
		{
			get
			{
				if (_durationCut == null)
				{
					_durationCut = (CFloat) CR2WTypeManager.Create("Float", "durationCut", cr2w, this);
				}
				return _durationCut;
			}
			set
			{
				if (_durationCut == value)
				{
					return;
				}
				_durationCut = value;
				PropertySet(this);
			}
		}

		public animAnimNode_LookAtPose360(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
