using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class gameuiHUDVideoStartEvent : CVariable
	{
		[Ordinal(0)]  [RED("videoPathHash")] public CUInt64 VideoPathHash { get; set; }
		[Ordinal(1)]  [RED("playOnHud")] public CBool PlayOnHud { get; set; }
		[Ordinal(2)]  [RED("fullScreen")] public CBool FullScreen { get; set; }
		[Ordinal(3)]  [RED("position")] public Vector2 Position { get; set; }
		[Ordinal(4)]  [RED("size")] public Vector2 Size { get; set; }
		[Ordinal(5)]  [RED("skippable")] public CBool Skippable { get; set; }
		[Ordinal(6)]  [RED("isLooped")] public CBool IsLooped { get; set; }
		[Ordinal(7)]  [RED("forceVideoFrameRate")] public CBool ForceVideoFrameRate { get; set; }

		public gameuiHUDVideoStartEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
