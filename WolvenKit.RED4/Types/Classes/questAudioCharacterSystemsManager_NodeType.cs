using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class questAudioCharacterSystemsManager_NodeType : questIAudioCharacterManager_NodeType
	{
		[Ordinal(0)] 
		[RED("subType")] 
		public CHandle<questIAudioCharacterManager_NodeSubType> SubType
		{
			get => GetPropertyValue<CHandle<questIAudioCharacterManager_NodeSubType>>();
			set => SetPropertyValue<CHandle<questIAudioCharacterManager_NodeSubType>>(value);
		}

		public questAudioCharacterSystemsManager_NodeType()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
