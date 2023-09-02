using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class questCombatNodeDefinition : questConfigurableAICommandNode
	{
		[Ordinal(2)] 
		[RED("entityReference")] 
		public gameEntityReference EntityReference
		{
			get => GetPropertyValue<gameEntityReference>();
			set => SetPropertyValue<gameEntityReference>(value);
		}

		[Ordinal(3)] 
		[RED("function")] 
		public CName Function
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(4)] 
		[RED("params")] 
		public CHandle<questAICommandParams> Params
		{
			get => GetPropertyValue<CHandle<questAICommandParams>>();
			set => SetPropertyValue<CHandle<questAICommandParams>>(value);
		}

		public questCombatNodeDefinition()
		{
			Sockets = new();
			Id = ushort.MaxValue;
			EntityReference = new gameEntityReference { Names = new() };
			Function = "questCombatNodeParams_ShootAt";

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
