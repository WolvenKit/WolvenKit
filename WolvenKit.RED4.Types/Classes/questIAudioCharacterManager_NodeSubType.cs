using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class questIAudioCharacterManager_NodeSubType : questINodeType
	{
		private CArray<questIAudioCharacterManager_NodeSubTypeCharacterEntry> _characterEntries;

		[Ordinal(0)] 
		[RED("characterEntries")] 
		public CArray<questIAudioCharacterManager_NodeSubTypeCharacterEntry> CharacterEntries
		{
			get => GetProperty(ref _characterEntries);
			set => SetProperty(ref _characterEntries, value);
		}
	}
}
