using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class questMiscAICommandNode : questConfigurableAICommandNode
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

		public questMiscAICommandNode()
		{
			Sockets = new();
			Id = 65535;
			EntityReference = new() { Names = new() };
			Function = "AIClearRoleCommandParams";

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
