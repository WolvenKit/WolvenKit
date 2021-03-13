using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameAudioSyncs : CVariable
	{
		[Ordinal(0)] [RED("switchEvents")] public CArray<audioAudSwitch> SwitchEvents { get; set; }
		[Ordinal(1)] [RED("playEvents")] public CArray<audioAudEventStruct> PlayEvents { get; set; }
		[Ordinal(2)] [RED("stopEvents")] public CArray<audioAudEventStruct> StopEvents { get; set; }
		[Ordinal(3)] [RED("parameterEvents")] public CArray<audioAudParameter> ParameterEvents { get; set; }

		public gameAudioSyncs(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
