using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class RevealDeviceRequest : redEvent
	{
		[Ordinal(0)]  [RED("shouldReveal")] public CBool ShouldReveal { get; set; }
		[Ordinal(1)]  [RED("sourceID")] public entEntityID SourceID { get; set; }
		[Ordinal(2)]  [RED("linkData")] public SNetworkLinkData LinkData { get; set; }

		public RevealDeviceRequest(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
