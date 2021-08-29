using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class SSubCharacter : RedBaseClass
	{
		private gamePersistentID _persistentID;
		private CEnum<gamedataSubCharacter> _subCharType;
		private CHandle<EquipmentSystemPlayerData> _equipmentData;

		[Ordinal(0)] 
		[RED("persistentID")] 
		public gamePersistentID PersistentID
		{
			get => GetProperty(ref _persistentID);
			set => SetProperty(ref _persistentID, value);
		}

		[Ordinal(1)] 
		[RED("subCharType")] 
		public CEnum<gamedataSubCharacter> SubCharType
		{
			get => GetProperty(ref _subCharType);
			set => SetProperty(ref _subCharType, value);
		}

		[Ordinal(2)] 
		[RED("equipmentData")] 
		public CHandle<EquipmentSystemPlayerData> EquipmentData
		{
			get => GetProperty(ref _equipmentData);
			set => SetProperty(ref _equipmentData, value);
		}
	}
}
