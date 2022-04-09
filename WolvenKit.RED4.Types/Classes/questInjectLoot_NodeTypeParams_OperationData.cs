using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class questInjectLoot_NodeTypeParams_OperationData : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("operationType")] 
		public CEnum<questInjectLootOperationType> OperationType
		{
			get => GetPropertyValue<CEnum<questInjectLootOperationType>>();
			set => SetPropertyValue<CEnum<questInjectLootOperationType>>(value);
		}

		[Ordinal(1)] 
		[RED("itemTDBID")] 
		public TweakDBID ItemTDBID
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}

		[Ordinal(2)] 
		[RED("quantity")] 
		public CInt32 Quantity
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		public questInjectLoot_NodeTypeParams_OperationData()
		{
			Quantity = 1;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
