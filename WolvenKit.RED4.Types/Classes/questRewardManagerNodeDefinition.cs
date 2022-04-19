using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class questRewardManagerNodeDefinition : questDisableableNodeDefinition
	{
		[Ordinal(2)] 
		[RED("type")] 
		public CHandle<questIRewardManagerNodeType> Type
		{
			get => GetPropertyValue<CHandle<questIRewardManagerNodeType>>();
			set => SetPropertyValue<CHandle<questIRewardManagerNodeType>>(value);
		}

		public questRewardManagerNodeDefinition()
		{
			Sockets = new();
			Id = 65535;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
