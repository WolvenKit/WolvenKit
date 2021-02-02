using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class gameBinkComponent : entIVisualComponent
	{
		[Ordinal(0)]  [RED("meshTargetBinding")] public CHandle<gameBinkMeshTargetBinding> MeshTargetBinding { get; set; }
		[Ordinal(1)]  [RED("binkResource")] public raRef<Bink> BinkResource { get; set; }
		[Ordinal(2)]  [RED("videoPlayerName")] public CName VideoPlayerName { get; set; }
		[Ordinal(3)]  [RED("audioEvent")] public CName AudioEvent { get; set; }
		[Ordinal(4)]  [RED("loopVideo")] public CBool LoopVideo { get; set; }
		[Ordinal(5)]  [RED("forceVideoFrameRate")] public CBool ForceVideoFrameRate { get; set; }

		public gameBinkComponent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
