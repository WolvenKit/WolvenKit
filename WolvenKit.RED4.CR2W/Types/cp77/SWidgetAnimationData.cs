using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class SWidgetAnimationData : CVariable
	{
		private CName _animationName;
		private inkanimPlaybackOptions _playbackOptions;
		private CBool _lockWhenActive;
		private CHandle<inkanimProxy> _animProxy;
		private CName _onFinish;
		private CName _onStart;
		private CName _onPasue;
		private CName _onResume;
		private CName _onStartLoop;
		private CName _onEndLoop;

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
		[RED("playbackOptions")] 
		public inkanimPlaybackOptions PlaybackOptions
		{
			get
			{
				if (_playbackOptions == null)
				{
					_playbackOptions = (inkanimPlaybackOptions) CR2WTypeManager.Create("inkanimPlaybackOptions", "playbackOptions", cr2w, this);
				}
				return _playbackOptions;
			}
			set
			{
				if (_playbackOptions == value)
				{
					return;
				}
				_playbackOptions = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("lockWhenActive")] 
		public CBool LockWhenActive
		{
			get
			{
				if (_lockWhenActive == null)
				{
					_lockWhenActive = (CBool) CR2WTypeManager.Create("Bool", "lockWhenActive", cr2w, this);
				}
				return _lockWhenActive;
			}
			set
			{
				if (_lockWhenActive == value)
				{
					return;
				}
				_lockWhenActive = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
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

		[Ordinal(4)] 
		[RED("onFinish")] 
		public CName OnFinish
		{
			get
			{
				if (_onFinish == null)
				{
					_onFinish = (CName) CR2WTypeManager.Create("CName", "onFinish", cr2w, this);
				}
				return _onFinish;
			}
			set
			{
				if (_onFinish == value)
				{
					return;
				}
				_onFinish = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("onStart")] 
		public CName OnStart
		{
			get
			{
				if (_onStart == null)
				{
					_onStart = (CName) CR2WTypeManager.Create("CName", "onStart", cr2w, this);
				}
				return _onStart;
			}
			set
			{
				if (_onStart == value)
				{
					return;
				}
				_onStart = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("onPasue")] 
		public CName OnPasue
		{
			get
			{
				if (_onPasue == null)
				{
					_onPasue = (CName) CR2WTypeManager.Create("CName", "onPasue", cr2w, this);
				}
				return _onPasue;
			}
			set
			{
				if (_onPasue == value)
				{
					return;
				}
				_onPasue = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("onResume")] 
		public CName OnResume
		{
			get
			{
				if (_onResume == null)
				{
					_onResume = (CName) CR2WTypeManager.Create("CName", "onResume", cr2w, this);
				}
				return _onResume;
			}
			set
			{
				if (_onResume == value)
				{
					return;
				}
				_onResume = value;
				PropertySet(this);
			}
		}

		[Ordinal(8)] 
		[RED("onStartLoop")] 
		public CName OnStartLoop
		{
			get
			{
				if (_onStartLoop == null)
				{
					_onStartLoop = (CName) CR2WTypeManager.Create("CName", "onStartLoop", cr2w, this);
				}
				return _onStartLoop;
			}
			set
			{
				if (_onStartLoop == value)
				{
					return;
				}
				_onStartLoop = value;
				PropertySet(this);
			}
		}

		[Ordinal(9)] 
		[RED("onEndLoop")] 
		public CName OnEndLoop
		{
			get
			{
				if (_onEndLoop == null)
				{
					_onEndLoop = (CName) CR2WTypeManager.Create("CName", "onEndLoop", cr2w, this);
				}
				return _onEndLoop;
			}
			set
			{
				if (_onEndLoop == value)
				{
					return;
				}
				_onEndLoop = value;
				PropertySet(this);
			}
		}

		public SWidgetAnimationData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
