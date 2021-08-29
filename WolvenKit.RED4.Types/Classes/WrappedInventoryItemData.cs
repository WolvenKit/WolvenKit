using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class WrappedInventoryItemData : IScriptable
	{
		private InventoryItemData _itemData;
		private CEnum<gameItemComparisonState> _comparisonState;
		private CBool _isNew;
		private CUInt32 _itemTemplate;
		private CEnum<gameItemDisplayContext> _displayContext;

		[Ordinal(0)] 
		[RED("ItemData")] 
		public InventoryItemData ItemData
		{
			get => GetProperty(ref _itemData);
			set => SetProperty(ref _itemData, value);
		}

		[Ordinal(1)] 
		[RED("ComparisonState")] 
		public CEnum<gameItemComparisonState> ComparisonState
		{
			get => GetProperty(ref _comparisonState);
			set => SetProperty(ref _comparisonState, value);
		}

		[Ordinal(2)] 
		[RED("IsNew")] 
		public CBool IsNew
		{
			get => GetProperty(ref _isNew);
			set => SetProperty(ref _isNew, value);
		}

		[Ordinal(3)] 
		[RED("ItemTemplate")] 
		public CUInt32 ItemTemplate
		{
			get => GetProperty(ref _itemTemplate);
			set => SetProperty(ref _itemTemplate, value);
		}

		[Ordinal(4)] 
		[RED("DisplayContext")] 
		public CEnum<gameItemDisplayContext> DisplayContext
		{
			get => GetProperty(ref _displayContext);
			set => SetProperty(ref _displayContext, value);
		}
	}
}
