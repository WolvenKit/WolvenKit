using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class StartPingingNetworkRequest : gameScriptableSystemRequest
	{
		[Ordinal(0)] [RED("source")] public wCHandle<gameObject> Source { get; set; }
		[Ordinal(1)] [RED("fxResource")] public gameFxResource FxResource { get; set; }
		[Ordinal(2)] [RED("duration")] public CFloat Duration { get; set; }
		[Ordinal(3)] [RED("pingType")] public CEnum<EPingType> PingType { get; set; }
		[Ordinal(4)] [RED("fakeLinkType")] public CEnum<ELinkType> FakeLinkType { get; set; }
		[Ordinal(5)] [RED("revealNetworkAtEnd")] public CBool RevealNetworkAtEnd { get; set; }
		[Ordinal(6)] [RED("virtualNetworkShapeID")] public TweakDBID VirtualNetworkShapeID { get; set; }

		public StartPingingNetworkRequest(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
