using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameSSlotVisualInfo : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("areaType")] 
		public CEnum<gamedataEquipmentArea> AreaType
		{
			get => GetPropertyValue<CEnum<gamedataEquipmentArea>>();
			set => SetPropertyValue<CEnum<gamedataEquipmentArea>>(value);
		}

		[Ordinal(1)] 
		[RED("isHidden")] 
		public CBool IsHidden
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(2)] 
		[RED("visualItem")] 
		public gameItemID VisualItem
		{
			get => GetPropertyValue<gameItemID>();
			set => SetPropertyValue<gameItemID>(value);
		}

		public gameSSlotVisualInfo()
		{
			VisualItem = new gameItemID();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
