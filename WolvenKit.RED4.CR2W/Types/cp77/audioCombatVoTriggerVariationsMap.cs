using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class audioCombatVoTriggerVariationsMap : audioAudioMetadata
	{
		[Ordinal(1)] [RED("voTriggerVariations")] public CArray<audioCombatVoTriggerVariationsMapItem> VoTriggerVariations { get; set; }

		public audioCombatVoTriggerVariationsMap(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
