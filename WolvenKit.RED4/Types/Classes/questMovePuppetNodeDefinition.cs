using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class questMovePuppetNodeDefinition : questConfigurableAICommandNode
	{
		[Ordinal(2)] 
		[RED("entityReference")] 
		public gameEntityReference EntityReference
		{
			get => GetPropertyValue<gameEntityReference>();
			set => SetPropertyValue<gameEntityReference>(value);
		}

		[Ordinal(3)] 
		[RED("moveType")] 
		public CName MoveType
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(4)] 
		[RED("nodeParams")] 
		public CHandle<questAICommandParams> NodeParams
		{
			get => GetPropertyValue<CHandle<questAICommandParams>>();
			set => SetPropertyValue<CHandle<questAICommandParams>>(value);
		}

		public questMovePuppetNodeDefinition()
		{
			Sockets = new();
			Id = ushort.MaxValue;
			EntityReference = new gameEntityReference();
			MoveType = "questMoveOnSplineParams";
			NodeParams = new questMoveOnSplineParams { AdditionalParams = new questMoveOnSplineAdditionalParams { SimpleParams = new questSimpleMoveOnSplineParams { FacingTargetRef = new questUniversalRef { RefLocalPlayer = false } } } };

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
