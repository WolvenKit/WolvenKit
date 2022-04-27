using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class audioCpoConversation : audioAudioMetadata
	{
		[Ordinal(1)] 
		[RED("characterOne")] 
		public CEnum<audioVoCpoCharacter> CharacterOne
		{
			get => GetPropertyValue<CEnum<audioVoCpoCharacter>>();
			set => SetPropertyValue<CEnum<audioVoCpoCharacter>>(value);
		}

		[Ordinal(2)] 
		[RED("characterTwo")] 
		public CEnum<audioVoCpoCharacter> CharacterTwo
		{
			get => GetPropertyValue<CEnum<audioVoCpoCharacter>>();
			set => SetPropertyValue<CEnum<audioVoCpoCharacter>>(value);
		}

		[Ordinal(3)] 
		[RED("voTriggers")] 
		public CArray<CName> VoTriggers
		{
			get => GetPropertyValue<CArray<CName>>();
			set => SetPropertyValue<CArray<CName>>(value);
		}

		public audioCpoConversation()
		{
			VoTriggers = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
