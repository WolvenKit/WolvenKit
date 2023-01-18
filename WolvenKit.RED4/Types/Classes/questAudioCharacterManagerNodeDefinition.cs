using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class questAudioCharacterManagerNodeDefinition : questDisableableNodeDefinition
	{
		[Ordinal(2)] 
		[RED("type")] 
		public CHandle<questIAudioCharacterManager_NodeType> Type
		{
			get => GetPropertyValue<CHandle<questIAudioCharacterManager_NodeType>>();
			set => SetPropertyValue<CHandle<questIAudioCharacterManager_NodeType>>(value);
		}

		public questAudioCharacterManagerNodeDefinition()
		{
			Sockets = new();
			Id = 65535;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
