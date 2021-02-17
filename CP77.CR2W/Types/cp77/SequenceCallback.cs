using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class SequenceCallback : redEvent
	{
		[Ordinal(0)] [RED("persistentID")] public gamePersistentID PersistentID { get; set; }
		[Ordinal(1)] [RED("className")] public CName ClassName { get; set; }
		[Ordinal(2)] [RED("actionToForward")] public CHandle<ScriptableDeviceAction> ActionToForward { get; set; }

		public SequenceCallback(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
