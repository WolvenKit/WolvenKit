using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class QuickSlotUIStructure : RedBaseClass
	{
		private CInt32 _itemIndex;
		private CBool _operationResult;

		[Ordinal(0)] 
		[RED("ItemIndex")] 
		public CInt32 ItemIndex
		{
			get => GetProperty(ref _itemIndex);
			set => SetProperty(ref _itemIndex, value);
		}

		[Ordinal(1)] 
		[RED("OperationResult")] 
		public CBool OperationResult
		{
			get => GetProperty(ref _operationResult);
			set => SetProperty(ref _operationResult, value);
		}
	}
}
