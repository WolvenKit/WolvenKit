using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class ChangeMusicAction : ActionBool
	{
		[Ordinal(0)]  [RED("interactionRecordName")] public CString InteractionRecordName { get; set; }
		[Ordinal(1)]  [RED("settings")] public CHandle<MusicSettings> Settings { get; set; }

		public ChangeMusicAction(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
