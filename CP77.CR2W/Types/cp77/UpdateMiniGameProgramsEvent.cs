using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class UpdateMiniGameProgramsEvent : redEvent
	{
		[Ordinal(0)]  [RED("add")] public CBool Add { get; set; }
		[Ordinal(1)]  [RED("program")] public gameuiMinigameProgramData Program { get; set; }

		public UpdateMiniGameProgramsEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
