using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class questSceneManagerNodeDefinition : questSignalStoppingNodeDefinition
	{
		[Ordinal(2)] 
		[RED("type")] 
		public CHandle<questISceneManagerNodeType> Type
		{
			get => GetPropertyValue<CHandle<questISceneManagerNodeType>>();
			set => SetPropertyValue<CHandle<questISceneManagerNodeType>>(value);
		}

		public questSceneManagerNodeDefinition()
		{
			Sockets = new();
			Id = 65535;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
