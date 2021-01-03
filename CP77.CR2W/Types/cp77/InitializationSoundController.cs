using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class InitializationSoundController : inkWidgetLogicController
	{
		[Ordinal(0)]  [RED("initializeSoundName")] public CName InitializeSoundName { get; set; }
		[Ordinal(1)]  [RED("soundControlName")] public CName SoundControlName { get; set; }
		[Ordinal(2)]  [RED("unitializeSoundName")] public CName UnitializeSoundName { get; set; }

		public InitializationSoundController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
