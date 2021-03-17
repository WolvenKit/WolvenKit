using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class audioMeleeHitTypeMeleeSoundDictionaryItem : audioInlinedAudioMetadata
	{
		private CEnum<audioMeleeHitPerMaterialType> _key;
		private audioMeleeSound _value;

		[Ordinal(1)] 
		[RED("key")] 
		public CEnum<audioMeleeHitPerMaterialType> Key
		{
			get => GetProperty(ref _key);
			set => SetProperty(ref _key, value);
		}

		[Ordinal(2)] 
		[RED("value")] 
		public audioMeleeSound Value
		{
			get => GetProperty(ref _value);
			set => SetProperty(ref _value, value);
		}

		public audioMeleeHitTypeMeleeSoundDictionaryItem(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
