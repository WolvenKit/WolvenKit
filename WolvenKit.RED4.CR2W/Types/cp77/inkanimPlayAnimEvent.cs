using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class inkanimPlayAnimEvent : inkanimEvent
	{
		private CName _animName;
		private inkanimPlaybackOptions _playbackOptions;

		[Ordinal(1)] 
		[RED("animName")] 
		public CName AnimName
		{
			get
			{
				if (_animName == null)
				{
					_animName = (CName) CR2WTypeManager.Create("CName", "animName", cr2w, this);
				}
				return _animName;
			}
			set
			{
				if (_animName == value)
				{
					return;
				}
				_animName = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
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

		public inkanimPlayAnimEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
