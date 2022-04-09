using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class questFactsDBManagerNodeDefinition : questDisableableNodeDefinition
	{
		[Ordinal(2)] 
		[RED("type")] 
		public CHandle<questIFactsDBManagerNodeType> Type
		{
			get => GetPropertyValue<CHandle<questIFactsDBManagerNodeType>>();
			set => SetPropertyValue<CHandle<questIFactsDBManagerNodeType>>(value);
		}

		public questFactsDBManagerNodeDefinition()
		{
			Sockets = new();
			Id = 65535;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
