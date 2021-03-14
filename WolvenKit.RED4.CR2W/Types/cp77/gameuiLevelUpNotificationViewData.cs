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
			get
			{
				if (_canBeMerged == null)
				{
					_canBeMerged = (CBool) CR2WTypeManager.Create("Bool", "canBeMerged", cr2w, this);
				}
				return _canBeMerged;
			}
			set
			{
				if (_canBeMerged == value)
				{
					return;
				}
				_canBeMerged = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("levelupdata")] 
		public questLevelUpData Levelupdata
		{
			get
			{
				if (_levelupdata == null)
				{
					_levelupdata = (questLevelUpData) CR2WTypeManager.Create("questLevelUpData", "levelupdata", cr2w, this);
				}
				return _levelupdata;
			}
			set
			{
				if (_levelupdata == value)
				{
					return;
				}
				_levelupdata = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("proficiencyRecord")] 
		public CHandle<gamedataProficiency_Record> ProficiencyRecord
		{
			get
			{
				if (_proficiencyRecord == null)
				{
					_proficiencyRecord = (CHandle<gamedataProficiency_Record>) CR2WTypeManager.Create("handle:gamedataProficiency_Record", "proficiencyRecord", cr2w, this);
				}
				return _proficiencyRecord;
			}
			set
			{
				if (_proficiencyRecord == value)
				{
					return;
				}
				_proficiencyRecord = value;
				PropertySet(this);
			}
		}

		[Ordinal(8)] 
		[RED("profString")] 
		public CString ProfString
		{
			get
			{
				if (_profString == null)
				{
					_profString = (CString) CR2WTypeManager.Create("String", "profString", cr2w, this);
				}
				return _profString;
			}
			set
			{
				if (_profString == value)
				{
					return;
				}
				_profString = value;
				PropertySet(this);
			}
		}

		public gameuiLevelUpNotificationViewData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
