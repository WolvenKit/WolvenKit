using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class questUseWorkspotNodeDefinition : questAICommandNodeBase
	{
		private gameEntityReference _entityReference;
		private CHandle<questUseWorkspotParamsV1> _paramsV1;

		[Ordinal(2)] 
		[RED("entityReference")] 
		public gameEntityReference EntityReference
		{
			get => GetProperty(ref _entityReference);
			set => SetProperty(ref _entityReference, value);
		}

		[Ordinal(3)] 
		[RED("paramsV1")] 
		public CHandle<questUseWorkspotParamsV1> ParamsV1
		{
			get => GetProperty(ref _paramsV1);
			set => SetProperty(ref _paramsV1, value);
		}
	}
}
