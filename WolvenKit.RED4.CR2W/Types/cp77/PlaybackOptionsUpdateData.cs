using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class PlaybackOptionsUpdateData : IScriptable
	{
		private inkanimPlaybackOptions _playbackOptions;

		[Ordinal(0)] 
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

		public PlaybackOptionsUpdateData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
