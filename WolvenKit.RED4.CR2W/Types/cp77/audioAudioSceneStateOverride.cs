using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class audioAudioSceneStateOverride : CVariable
	{
		[Ordinal(0)] [RED("templateStateName")] public CName TemplateStateName { get; set; }
		[Ordinal(1)] [RED("enterEventOverride")] public CName EnterEventOverride { get; set; }
		[Ordinal(2)] [RED("exitEventOverride")] public CName ExitEventOverride { get; set; }

		public audioAudioSceneStateOverride(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
