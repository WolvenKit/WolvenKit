using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class audioAudioSceneStateOverride : CVariable
	{
		[Ordinal(0)]  [RED("enterEventOverride")] public CName EnterEventOverride { get; set; }
		[Ordinal(1)]  [RED("exitEventOverride")] public CName ExitEventOverride { get; set; }
		[Ordinal(2)]  [RED("templateStateName")] public CName TemplateStateName { get; set; }

		public audioAudioSceneStateOverride(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
