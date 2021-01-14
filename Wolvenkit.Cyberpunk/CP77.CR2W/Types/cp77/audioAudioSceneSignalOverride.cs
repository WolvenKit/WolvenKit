using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class audioAudioSceneSignalOverride : CVariable
	{
		[Ordinal(0)]  [RED("signalOverride")] public CName SignalOverride { get; set; }
		[Ordinal(1)]  [RED("templateSignal")] public CName TemplateSignal { get; set; }

		public audioAudioSceneSignalOverride(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
