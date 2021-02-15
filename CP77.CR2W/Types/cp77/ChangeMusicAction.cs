using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class ChangeMusicAction : ActionBool
	{
		[Ordinal(25)] [RED("interactionRecordName")] public CString InteractionRecordName { get; set; }
		[Ordinal(26)] [RED("settings")] public CHandle<MusicSettings> Settings { get; set; }

		public ChangeMusicAction(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
