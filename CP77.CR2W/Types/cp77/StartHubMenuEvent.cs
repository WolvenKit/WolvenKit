using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class StartHubMenuEvent : redEvent
	{
		[Ordinal(0)] [RED("initData")] public CHandle<HubMenuInitData> InitData { get; set; }

		public StartHubMenuEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
