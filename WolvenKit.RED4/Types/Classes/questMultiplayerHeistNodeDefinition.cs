using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class questMultiplayerHeistNodeDefinition : questDisableableNodeDefinition
	{
		[Ordinal(2)] 
		[RED("type")] 
		public CHandle<questIMultiplayerHeistNodeType> Type
		{
			get => GetPropertyValue<CHandle<questIMultiplayerHeistNodeType>>();
			set => SetPropertyValue<CHandle<questIMultiplayerHeistNodeType>>(value);
		}

		public questMultiplayerHeistNodeDefinition()
		{
			Sockets = new();
			Id = ushort.MaxValue;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
