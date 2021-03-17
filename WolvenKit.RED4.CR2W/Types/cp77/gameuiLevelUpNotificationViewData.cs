using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameuiLevelUpNotificationViewData : gameuiGenericNotificationViewData
	{
		private CBool _canBeMerged;
		private questLevelUpData _levelupdata;
		private CHandle<gamedataProficiency_Record> _proficiencyRecord;
		private CString _profString;

		[Ordinal(5)] 
		[RED("canBeMerged")] 
		public CBool CanBeMerged
		{
			get => GetProperty(ref _canBeMerged);
			set => SetProperty(ref _canBeMerged, value);
		}

		[Ordinal(6)] 
		[RED("levelupdata")] 
		public questLevelUpData Levelupdata
		{
			get => GetProperty(ref _levelupdata);
			set => SetProperty(ref _levelupdata, value);
		}

		[Ordinal(7)] 
		[RED("proficiencyRecord")] 
		public CHandle<gamedataProficiency_Record> ProficiencyRecord
		{
			get => GetProperty(ref _proficiencyRecord);
			set => SetProperty(ref _proficiencyRecord, value);
		}

		[Ordinal(8)] 
		[RED("profString")] 
		public CString ProfString
		{
			get => GetProperty(ref _profString);
			set => SetProperty(ref _profString, value);
		}

		public gameuiLevelUpNotificationViewData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
