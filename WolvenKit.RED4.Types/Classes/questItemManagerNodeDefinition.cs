using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class questItemManagerNodeDefinition : questDisableableNodeDefinition
	{
		[Ordinal(2)] 
		[RED("type")] 
		public CHandle<questIItemManagerNodeType> Type
		{
			get => GetPropertyValue<CHandle<questIItemManagerNodeType>>();
			set => SetPropertyValue<CHandle<questIItemManagerNodeType>>(value);
		}

		public questItemManagerNodeDefinition()
		{
			Sockets = new();
			Id = 65535;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
