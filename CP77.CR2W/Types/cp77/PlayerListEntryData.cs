using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class PlayerListEntryData : CVariable
	{
		[Ordinal(0)] [RED("playerObject")] public wCHandle<gameObject> PlayerObject { get; set; }
		[Ordinal(1)] [RED("playerListEntry")] public wCHandle<inkWidget> PlayerListEntry { get; set; }

		public PlayerListEntryData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
