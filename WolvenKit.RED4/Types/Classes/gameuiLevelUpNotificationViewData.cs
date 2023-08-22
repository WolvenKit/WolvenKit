using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameuiLevelUpNotificationViewData : gameuiGenericNotificationViewData
	{
		[Ordinal(5)] 
		[RED("canBeMerged")] 
		public CBool CanBeMerged
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(6)] 
		[RED("levelupdata")] 
		public questLevelUpData Levelupdata
		{
			get => GetPropertyValue<questLevelUpData>();
			set => SetPropertyValue<questLevelUpData>(value);
		}

		[Ordinal(7)] 
		[RED("proficiencyRecord")] 
		public CHandle<gamedataProficiency_Record> ProficiencyRecord
		{
			get => GetPropertyValue<CHandle<gamedataProficiency_Record>>();
			set => SetPropertyValue<CHandle<gamedataProficiency_Record>>(value);
		}

		[Ordinal(8)] 
		[RED("profString")] 
		public CString ProfString
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}

		public gameuiLevelUpNotificationViewData()
		{
			Levelupdata = new questLevelUpData();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
