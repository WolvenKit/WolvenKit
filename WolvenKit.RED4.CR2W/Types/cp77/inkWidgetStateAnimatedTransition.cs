using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class inkWidgetStateAnimatedTransition : CVariable
	{
		private CName _startState;
		private CName _endState;
		private CName _animationName;
		private inkanimPlaybackOptions _playbackOptions;

		[Ordinal(0)] 
		[RED("startState")] 
		public CName StartState
		{
			get
			{
				if (_startState == null)
				{
					_startState = (CName) CR2WTypeManager.Create("CName", "startState", cr2w, this);
				}
				return _startState;
			}
			set
			{
				if (_startState == value)
				{
					return;
				}
				_startState = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("endState")] 
		public CName EndState
		{
			get
			{
				if (_endState == null)
				{
					_endState = (CName) CR2WTypeManager.Create("CName", "endState", cr2w, this);
				}
				return _endState;
			}
			set
			{
				if (_endState == value)
				{
					return;
				}
				_endState = value;
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

		public inkWidgetStateAnimatedTransition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
