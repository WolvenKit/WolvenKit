using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class NetworkLinkQuickhackEvent : redEvent
	{
		[Ordinal(0)]  [RED("from")] public entEntityID From { get; set; }
		[Ordinal(1)]  [RED("netrunnerID")] public entEntityID NetrunnerID { get; set; }
		[Ordinal(2)]  [RED("proxyID")] public entEntityID ProxyID { get; set; }
		[Ordinal(3)]  [RED("targetID")] public entEntityID TargetID { get; set; }
		[Ordinal(4)]  [RED("to")] public entEntityID To { get; set; }

		public NetworkLinkQuickhackEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
