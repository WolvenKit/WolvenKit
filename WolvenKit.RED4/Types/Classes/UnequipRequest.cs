using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class UnequipRequest : gamePlayerScriptableSystemRequest
	{
		[Ordinal(1)] 
		[RED("areaType")] 
		public CEnum<gamedataEquipmentArea> AreaType
		{
			get => GetPropertyValue<CEnum<gamedataEquipmentArea>>();
			set => SetPropertyValue<CEnum<gamedataEquipmentArea>>(value);
		}

		[Ordinal(2)] 
		[RED("slotIndex")] 
		public CInt32 SlotIndex
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(3)] 
		[RED("force")] 
		public CBool Force
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public UnequipRequest()
		{
			SlotIndex = -1;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
