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
			EntityReference = new gameEntityReference { Names = new() };
			Params = new questUnequipItemParams { UnequipDurationOverride = -1.000000F };

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
