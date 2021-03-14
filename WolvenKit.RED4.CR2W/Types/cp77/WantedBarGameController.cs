using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class WantedBarGameController : gameuiHUDGameController
	{
		private CArray<inkWidgetReference> _starsWidget;
		private CHandle<gameIBlackboard> _wantedBlackboard;
		private CHandle<UI_WantedBarDef> _wantedBlackboardDef;
		private CUInt32 _wantedCallbackID;
		private CHandle<inkanimProxy> _animProxy;
		private CHandle<inkanimProxy> _attentionAnimProxy;
		private CHandle<inkanimProxy> _bountyAnimProxy;
		private inkanimPlaybackOptions _animOptionsLoop;
		private CInt32 _wantedLevel;
		private CHandle<inkWidget> _rootWidget;
		private CFloat _wANTED_TIER_1;
		private CFloat _wANTED_MIN;

		[Ordinal(9)] 
		[RED("starsWidget")] 
		public CArray<inkWidgetReference> StarsWidget
		{
			get
			{
				if (_starsWidget == null)
				{
					_starsWidget = (CArray<inkWidgetReference>) CR2WTypeManager.Create("array:inkWidgetReference", "starsWidget", cr2w, this);
				}
				return _starsWidget;
			}
			set
			{
				if (_starsWidget == value)
				{
					return;
				}
				_starsWidget = value;
				PropertySet(this);
			}
		}

		[Ordinal(10)] 
		[RED("wantedBlackboard")] 
		public CHandle<gameIBlackboard> WantedBlackboard
		{
			get
			{
				if (_wantedBlackboard == null)
				{
					_wantedBlackboard = (CHandle<gameIBlackboard>) CR2WTypeManager.Create("handle:gameIBlackboard", "wantedBlackboard", cr2w, this);
				}
				return _wantedBlackboard;
			}
			set
			{
				if (_wantedBlackboard == value)
				{
					return;
				}
				_wantedBlackboard = value;
				PropertySet(this);
			}
		}

		[Ordinal(11)] 
		[RED("wantedBlackboardDef")] 
		public CHandle<UI_WantedBarDef> WantedBlackboardDef
		{
			get
			{
				if (_wantedBlackboardDef == null)
				{
					_wantedBlackboardDef = (CHandle<UI_WantedBarDef>) CR2WTypeManager.Create("handle:UI_WantedBarDef", "wantedBlackboardDef", cr2w, this);
				}
				return _wantedBlackboardDef;
			}
			set
			{
				if (_wantedBlackboardDef == value)
				{
					return;
				}
				_wantedBlackboardDef = value;
				PropertySet(this);
			}
		}

		[Ordinal(12)] 
		[RED("wantedCallbackID")] 
		public CUInt32 WantedCallbackID
		{
			get
			{
				if (_wantedCallbackID == null)
				{
					_wantedCallbackID = (CUInt32) CR2WTypeManager.Create("Uint32", "wantedCallbackID", cr2w, this);
				}
				return _wantedCallbackID;
			}
			set
			{
				if (_wantedCallbackID == value)
				{
					return;
				}
				_wantedCallbackID = value;
				PropertySet(this);
			}
		}

		[Ordinal(13)] 
		[RED("animProxy")] 
		public CHandle<inkanimProxy> AnimProxy
		{
			get
			{
				if (_animProxy == null)
				{
					_animProxy = (CHandle<inkanimProxy>) CR2WTypeManager.Create("handle:inkanimProxy", "animProxy", cr2w, this);
				}
				return _animProxy;
			}
			set
			{
				if (_animProxy == value)
				{
					return;
				}
				_animProxy = value;
				PropertySet(this);
			}
		}

		[Ordinal(14)] 
		[RED("attentionAnimProxy")] 
		public CHandle<inkanimProxy> AttentionAnimProxy
		{
			get
			{
				if (_attentionAnimProxy == null)
				{
					_attentionAnimProxy = (CHandle<inkanimProxy>) CR2WTypeManager.Create("handle:inkanimProxy", "attentionAnimProxy", cr2w, this);
				}
				return _attentionAnimProxy;
			}
			set
			{
				if (_attentionAnimProxy == value)
				{
					return;
				}
				_attentionAnimProxy = value;
				PropertySet(this);
			}
		}

		[Ordinal(15)] 
		[RED("bountyAnimProxy")] 
		public CHandle<inkanimProxy> BountyAnimProxy
		{
			get
			{
				if (_bountyAnimProxy == null)
				{
					_bountyAnimProxy = (CHandle<inkanimProxy>) CR2WTypeManager.Create("handle:inkanimProxy", "bountyAnimProxy", cr2w, this);
				}
				return _bountyAnimProxy;
			}
			set
			{
				if (_bountyAnimProxy == value)
				{
					return;
				}
				_bountyAnimProxy = value;
				PropertySet(this);
			}
		}

		[Ordinal(16)] 
		[RED("animOptionsLoop")] 
		public inkanimPlaybackOptions AnimOptionsLoop
		{
			get
			{
				if (_animOptionsLoop == null)
				{
					_animOptionsLoop = (inkanimPlaybackOptions) CR2WTypeManager.Create("inkanimPlaybackOptions", "animOptionsLoop", cr2w, this);
				}
				return _animOptionsLoop;
			}
			set
			{
				if (_animOptionsLoop == value)
				{
					return;
				}
				_animOptionsLoop = value;
				PropertySet(this);
			}
		}

		[Ordinal(17)] 
		[RED("wantedLevel")] 
		public CInt32 WantedLevel
		{
			get
			{
				if (_wantedLevel == null)
				{
					_wantedLevel = (CInt32) CR2WTypeManager.Create("Int32", "wantedLevel", cr2w, this);
				}
				return _wantedLevel;
			}
			set
			{
				if (_wantedLevel == value)
				{
					return;
				}
				_wantedLevel = value;
				PropertySet(this);
			}
		}

		[Ordinal(18)] 
		[RED("rootWidget")] 
		public CHandle<inkWidget> RootWidget
		{
			get
			{
				if (_rootWidget == null)
				{
					_rootWidget = (CHandle<inkWidget>) CR2WTypeManager.Create("handle:inkWidget", "rootWidget", cr2w, this);
				}
				return _rootWidget;
			}
			set
			{
				if (_rootWidget == value)
				{
					return;
				}
				_rootWidget = value;
				PropertySet(this);
			}
		}

		[Ordinal(19)] 
		[RED("WANTED_TIER_1")] 
		public CFloat WANTED_TIER_1
		{
			get
			{
				if (_wANTED_TIER_1 == null)
				{
					_wANTED_TIER_1 = (CFloat) CR2WTypeManager.Create("Float", "WANTED_TIER_1", cr2w, this);
				}
				return _wANTED_TIER_1;
			}
			set
			{
				if (_wANTED_TIER_1 == value)
				{
					return;
				}
				_wANTED_TIER_1 = value;
				PropertySet(this);
			}
		}

		[Ordinal(20)] 
		[RED("WANTED_MIN")] 
		public CFloat WANTED_MIN
		{
			get
			{
				if (_wANTED_MIN == null)
				{
					_wANTED_MIN = (CFloat) CR2WTypeManager.Create("Float", "WANTED_MIN", cr2w, this);
				}
				return _wANTED_MIN;
			}
			set
			{
				if (_wANTED_MIN == value)
				{
					return;
				}
				_wANTED_MIN = value;
				PropertySet(this);
			}
		}

		public WantedBarGameController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
