using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class DisarmComponent : gameScriptableComponent
	{
		[Ordinal(5)] [RED("isDisarmingOngoing")] public CBool IsDisarmingOngoing { get; set; }
		[Ordinal(6)] [RED("owner")] public wCHandle<gameObject> Owner { get; set; }
		[Ordinal(7)] [RED("requester")] public wCHandle<gameObject> Requester { get; set; }

		public DisarmComponent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
