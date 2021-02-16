using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class audioAudioSceneData : audioAudioMetadata
	{
		[Ordinal(1)] [RED("anyStateArray", 1)] public CArrayFixedSize<audioAudioStateData> AnyStateArray { get; set; }
		[Ordinal(2)] [RED("states")] public CArray<audioAudioStateData> States { get; set; }
		[Ordinal(3)] [RED("anyStateTransitionsTable")] public CArray<audioAnyStateTransitionEntry> AnyStateTransitionsTable { get; set; }
		[Ordinal(4)] [RED("voLineSignals")] public CArray<audioVoLineSignal> VoLineSignals { get; set; }
		[Ordinal(5)] [RED("signalLeadingToShutdown")] public CName SignalLeadingToShutdown { get; set; }
		[Ordinal(6)] [RED("templateScene")] public CName TemplateScene { get; set; }
		[Ordinal(7)] [RED("templateSceneStateOverrides")] public CArray<audioAudioSceneStateOverride> TemplateSceneStateOverrides { get; set; }
		[Ordinal(8)] [RED("templateSceneSignalOverrides")] public CArray<audioAudioSceneSignalOverride> TemplateSceneSignalOverrides { get; set; }

		public audioAudioSceneData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
