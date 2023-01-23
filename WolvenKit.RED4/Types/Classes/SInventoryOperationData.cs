using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class SInventoryOperationData : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("itemName")] 
		public TweakDBID ItemName
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}

		[Ordinal(1)] 
		[RED("quantity")] 
		public CInt32 Quantity
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(2)] 
		[RED("operationType")] 
		public CEnum<EItemOperationType> OperationType
		{
			get => GetPropertyValue<CEnum<EItemOperationType>>();
			set => SetPropertyValue<CEnum<EItemOperationType>>(value);
		}

		public SInventoryOperationData()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
