using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class questFXManagerNodeDefinition : questDisableableNodeDefinition
	{
		[Ordinal(2)] 
		[RED("type")] 
		public CHandle<questIFXManagerNodeType> Type
		{
			get => GetPropertyValue<CHandle<questIFXManagerNodeType>>();
			set => SetPropertyValue<CHandle<questIFXManagerNodeType>>(value);
		}

		public questFXManagerNodeDefinition()
		{
			Sockets = new();
			Id = 65535;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
