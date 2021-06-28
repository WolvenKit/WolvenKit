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
			get => GetProperty(ref _playbackOptions);
			set => SetProperty(ref _playbackOptions, value);
		}

		public PlaybackOptionsUpdateData(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
