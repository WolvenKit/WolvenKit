using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class questMovePuppetNodeDefinition : questConfigurableAICommandNode
	{
		private gameEntityReference _entityReference;
		private CName _moveType;
		private CHandle<questAICommandParams> _nodeParams;

		[Ordinal(2)] 
		[RED("entityReference")] 
		public gameEntityReference EntityReference
		{
			get => GetProperty(ref _entityReference);
			set => SetProperty(ref _entityReference, value);
		}

		[Ordinal(3)] 
		[RED("moveType")] 
		public CName MoveType
		{
			get => GetProperty(ref _moveType);
			set => SetProperty(ref _moveType, value);
		}

		[Ordinal(4)] 
		[RED("nodeParams")] 
		public CHandle<questAICommandParams> NodeParams
		{
			get => GetProperty(ref _nodeParams);
			set => SetProperty(ref _nodeParams, value);
		}
	}
}
