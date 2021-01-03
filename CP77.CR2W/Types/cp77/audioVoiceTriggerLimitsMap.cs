using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class audioVoiceTriggerLimitsMap : audioAudioMetadata
	{
		[Ordinal(0)]  [RED("includes")] public CArray<CName> Includes { get; set; }
		[Ordinal(1)]  [RED("triggers")] public CArray<audioVoiceTriggerLimitsMapItem> Triggers { get; set; }

		public audioVoiceTriggerLimitsMap(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
