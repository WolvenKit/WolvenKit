using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class QuestForceCameraZoom : ActionBool
	{
		[Ordinal(25)] [RED("useWorkspot")] public CBool UseWorkspot { get; set; }

		public QuestForceCameraZoom(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
