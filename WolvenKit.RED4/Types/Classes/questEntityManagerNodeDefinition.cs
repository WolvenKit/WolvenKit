using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class questEntityManagerNodeDefinition : questDisableableNodeDefinition
	{
		[Ordinal(2)] 
		[RED("type")] 
		public CHandle<questIEntityManager_NodeType> Type
		{
			get => GetPropertyValue<CHandle<questIEntityManager_NodeType>>();
			set => SetPropertyValue<CHandle<questIEntityManager_NodeType>>(value);
		}

		public questEntityManagerNodeDefinition()
		{
			Sockets = new();
			Id = 65535;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
