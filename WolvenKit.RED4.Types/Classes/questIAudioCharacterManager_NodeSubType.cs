using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class questIAudioCharacterManager_NodeSubType : questINodeType
	{
		[Ordinal(0)] 
		[RED("characterEntries")] 
		public CArray<questIAudioCharacterManager_NodeSubTypeCharacterEntry> CharacterEntries
		{
			get => GetPropertyValue<CArray<questIAudioCharacterManager_NodeSubTypeCharacterEntry>>();
			set => SetPropertyValue<CArray<questIAudioCharacterManager_NodeSubTypeCharacterEntry>>(value);
		}

		public questIAudioCharacterManager_NodeSubType()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
