using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class InitializationSoundController : inkWidgetLogicController
	{
		[Ordinal(0)]  [RED("soundControlName")] public CName SoundControlName { get; set; }
		[Ordinal(1)]  [RED("initializeSoundName")] public CName InitializeSoundName { get; set; }
		[Ordinal(2)]  [RED("unitializeSoundName")] public CName UnitializeSoundName { get; set; }

		public InitializationSoundController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
