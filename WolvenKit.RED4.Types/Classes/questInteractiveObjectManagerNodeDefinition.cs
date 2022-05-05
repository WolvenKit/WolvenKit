using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class questInteractiveObjectManagerNodeDefinition : questDisableableNodeDefinition
	{
		[Ordinal(2)] 
		[RED("type")] 
		public CHandle<questIInteractiveObjectManagerNodeType> Type
		{
			get => GetPropertyValue<CHandle<questIInteractiveObjectManagerNodeType>>();
			set => SetPropertyValue<CHandle<questIInteractiveObjectManagerNodeType>>(value);
		}

		public questInteractiveObjectManagerNodeDefinition()
		{
			Sockets = new();
			Id = 65535;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
