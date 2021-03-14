using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class audioMeleeHitTypeMeleeSoundDictionaryItem : audioInlinedAudioMetadata
	{
		[Ordinal(1)] [RED("key")] public CEnum<audioMeleeHitPerMaterialType> Key { get; set; }
		[Ordinal(2)] [RED("value")] public audioMeleeSound Value { get; set; }

		public audioMeleeHitTypeMeleeSoundDictionaryItem(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
