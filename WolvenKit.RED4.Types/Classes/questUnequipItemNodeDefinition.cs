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
			Id = 65535;
			EntityReference = new() { Names = new() };
			Params = new() { UnequipDurationOverride = -1.000000F };

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
