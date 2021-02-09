using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class ForwardAction : redEvent
	{
		[Ordinal(0)]  [RED("requester")] public gamePersistentID Requester { get; set; }
		[Ordinal(1)]  [RED("actionToForward")] public CHandle<ScriptableDeviceAction> ActionToForward { get; set; }

		public ForwardAction(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
