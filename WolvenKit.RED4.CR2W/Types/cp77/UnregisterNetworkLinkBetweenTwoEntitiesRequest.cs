using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class UnregisterNetworkLinkBetweenTwoEntitiesRequest : gameScriptableSystemRequest
	{
		[Ordinal(0)] [RED("firstID")] public entEntityID FirstID { get; set; }
		[Ordinal(1)] [RED("secondID")] public entEntityID SecondID { get; set; }
		[Ordinal(2)] [RED("onlyRemoveWeakLink")] public CBool OnlyRemoveWeakLink { get; set; }

		public UnregisterNetworkLinkBetweenTwoEntitiesRequest(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
