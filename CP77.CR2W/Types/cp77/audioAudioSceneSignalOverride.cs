using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class audioAudioSceneSignalOverride : CVariable
	{
		[Ordinal(0)]  [RED("signalOverride")] public CName SignalOverride { get; set; }
		[Ordinal(1)]  [RED("templateSignal")] public CName TemplateSignal { get; set; }

		public audioAudioSceneSignalOverride(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
