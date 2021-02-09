using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class UnregisterNetworkLinkBetweenTwoEntitiesRequest : gameScriptableSystemRequest
	{
		[Ordinal(0)]  [RED("firstID")] public entEntityID FirstID { get; set; }
		[Ordinal(1)]  [RED("secondID")] public entEntityID SecondID { get; set; }
		[Ordinal(2)]  [RED("onlyRemoveWeakLink")] public CBool OnlyRemoveWeakLink { get; set; }

		public UnregisterNetworkLinkBetweenTwoEntitiesRequest(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
