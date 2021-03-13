using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class audioVoiceTriggerLimitsMap : audioAudioMetadata
	{
		[Ordinal(1)] [RED("includes")] public CArray<CName> Includes { get; set; }
		[Ordinal(2)] [RED("triggers")] public CArray<audioVoiceTriggerLimitsMapItem> Triggers { get; set; }

		public audioVoiceTriggerLimitsMap(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
