using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameTransformAnimationDefinition : CVariable
	{
		private CName _name;
		private CBool _autoStart;
		private CFloat _autoStartDelay;
		private CUInt32 _timesToPlay;
		private CBool _looping;
		private CFloat _timeScale;
		private CBool _reverse;
		private gameTransformAnimationTimeline _timeline;

		[Ordinal(0)] 
		[RED("name")] 
		public CName Name
		{
			get
			{
				if (_name == null)
				{
					_name = (CName) CR2WTypeManager.Create("CName", "name", cr2w, this);
				}
				return _name;
			}
			set
			{
				if (_name == value)
				{
					return;
				}
				_name = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("autoStart")] 
		public CBool AutoStart
		{
			get
			{
				if (_autoStart == null)
				{
					_autoStart = (CBool) CR2WTypeManager.Create("Bool", "autoStart", cr2w, this);
				}
				return _autoStart;
			}
			set
			{
				if (_autoStart == value)
				{
					return;
				}
				_autoStart = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("autoStartDelay")] 
		public CFloat AutoStartDelay
		{
			get
			{
				if (_autoStartDelay == null)
				{
					_autoStartDelay = (CFloat) CR2WTypeManager.Create("Float", "autoStartDelay", cr2w, this);
				}
				return _autoStartDelay;
			}
			set
			{
				if (_autoStartDelay == value)
				{
					return;
				}
				_autoStartDelay = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("timesToPlay")] 
		public CUInt32 TimesToPlay
		{
			get
			{
				if (_timesToPlay == null)
				{
					_timesToPlay = (CUInt32) CR2WTypeManager.Create("Uint32", "timesToPlay", cr2w, this);
				}
				return _timesToPlay;
			}
			set
			{
				if (_timesToPlay == value)
				{
					return;
				}
				_timesToPlay = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("looping")] 
		public CBool Looping
		{
			get
			{
				if (_looping == null)
				{
					_looping = (CBool) CR2WTypeManager.Create("Bool", "looping", cr2w, this);
				}
				return _looping;
			}
			set
			{
				if (_looping == value)
				{
					return;
				}
				_looping = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("timeScale")] 
		public CFloat TimeScale
		{
			get
			{
				if (_timeScale == null)
				{
					_timeScale = (CFloat) CR2WTypeManager.Create("Float", "timeScale", cr2w, this);
				}
				return _timeScale;
			}
			set
			{
				if (_timeScale == value)
				{
					return;
				}
				_timeScale = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("reverse")] 
		public CBool Reverse
		{
			get
			{
				if (_reverse == null)
				{
					_reverse = (CBool) CR2WTypeManager.Create("Bool", "reverse", cr2w, this);
				}
				return _reverse;
			}
			set
			{
				if (_reverse == value)
				{
					return;
				}
				_reverse = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("timeline")] 
		public gameTransformAnimationTimeline Timeline
		{
			get
			{
				if (_timeline == null)
				{
					_timeline = (gameTransformAnimationTimeline) CR2WTypeManager.Create("gameTransformAnimationTimeline", "timeline", cr2w, this);
				}
				return _timeline;
			}
			set
			{
				if (_timeline == value)
				{
					return;
				}
				_timeline = value;
				PropertySet(this);
			}
		}

		public gameTransformAnimationDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
