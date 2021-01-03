using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class UnregisterNetworkLinkBetweenTwoEntitiesRequest : gameScriptableSystemRequest
	{
		[Ordinal(0)]  [RED("firstID")] public entEntityID FirstID { get; set; }
		[Ordinal(1)]  [RED("onlyRemoveWeakLink")] public CBool OnlyRemoveWeakLink { get; set; }
		[Ordinal(2)]  [RED("secondID")] public entEntityID SecondID { get; set; }

		public UnregisterNetworkLinkBetweenTwoEntitiesRequest(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
