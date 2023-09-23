using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class ItemSlotsFilledPrereq : gameIScriptablePrereq
	{
		[Ordinal(0)] 
		[RED("equipAreas")] 
		public CArray<CEnum<gamedataEquipmentArea>> EquipAreas
		{
			get => GetPropertyValue<CArray<CEnum<gamedataEquipmentArea>>>();
			set => SetPropertyValue<CArray<CEnum<gamedataEquipmentArea>>>(value);
		}

		public ItemSlotsFilledPrereq()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
