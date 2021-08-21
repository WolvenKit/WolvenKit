using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class InventoryItemDisplayCategoryArea : inkWidgetLogicController
	{
		private CArray<inkWidgetReference> _areasToHide;
		private CArray<inkCompoundWidgetReference> _equipmentAreas;
		private inkWidgetReference _newItemsWrapper;
		private inkTextWidgetReference _newItemsCounter;
		private CArray<wCHandle<InventoryItemDisplayEquipmentArea>> _categoryAreas;

		[Ordinal(1)] 
		[RED("areasToHide")] 
		public CArray<inkWidgetReference> AreasToHide
		{
			get => GetProperty(ref _areasToHide);
			set => SetProperty(ref _areasToHide, value);
		}

		[Ordinal(2)] 
		[RED("equipmentAreas")] 
		public CArray<inkCompoundWidgetReference> EquipmentAreas
		{
			get => GetProperty(ref _equipmentAreas);
			set => SetProperty(ref _equipmentAreas, value);
		}

		[Ordinal(3)] 
		[RED("newItemsWrapper")] 
		public inkWidgetReference NewItemsWrapper
		{
			get => GetProperty(ref _newItemsWrapper);
			set => SetProperty(ref _newItemsWrapper, value);
		}

		[Ordinal(4)] 
		[RED("newItemsCounter")] 
		public inkTextWidgetReference NewItemsCounter
		{
			get => GetProperty(ref _newItemsCounter);
			set => SetProperty(ref _newItemsCounter, value);
		}

		[Ordinal(5)] 
		[RED("categoryAreas")] 
		public CArray<wCHandle<InventoryItemDisplayEquipmentArea>> CategoryAreas
		{
			get => GetProperty(ref _categoryAreas);
			set => SetProperty(ref _categoryAreas, value);
		}

		public InventoryItemDisplayCategoryArea(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
