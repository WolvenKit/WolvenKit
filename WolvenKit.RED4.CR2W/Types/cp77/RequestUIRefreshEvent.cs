using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class RequestUIRefreshEvent : redEvent
	{
		[Ordinal(0)] [RED("requester")] public gamePersistentID Requester { get; set; }
		[Ordinal(1)] [RED("context")] public CName Context { get; set; }

		public RequestUIRefreshEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
