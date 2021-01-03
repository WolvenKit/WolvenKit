using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class gameuiHUDVideoStartEvent : CVariable
	{
		[Ordinal(0)]  [RED("forceVideoFrameRate")] public CBool ForceVideoFrameRate { get; set; }
		[Ordinal(1)]  [RED("fullScreen")] public CBool FullScreen { get; set; }
		[Ordinal(2)]  [RED("isLooped")] public CBool IsLooped { get; set; }
		[Ordinal(3)]  [RED("playOnHud")] public CBool PlayOnHud { get; set; }
		[Ordinal(4)]  [RED("position")] public Vector2 Position { get; set; }
		[Ordinal(5)]  [RED("size")] public Vector2 Size { get; set; }
		[Ordinal(6)]  [RED("skippable")] public CBool Skippable { get; set; }
		[Ordinal(7)]  [RED("videoPathHash")] public CUInt64 VideoPathHash { get; set; }

		public gameuiHUDVideoStartEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
