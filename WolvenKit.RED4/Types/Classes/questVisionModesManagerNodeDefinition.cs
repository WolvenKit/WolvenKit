using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class questVisionModesManagerNodeDefinition : questDisableableNodeDefinition
	{
		[Ordinal(2)] 
		[RED("type")] 
		public CHandle<questIVisionModeNodeType> Type
		{
			get => GetPropertyValue<CHandle<questIVisionModeNodeType>>();
			set => SetPropertyValue<CHandle<questIVisionModeNodeType>>(value);
		}

		public questVisionModesManagerNodeDefinition()
		{
			Sockets = new();
			Id = 65535;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
