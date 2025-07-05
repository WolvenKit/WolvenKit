using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class QuestRestoreSlotRequest : gamePlayerScriptableSystemRequest
	{
		[Ordinal(1)] 
		[RED("slot")] 
		public CEnum<gamedataEquipmentArea> Slot
		{
			get => GetPropertyValue<CEnum<gamedataEquipmentArea>>();
			set => SetPropertyValue<CEnum<gamedataEquipmentArea>>(value);
		}

		public QuestRestoreSlotRequest()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
