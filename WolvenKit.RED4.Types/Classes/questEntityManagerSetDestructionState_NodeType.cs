using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class questEntityManagerSetDestructionState_NodeType : questIEntityManager_NodeType
	{
		private CEnum<questSetDestructionStateAction> _action;
		private CArray<questEntityManagerSetDestructionState_NodeTypeParams> _params;

		[Ordinal(0)] 
		[RED("action")] 
		public CEnum<questSetDestructionStateAction> Action
		{
			get => GetProperty(ref _action);
			set => SetProperty(ref _action, value);
		}

		[Ordinal(1)] 
		[RED("params")] 
		public CArray<questEntityManagerSetDestructionState_NodeTypeParams> Params
		{
			get => GetProperty(ref _params);
			set => SetProperty(ref _params, value);
		}
	}
}
