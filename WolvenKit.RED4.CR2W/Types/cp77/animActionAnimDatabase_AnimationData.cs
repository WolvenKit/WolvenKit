using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animActionAnimDatabase_AnimationData : CVariable
	{
		private CName _animationName;
		private CName _fallbackAnimationName;
		private CFloat _inTransitionDuration;
		private CBool _inCanRequestInertialization;
		private CFloat _outTransitionDuration;
		private CBool _outCanRequestInertialization;
		private CName _streamingContext;

		[Ordinal(0)] 
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

		[Ordinal(1)] 
		[RED("fallbackAnimationName")] 
		public CName FallbackAnimationName
		{
			get
			{
				if (_fallbackAnimationName == null)
				{
					_fallbackAnimationName = (CName) CR2WTypeManager.Create("CName", "fallbackAnimationName", cr2w, this);
				}
				return _fallbackAnimationName;
			}
			set
			{
				if (_fallbackAnimationName == value)
				{
					return;
				}
				_fallbackAnimationName = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("inTransitionDuration")] 
		public CFloat InTransitionDuration
		{
			get
			{
				if (_inTransitionDuration == null)
				{
					_inTransitionDuration = (CFloat) CR2WTypeManager.Create("Float", "inTransitionDuration", cr2w, this);
				}
				return _inTransitionDuration;
			}
			set
			{
				if (_inTransitionDuration == value)
				{
					return;
				}
				_inTransitionDuration = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("inCanRequestInertialization")] 
		public CBool InCanRequestInertialization
		{
			get
			{
				if (_inCanRequestInertialization == null)
				{
					_inCanRequestInertialization = (CBool) CR2WTypeManager.Create("Bool", "inCanRequestInertialization", cr2w, this);
				}
				return _inCanRequestInertialization;
			}
			set
			{
				if (_inCanRequestInertialization == value)
				{
					return;
				}
				_inCanRequestInertialization = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("outTransitionDuration")] 
		public CFloat OutTransitionDuration
		{
			get
			{
				if (_outTransitionDuration == null)
				{
					_outTransitionDuration = (CFloat) CR2WTypeManager.Create("Float", "outTransitionDuration", cr2w, this);
				}
				return _outTransitionDuration;
			}
			set
			{
				if (_outTransitionDuration == value)
				{
					return;
				}
				_outTransitionDuration = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("outCanRequestInertialization")] 
		public CBool OutCanRequestInertialization
		{
			get
			{
				if (_outCanRequestInertialization == null)
				{
					_outCanRequestInertialization = (CBool) CR2WTypeManager.Create("Bool", "outCanRequestInertialization", cr2w, this);
				}
				return _outCanRequestInertialization;
			}
			set
			{
				if (_outCanRequestInertialization == value)
				{
					return;
				}
				_outCanRequestInertialization = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("streamingContext")] 
		public CName StreamingContext
		{
			get
			{
				if (_streamingContext == null)
				{
					_streamingContext = (CName) CR2WTypeManager.Create("CName", "streamingContext", cr2w, this);
				}
				return _streamingContext;
			}
			set
			{
				if (_streamingContext == value)
				{
					return;
				}
				_streamingContext = value;
				PropertySet(this);
			}
		}

		public animActionAnimDatabase_AnimationData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
