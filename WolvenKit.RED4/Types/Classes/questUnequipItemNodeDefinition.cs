using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class questUnequipItemNodeDefinition : questSignalStoppingNodeDefinition
	{
		[Ordinal(2)] 
		[RED("entityReference")] 
		public gameEntityReference EntityReference
		{
			get => GetPropertyValue<gameEntityReference>();
			set => SetPropertyValue<gameEntityReference>(value);
		}

		[Ordinal(3)] 
		[RED("params")] 
		public questUnequipItemParams Params
		{
			get => GetPropertyValue<questUnequipItemParams>();
			set => SetPropertyValue<questUnequipItemParams>(value);
		}

		public questUnequipItemNodeDefinition()
		{
			Sockets = new();
			Id = ushort.MaxValue;
			EntityReference = new gameEntityReference();
			Params = new questUnequipItemParams();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
