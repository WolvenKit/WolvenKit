using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animAnimNode_SkAnim_ : animAnimNode_Base
	{
		private CName _animation;
		private CBool _applyMotion;
		private CBool _isLooped;
		private CBool _resume;
		private CBool _collectEvents;
		private CBool _fireAnimLoopEvent;
		private CName _animLoopEventName;
		private CFloat _clipFront;
		private CFloat _clipEnd;
		private CName _clipFrontByEvent;
		private CName _clipEndByEvent;
		private CName _pushDataByTag;
		private CName _popDataByTag;
		private CName _pushSafeCutTag;
		private CBool _convertToAdditive;
		private CHandle<animIMotionTableProvider> _motionProvider;
		private CBool _applyInertializationOnAnimSetSwap;

		[Ordinal(11)] 
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

		[Ordinal(12)] 
		[RED("applyMotion")] 
		public CBool ApplyMotion
		{
			get
			{
				if (_applyMotion == null)
				{
					_applyMotion = (CBool) CR2WTypeManager.Create("Bool", "applyMotion", cr2w, this);
				}
				return _applyMotion;
			}
			set
			{
				if (_applyMotion == value)
				{
					return;
				}
				_applyMotion = value;
				PropertySet(this);
			}
		}

		[Ordinal(13)] 
		[RED("isLooped")] 
		public CBool IsLooped
		{
			get
			{
				if (_isLooped == null)
				{
					_isLooped = (CBool) CR2WTypeManager.Create("Bool", "isLooped", cr2w, this);
				}
				return _isLooped;
			}
			set
			{
				if (_isLooped == value)
				{
					return;
				}
				_isLooped = value;
				PropertySet(this);
			}
		}

		[Ordinal(14)] 
		[RED("resume")] 
		public CBool Resume
		{
			get
			{
				if (_resume == null)
				{
					_resume = (CBool) CR2WTypeManager.Create("Bool", "resume", cr2w, this);
				}
				return _resume;
			}
			set
			{
				if (_resume == value)
				{
					return;
				}
				_resume = value;
				PropertySet(this);
			}
		}

		[Ordinal(15)] 
		[RED("collectEvents")] 
		public CBool CollectEvents
		{
			get
			{
				if (_collectEvents == null)
				{
					_collectEvents = (CBool) CR2WTypeManager.Create("Bool", "collectEvents", cr2w, this);
				}
				return _collectEvents;
			}
			set
			{
				if (_collectEvents == value)
				{
					return;
				}
				_collectEvents = value;
				PropertySet(this);
			}
		}

		[Ordinal(16)] 
		[RED("fireAnimLoopEvent")] 
		public CBool FireAnimLoopEvent
		{
			get
			{
				if (_fireAnimLoopEvent == null)
				{
					_fireAnimLoopEvent = (CBool) CR2WTypeManager.Create("Bool", "fireAnimLoopEvent", cr2w, this);
				}
				return _fireAnimLoopEvent;
			}
			set
			{
				if (_fireAnimLoopEvent == value)
				{
					return;
				}
				_fireAnimLoopEvent = value;
				PropertySet(this);
			}
		}

		[Ordinal(17)] 
		[RED("animLoopEventName")] 
		public CName AnimLoopEventName
		{
			get
			{
				if (_animLoopEventName == null)
				{
					_animLoopEventName = (CName) CR2WTypeManager.Create("CName", "animLoopEventName", cr2w, this);
				}
				return _animLoopEventName;
			}
			set
			{
				if (_animLoopEventName == value)
				{
					return;
				}
				_animLoopEventName = value;
				PropertySet(this);
			}
		}

		[Ordinal(18)] 
		[RED("clipFront")] 
		public CFloat ClipFront
		{
			get
			{
				if (_clipFront == null)
				{
					_clipFront = (CFloat) CR2WTypeManager.Create("Float", "clipFront", cr2w, this);
				}
				return _clipFront;
			}
			set
			{
				if (_clipFront == value)
				{
					return;
				}
				_clipFront = value;
				PropertySet(this);
			}
		}

		[Ordinal(19)] 
		[RED("clipEnd")] 
		public CFloat ClipEnd
		{
			get
			{
				if (_clipEnd == null)
				{
					_clipEnd = (CFloat) CR2WTypeManager.Create("Float", "clipEnd", cr2w, this);
				}
				return _clipEnd;
			}
			set
			{
				if (_clipEnd == value)
				{
					return;
				}
				_clipEnd = value;
				PropertySet(this);
			}
		}

		[Ordinal(20)] 
		[RED("clipFrontByEvent")] 
		public CName ClipFrontByEvent
		{
			get
			{
				if (_clipFrontByEvent == null)
				{
					_clipFrontByEvent = (CName) CR2WTypeManager.Create("CName", "clipFrontByEvent", cr2w, this);
				}
				return _clipFrontByEvent;
			}
			set
			{
				if (_clipFrontByEvent == value)
				{
					return;
				}
				_clipFrontByEvent = value;
				PropertySet(this);
			}
		}

		[Ordinal(21)] 
		[RED("clipEndByEvent")] 
		public CName ClipEndByEvent
		{
			get
			{
				if (_clipEndByEvent == null)
				{
					_clipEndByEvent = (CName) CR2WTypeManager.Create("CName", "clipEndByEvent", cr2w, this);
				}
				return _clipEndByEvent;
			}
			set
			{
				if (_clipEndByEvent == value)
				{
					return;
				}
				_clipEndByEvent = value;
				PropertySet(this);
			}
		}

		[Ordinal(22)] 
		[RED("pushDataByTag")] 
		public CName PushDataByTag
		{
			get
			{
				if (_pushDataByTag == null)
				{
					_pushDataByTag = (CName) CR2WTypeManager.Create("CName", "pushDataByTag", cr2w, this);
				}
				return _pushDataByTag;
			}
			set
			{
				if (_pushDataByTag == value)
				{
					return;
				}
				_pushDataByTag = value;
				PropertySet(this);
			}
		}

		[Ordinal(23)] 
		[RED("popDataByTag")] 
		public CName PopDataByTag
		{
			get
			{
				if (_popDataByTag == null)
				{
					_popDataByTag = (CName) CR2WTypeManager.Create("CName", "popDataByTag", cr2w, this);
				}
				return _popDataByTag;
			}
			set
			{
				if (_popDataByTag == value)
				{
					return;
				}
				_popDataByTag = value;
				PropertySet(this);
			}
		}

		[Ordinal(24)] 
		[RED("pushSafeCutTag")] 
		public CName PushSafeCutTag
		{
			get
			{
				if (_pushSafeCutTag == null)
				{
					_pushSafeCutTag = (CName) CR2WTypeManager.Create("CName", "pushSafeCutTag", cr2w, this);
				}
				return _pushSafeCutTag;
			}
			set
			{
				if (_pushSafeCutTag == value)
				{
					return;
				}
				_pushSafeCutTag = value;
				PropertySet(this);
			}
		}

		[Ordinal(25)] 
		[RED("convertToAdditive")] 
		public CBool ConvertToAdditive
		{
			get
			{
				if (_convertToAdditive == null)
				{
					_convertToAdditive = (CBool) CR2WTypeManager.Create("Bool", "convertToAdditive", cr2w, this);
				}
				return _convertToAdditive;
			}
			set
			{
				if (_convertToAdditive == value)
				{
					return;
				}
				_convertToAdditive = value;
				PropertySet(this);
			}
		}

		[Ordinal(26)] 
		[RED("motionProvider")] 
		public CHandle<animIMotionTableProvider> MotionProvider
		{
			get
			{
				if (_motionProvider == null)
				{
					_motionProvider = (CHandle<animIMotionTableProvider>) CR2WTypeManager.Create("handle:animIMotionTableProvider", "motionProvider", cr2w, this);
				}
				return _motionProvider;
			}
			set
			{
				if (_motionProvider == value)
				{
					return;
				}
				_motionProvider = value;
				PropertySet(this);
			}
		}

		[Ordinal(27)] 
		[RED("applyInertializationOnAnimSetSwap")] 
		public CBool ApplyInertializationOnAnimSetSwap
		{
			get
			{
				if (_applyInertializationOnAnimSetSwap == null)
				{
					_applyInertializationOnAnimSetSwap = (CBool) CR2WTypeManager.Create("Bool", "applyInertializationOnAnimSetSwap", cr2w, this);
				}
				return _applyInertializationOnAnimSetSwap;
			}
			set
			{
				if (_applyInertializationOnAnimSetSwap == value)
				{
					return;
				}
				_applyInertializationOnAnimSetSwap = value;
				PropertySet(this);
			}
		}

		public animAnimNode_SkAnim_(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
