using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class PlaybackOptionsUpdateData : IScriptable
	{
		[Ordinal(0)] [RED("playbackOptions")] public inkanimPlaybackOptions PlaybackOptions { get; set; }

		public PlaybackOptionsUpdateData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
