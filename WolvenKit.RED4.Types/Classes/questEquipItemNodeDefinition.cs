using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class questEquipItemNodeDefinition : questAICommandNodeBase
	{
		[Ordinal(2)] 
		[RED("entityReference")] 
		public CHandle<questObservableUniversalRef> EntityReference
		{
			get => GetPropertyValue<CHandle<questObservableUniversalRef>>();
			set => SetPropertyValue<CHandle<questObservableUniversalRef>>(value);
		}

		[Ordinal(3)] 
		[RED("params")] 
		public CHandle<questEquipItemParams> Params
		{
			get => GetPropertyValue<CHandle<questEquipItemParams>>();
			set => SetPropertyValue<CHandle<questEquipItemParams>>(value);
		}

		public questEquipItemNodeDefinition()
		{
			Sockets = new();
			Id = 65535;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
