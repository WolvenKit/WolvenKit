using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class PowerUpCyberwareEffector : gameEffector
	{
		[Ordinal(0)] 
		[RED("targetEquipArea")] 
		public CEnum<gamedataEquipmentArea> TargetEquipArea
		{
			get => GetPropertyValue<CEnum<gamedataEquipmentArea>>();
			set => SetPropertyValue<CEnum<gamedataEquipmentArea>>(value);
		}

		[Ordinal(1)] 
		[RED("targetEquipSlotIndex")] 
		public CInt32 TargetEquipSlotIndex
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(2)] 
		[RED("playerData")] 
		public CWeakHandle<EquipmentSystemPlayerData> PlayerData
		{
			get => GetPropertyValue<CWeakHandle<EquipmentSystemPlayerData>>();
			set => SetPropertyValue<CWeakHandle<EquipmentSystemPlayerData>>(value);
		}

		[Ordinal(3)] 
		[RED("owner")] 
		public CWeakHandle<gameObject> Owner
		{
			get => GetPropertyValue<CWeakHandle<gameObject>>();
			set => SetPropertyValue<CWeakHandle<gameObject>>(value);
		}

		public PowerUpCyberwareEffector()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
