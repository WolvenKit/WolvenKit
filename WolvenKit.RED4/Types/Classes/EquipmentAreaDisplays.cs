using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class EquipmentAreaDisplays : IScriptable
	{
		[Ordinal(0)] 
		[RED("equipmentAreas")] 
		public CArray<CEnum<gamedataEquipmentArea>> EquipmentAreas
		{
			get => GetPropertyValue<CArray<CEnum<gamedataEquipmentArea>>>();
			set => SetPropertyValue<CArray<CEnum<gamedataEquipmentArea>>>(value);
		}

		[Ordinal(1)] 
		[RED("displaysRoot")] 
		public CWeakHandle<inkWidget> DisplaysRoot
		{
			get => GetPropertyValue<CWeakHandle<inkWidget>>();
			set => SetPropertyValue<CWeakHandle<inkWidget>>(value);
		}

		[Ordinal(2)] 
		[RED("displayControllers")] 
		public CArray<CWeakHandle<InventoryItemDisplayController>> DisplayControllers
		{
			get => GetPropertyValue<CArray<CWeakHandle<InventoryItemDisplayController>>>();
			set => SetPropertyValue<CArray<CWeakHandle<InventoryItemDisplayController>>>(value);
		}

		public EquipmentAreaDisplays()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
