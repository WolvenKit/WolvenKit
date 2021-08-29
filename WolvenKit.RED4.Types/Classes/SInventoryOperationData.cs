using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class SInventoryOperationData : RedBaseClass
	{
		private TweakDBID _itemName;
		private CInt32 _quantity;
		private CEnum<EItemOperationType> _operationType;

		[Ordinal(0)] 
		[RED("itemName")] 
		public TweakDBID ItemName
		{
			get => GetProperty(ref _itemName);
			set => SetProperty(ref _itemName, value);
		}

		[Ordinal(1)] 
		[RED("quantity")] 
		public CInt32 Quantity
		{
			get => GetProperty(ref _quantity);
			set => SetProperty(ref _quantity, value);
		}

		[Ordinal(2)] 
		[RED("operationType")] 
		public CEnum<EItemOperationType> OperationType
		{
			get => GetProperty(ref _operationType);
			set => SetProperty(ref _operationType, value);
		}
	}
}
