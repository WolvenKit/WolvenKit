using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ItemInventoryMiniGrid : inkWidgetLogicController
	{
		private inkCompoundWidgetReference _gridList;
		private inkTextWidgetReference _label;
		private CInt32 _gridWidth;
		private CArray<wCHandle<InventoryItemDisplay>> _gridData;

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
		public CArray<wCHandle<InventoryItemDisplay>> GridData
		{
			get => GetProperty(ref _gridData);
			set => SetProperty(ref _gridData, value);
		}

		public ItemInventoryMiniGrid(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
