using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class inkTextAnimationController : inkWidgetLogicController
	{
		private CBool _playOnInitialize;
		private CName _animationName;
		private CBool _useDefaultAnimation;
		private CFloat _duration;
		private CFloat _startDelay;
		private CFloat _startValue;
		private CFloat _endValue;

		[Ordinal(1)] 
		[RED("playOnInitialize")] 
		public CBool PlayOnInitialize
		{
			get
			{
				if (_playOnInitialize == null)
				{
					_playOnInitialize = (CBool) CR2WTypeManager.Create("Bool", "playOnInitialize", cr2w, this);
				}
				return _playOnInitialize;
			}
			set
			{
				if (_playOnInitialize == value)
				{
					return;
				}
				_playOnInitialize = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("animationName")] 
		public CName AnimationName
		{
			get
			{
				if (_animationName == null)
				{
					_animationName = (CName) CR2WTypeManager.Create("CName", "animationName", cr2w, this);
				}
				return _animationName;
			}
			set
			{
				if (_animationName == value)
				{
					return;
				}
				_animationName = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("useDefaultAnimation")] 
		public CBool UseDefaultAnimation
		{
			get
			{
				if (_useDefaultAnimation == null)
				{
					_useDefaultAnimation = (CBool) CR2WTypeManager.Create("Bool", "useDefaultAnimation", cr2w, this);
				}
				return _useDefaultAnimation;
			}
			set
			{
				if (_useDefaultAnimation == value)
				{
					return;
				}
				_useDefaultAnimation = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("duration")] 
		public CFloat Duration
		{
			get
			{
				if (_duration == null)
				{
					_duration = (CFloat) CR2WTypeManager.Create("Float", "duration", cr2w, this);
				}
				return _duration;
			}
			set
			{
				if (_duration == value)
				{
					return;
				}
				_duration = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("startDelay")] 
		public CFloat StartDelay
		{
			get
			{
				if (_startDelay == null)
				{
					_startDelay = (CFloat) CR2WTypeManager.Create("Float", "startDelay", cr2w, this);
				}
				return _startDelay;
			}
			set
			{
				if (_startDelay == value)
				{
					return;
				}
				_startDelay = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("startValue")] 
		public CFloat StartValue
		{
			get
			{
				if (_startValue == null)
				{
					_startValue = (CFloat) CR2WTypeManager.Create("Float", "startValue", cr2w, this);
				}
				return _startValue;
			}
			set
			{
				if (_startValue == value)
				{
					return;
				}
				_startValue = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("endValue")] 
		public CFloat EndValue
		{
			get
			{
				if (_endValue == null)
				{
					_endValue = (CFloat) CR2WTypeManager.Create("Float", "endValue", cr2w, this);
				}
				return _endValue;
			}
			set
			{
				if (_endValue == value)
				{
					return;
				}
				_endValue = value;
				PropertySet(this);
			}
		}

		public inkTextAnimationController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
