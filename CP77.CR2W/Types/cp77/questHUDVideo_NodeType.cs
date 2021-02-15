using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class questHUDVideo_NodeType : questIUIManagerNodeType
	{
		[Ordinal(0)] [RED("video")] public raRef<Bink> Video { get; set; }
		[Ordinal(1)] [RED("skippable")] public CBool Skippable { get; set; }
		[Ordinal(2)] [RED("audioEvent")] public CName AudioEvent { get; set; }
		[Ordinal(3)] [RED("syncToAudio")] public CBool SyncToAudio { get; set; }
		[Ordinal(4)] [RED("retriggerAudioOnLoop")] public CBool RetriggerAudioOnLoop { get; set; }
		[Ordinal(5)] [RED("looped")] public CBool Looped { get; set; }
		[Ordinal(6)] [RED("forceVideoFrameRate")] public CBool ForceVideoFrameRate { get; set; }
		[Ordinal(7)] [RED("playOnHud")] public CBool PlayOnHud { get; set; }
		[Ordinal(8)] [RED("fullScreen")] public CBool FullScreen { get; set; }
		[Ordinal(9)] [RED("position")] public Vector2 Position { get; set; }
		[Ordinal(10)] [RED("size")] public Vector2 Size { get; set; }

		public questHUDVideo_NodeType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
