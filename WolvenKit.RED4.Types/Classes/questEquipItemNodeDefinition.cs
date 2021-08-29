using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class questEquipItemNodeDefinition : questAICommandNodeBase
	{
		private CHandle<questObservableUniversalRef> _entityReference;
		private CHandle<questEquipItemParams> _params;

		[Ordinal(2)] 
		[RED("entityReference")] 
		public CHandle<questObservableUniversalRef> EntityReference
		{
			get => GetProperty(ref _entityReference);
			set => SetProperty(ref _entityReference, value);
		}

		[Ordinal(3)] 
		[RED("params")] 
		public CHandle<questEquipItemParams> Params
		{
			get => GetProperty(ref _params);
			set => SetProperty(ref _params, value);
		}
	}
}
