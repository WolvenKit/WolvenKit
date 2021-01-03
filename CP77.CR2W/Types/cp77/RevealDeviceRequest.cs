using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class RevealDeviceRequest : redEvent
	{
		[Ordinal(0)]  [RED("linkData")] public SNetworkLinkData LinkData { get; set; }
		[Ordinal(1)]  [RED("shouldReveal")] public CBool ShouldReveal { get; set; }
		[Ordinal(2)]  [RED("sourceID")] public entEntityID SourceID { get; set; }

		public RevealDeviceRequest(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
