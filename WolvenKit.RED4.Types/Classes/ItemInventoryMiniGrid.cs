using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class ItemInventoryMiniGrid : inkWidgetLogicController
	{
		private inkCompoundWidgetReference _gridList;
		private inkTextWidgetReference _label;
		private CInt32 _gridWidth;
		private CArray<CWeakHandle<InventoryItemDisplay>> _gridData;

		[Ordinal(1)] 
		[RED("gridList")] 
		public inkCompoundWidgetReference GridList
		{
			get => GetProperty(ref _gridList);
			set => SetProperty(ref _gridList, value);
		}

		[Ordinal(2)] 
		[RED("label")] 
		public inkTextWidgetReference Label
		{
			get => GetProperty(ref _label);
			set => SetProperty(ref _label, value);
		}

		[Ordinal(3)] 
		[RED("gridWidth")] 
		public CInt32 GridWidth
		{
			get => GetProperty(ref _gridWidth);
			set => SetProperty(ref _gridWidth, value);
		}

		[Ordinal(4)] 
		[RED("gridData")] 
		public CArray<CWeakHandle<InventoryItemDisplay>> GridData
		{
			get => GetProperty(ref _gridData);
			set => SetProperty(ref _gridData, value);
		}
	}
}
