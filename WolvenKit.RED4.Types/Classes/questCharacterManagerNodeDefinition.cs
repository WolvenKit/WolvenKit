using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class questCharacterManagerNodeDefinition : questSignalStoppingNodeDefinition
	{
		[Ordinal(2)] 
		[RED("type")] 
		public CHandle<questICharacterManager_NodeType> Type
		{
			get => GetPropertyValue<CHandle<questICharacterManager_NodeType>>();
			set => SetPropertyValue<CHandle<questICharacterManager_NodeType>>(value);
		}

		public questCharacterManagerNodeDefinition()
		{
			Sockets = new();
			Id = 65535;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
