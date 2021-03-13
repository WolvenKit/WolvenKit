using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class audioAudioSceneSignalOverride : CVariable
	{
		[Ordinal(0)] [RED("templateSignal")] public CName TemplateSignal { get; set; }
		[Ordinal(1)] [RED("signalOverride")] public CName SignalOverride { get; set; }

		public audioAudioSceneSignalOverride(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
