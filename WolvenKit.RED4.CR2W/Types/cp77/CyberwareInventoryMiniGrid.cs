using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class CyberwareInventoryMiniGrid : inkWidgetLogicController
	{
		private inkUniformGridWidgetReference _gridContainer;
		private inkTextWidgetReference _label;
		private inkTextWidgetReference _sublabel;
		private inkTextWidgetReference _number;
		private inkWidgetReference _numberPanel;
		private CInt32 _gridWidth;
		private CInt32 _selectedSlotIndex;
		private CEnum<gamedataEquipmentArea> _equipArea;
		private CHandle<IScriptable> _parentObject;
		private CName _onRealeaseCallbackName;
		private CArray<wCHandle<InventoryItemDisplayController>> _gridData;

		[Ordinal(1)] 
		[RED("gridContainer")] 
		public inkUniformGridWidgetReference GridContainer
		{
			get => GetProperty(ref _gridContainer);
			set => SetProperty(ref _gridContainer, value);
		}

		[Ordinal(2)] 
		[RED("label")] 
		public inkTextWidgetReference Label
		{
			get => GetProperty(ref _label);
			set => SetProperty(ref _label, value);
		}

		[Ordinal(3)] 
		[RED("sublabel")] 
		public inkTextWidgetReference Sublabel
		{
			get => GetProperty(ref _sublabel);
			set => SetProperty(ref _sublabel, value);
		}

		[Ordinal(4)] 
		[RED("number")] 
		public inkTextWidgetReference Number
		{
			get => GetProperty(ref _number);
			set => SetProperty(ref _number, value);
		}

		[Ordinal(5)] 
		[RED("numberPanel")] 
		public inkWidgetReference NumberPanel
		{
			get => GetProperty(ref _numberPanel);
			set => SetProperty(ref _numberPanel, value);
		}

		[Ordinal(6)] 
		[RED("gridWidth")] 
		public CInt32 GridWidth
		{
			get => GetProperty(ref _gridWidth);
			set => SetProperty(ref _gridWidth, value);
		}

		[Ordinal(7)] 
		[RED("selectedSlotIndex")] 
		public CInt32 SelectedSlotIndex
		{
			get => GetProperty(ref _selectedSlotIndex);
			set => SetProperty(ref _selectedSlotIndex, value);
		}

		[Ordinal(8)] 
		[RED("equipArea")] 
		public CEnum<gamedataEquipmentArea> EquipArea
		{
			get => GetProperty(ref _equipArea);
			set => SetProperty(ref _equipArea, value);
		}

		[Ordinal(9)] 
		[RED("parentObject")] 
		public CHandle<IScriptable> ParentObject
		{
			get => GetProperty(ref _parentObject);
			set => SetProperty(ref _parentObject, value);
		}

		[Ordinal(10)] 
		[RED("onRealeaseCallbackName")] 
		public CName OnRealeaseCallbackName
		{
			get => GetProperty(ref _onRealeaseCallbackName);
			set => SetProperty(ref _onRealeaseCallbackName, value);
		}

		[Ordinal(11)] 
		[RED("gridData")] 
		public CArray<wCHandle<InventoryItemDisplayController>> GridData
		{
			get => GetProperty(ref _gridData);
			set => SetProperty(ref _gridData, value);
		}

		public CyberwareInventoryMiniGrid(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
