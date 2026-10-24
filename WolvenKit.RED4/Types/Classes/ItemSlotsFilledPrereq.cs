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

		[Ordinal(1)] 
		[RED("inverted")] 
		public CBool Inverted
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public ItemSlotsFilledPrereq()
		{
			EquipAreas = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
