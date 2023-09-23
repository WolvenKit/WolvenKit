using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class questTeleportPuppetNodeDefinition : questAICommandNodeBase
	{
		[Ordinal(2)] 
		[RED("entityReference")] 
		public CHandle<questUniversalRef> EntityReference
		{
			get => GetPropertyValue<CHandle<questUniversalRef>>();
			set => SetPropertyValue<CHandle<questUniversalRef>>(value);
		}

		[Ordinal(3)] 
		[RED("params")] 
		public CHandle<questTeleportPuppetParamsV1> Params
		{
			get => GetPropertyValue<CHandle<questTeleportPuppetParamsV1>>();
			set => SetPropertyValue<CHandle<questTeleportPuppetParamsV1>>(value);
		}

		[Ordinal(4)] 
		[RED("lookAtAction")] 
		public CEnum<questLookAtAction> LookAtAction
		{
			get => GetPropertyValue<CEnum<questLookAtAction>>();
			set => SetPropertyValue<CEnum<questLookAtAction>>(value);
		}

		[Ordinal(5)] 
		[RED("playerLookAt")] 
		public CHandle<questPlayerLookAtParams> PlayerLookAt
		{
			get => GetPropertyValue<CHandle<questPlayerLookAtParams>>();
			set => SetPropertyValue<CHandle<questPlayerLookAtParams>>(value);
		}

		public questTeleportPuppetNodeDefinition()
		{
			Sockets = new();
			Id = ushort.MaxValue;
			LookAtAction = Enums.questLookAtAction.Reset;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
