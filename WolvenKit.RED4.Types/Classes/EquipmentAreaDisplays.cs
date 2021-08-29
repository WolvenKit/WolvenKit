using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class EquipmentAreaDisplays : IScriptable
	{
		private CArray<CEnum<gamedataEquipmentArea>> _equipmentAreas;
		private CWeakHandle<inkWidget> _displaysRoot;
		private CArray<CWeakHandle<InventoryItemDisplayController>> _displayControllers;

		[Ordinal(0)] 
		[RED("equipmentAreas")] 
		public CArray<CEnum<gamedataEquipmentArea>> EquipmentAreas
		{
			get => GetProperty(ref _equipmentAreas);
			set => SetProperty(ref _equipmentAreas, value);
		}

		[Ordinal(1)] 
		[RED("displaysRoot")] 
		public CWeakHandle<inkWidget> DisplaysRoot
		{
			get => GetProperty(ref _displaysRoot);
			set => SetProperty(ref _displaysRoot, value);
		}

		[Ordinal(2)] 
		[RED("displayControllers")] 
		public CArray<CWeakHandle<InventoryItemDisplayController>> DisplayControllers
		{
			get => GetProperty(ref _displayControllers);
			set => SetProperty(ref _displayControllers, value);
		}
	}
}
