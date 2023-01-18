using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class questCrowdManagerNodeDefinition : questDisableableNodeDefinition
	{
		[Ordinal(2)] 
		[RED("type")] 
		public CHandle<questICrowdManager_NodeType> Type
		{
			get => GetPropertyValue<CHandle<questICrowdManager_NodeType>>();
			set => SetPropertyValue<CHandle<questICrowdManager_NodeType>>(value);
		}

		public questCrowdManagerNodeDefinition()
		{
			Sockets = new();
			Id = 65535;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
