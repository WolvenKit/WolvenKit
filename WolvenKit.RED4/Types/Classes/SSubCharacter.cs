using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class SSubCharacter : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("persistentID")] 
		public gamePersistentID PersistentID
		{
			get => GetPropertyValue<gamePersistentID>();
			set => SetPropertyValue<gamePersistentID>(value);
		}

		[Ordinal(1)] 
		[RED("subCharType")] 
		public CEnum<gamedataSubCharacter> SubCharType
		{
			get => GetPropertyValue<CEnum<gamedataSubCharacter>>();
			set => SetPropertyValue<CEnum<gamedataSubCharacter>>(value);
		}

		[Ordinal(2)] 
		[RED("equipmentData")] 
		public CHandle<EquipmentSystemPlayerData> EquipmentData
		{
			get => GetPropertyValue<CHandle<EquipmentSystemPlayerData>>();
			set => SetPropertyValue<CHandle<EquipmentSystemPlayerData>>(value);
		}

		public SSubCharacter()
		{
			PersistentID = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
