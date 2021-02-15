using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class audioCombatVoTriggerVariationsMap : audioAudioMetadata
	{
		[Ordinal(1)] [RED("voTriggerVariations")] public CArray<audioCombatVoTriggerVariationsMapItem> VoTriggerVariations { get; set; }

		public audioCombatVoTriggerVariationsMap(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
