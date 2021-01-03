using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class gameBinkComponent : entIVisualComponent
	{
		[Ordinal(0)]  [RED("audioEvent")] public CName AudioEvent { get; set; }
		[Ordinal(1)]  [RED("binkResource")] public raRef<Bink> BinkResource { get; set; }
		[Ordinal(2)]  [RED("forceVideoFrameRate")] public CBool ForceVideoFrameRate { get; set; }
		[Ordinal(3)]  [RED("isEnabled")] public CBool IsEnabled { get; set; }
		[Ordinal(4)]  [RED("loopVideo")] public CBool LoopVideo { get; set; }
		[Ordinal(5)]  [RED("meshTargetBinding")] public CHandle<gameBinkMeshTargetBinding> MeshTargetBinding { get; set; }
		[Ordinal(6)]  [RED("videoPlayerName")] public CName VideoPlayerName { get; set; }

		public gameBinkComponent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
