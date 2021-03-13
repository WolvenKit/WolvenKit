using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class audioKeyUiSoundPairDictionaryItem : audioInlinedAudioMetadata
	{
		[Ordinal(1)] [RED("key")] public CName Key { get; set; }
		[Ordinal(2)] [RED("value")] public audioUiSound Value { get; set; }

		public audioKeyUiSoundPairDictionaryItem(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
