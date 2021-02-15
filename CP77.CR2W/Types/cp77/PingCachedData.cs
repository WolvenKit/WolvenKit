using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class PingCachedData : IScriptable
	{
		[Ordinal(0)] [RED("sourceID")] public entEntityID SourceID { get; set; }
		[Ordinal(1)] [RED("pingType")] public CEnum<EPingType> PingType { get; set; }
		[Ordinal(2)] [RED("pingNetworkEffect")] public CHandle<gameEffectInstance> PingNetworkEffect { get; set; }
		[Ordinal(3)] [RED("timeout")] public CFloat Timeout { get; set; }
		[Ordinal(4)] [RED("ammountOfIntervals")] public CInt32 AmmountOfIntervals { get; set; }
		[Ordinal(5)] [RED("linksCount")] public CInt32 LinksCount { get; set; }
		[Ordinal(6)] [RED("currentInterval")] public CInt32 CurrentInterval { get; set; }
		[Ordinal(7)] [RED("delayID")] public gameDelayID DelayID { get; set; }
		[Ordinal(8)] [RED("linkType")] public CEnum<ELinkType> LinkType { get; set; }
		[Ordinal(9)] [RED("revealNetwork")] public CBool RevealNetwork { get; set; }
		[Ordinal(10)] [RED("linkFXresource")] public gameFxResource LinkFXresource { get; set; }
		[Ordinal(11)] [RED("sourcePosition")] public Vector4 SourcePosition { get; set; }
		[Ordinal(12)] [RED("hasActiveVirtualNetwork")] public CBool HasActiveVirtualNetwork { get; set; }
		[Ordinal(13)] [RED("virtualNetworkShape")] public wCHandle<gamedataVirtualNetwork_Record> VirtualNetworkShape { get; set; }

		public PingCachedData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
