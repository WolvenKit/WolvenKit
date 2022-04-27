using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class questEntityManagerSetDestructionState_NodeType : questIEntityManager_NodeType
	{
		[Ordinal(0)] 
		[RED("action")] 
		public CEnum<questSetDestructionStateAction> Action
		{
			get => GetPropertyValue<CEnum<questSetDestructionStateAction>>();
			set => SetPropertyValue<CEnum<questSetDestructionStateAction>>(value);
		}

		[Ordinal(1)] 
		[RED("params")] 
		public CArray<questEntityManagerSetDestructionState_NodeTypeParams> Params
		{
			get => GetPropertyValue<CArray<questEntityManagerSetDestructionState_NodeTypeParams>>();
			set => SetPropertyValue<CArray<questEntityManagerSetDestructionState_NodeTypeParams>>(value);
		}

		public questEntityManagerSetDestructionState_NodeType()
		{
			Params = new() { new() };

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
