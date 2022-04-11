using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class questUseWorkspotNodeDefinition : questAICommandNodeBase
	{
		[Ordinal(2)] 
		[RED("entityReference")] 
		public gameEntityReference EntityReference
		{
			get => GetPropertyValue<gameEntityReference>();
			set => SetPropertyValue<gameEntityReference>(value);
		}

		[Ordinal(3)] 
		[RED("paramsV1")] 
		public CHandle<questUseWorkspotParamsV1> ParamsV1
		{
			get => GetPropertyValue<CHandle<questUseWorkspotParamsV1>>();
			set => SetPropertyValue<CHandle<questUseWorkspotParamsV1>>(value);
		}

		public questUseWorkspotNodeDefinition()
		{
			Sockets = new();
			Id = 65535;
			EntityReference = new() { Names = new() };

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
