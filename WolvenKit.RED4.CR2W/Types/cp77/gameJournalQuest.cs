using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameJournalQuest : gameJournalFileEntry
	{
		private LocalizationString _title;
		private CEnum<gameJournalQuestType> _type;
		private TweakDBID _recommendedLevelID;
		private CString _districtID;

		[Ordinal(2)] 
		[RED("title")] 
		public LocalizationString Title
		{
			get
			{
				if (_title == null)
				{
					_title = (LocalizationString) CR2WTypeManager.Create("LocalizationString", "title", cr2w, this);
				}
				return _title;
			}
			set
			{
				if (_title == value)
				{
					return;
				}
				_title = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("type")] 
		public CEnum<gameJournalQuestType> Type
		{
			get
			{
				if (_type == null)
				{
					_type = (CEnum<gameJournalQuestType>) CR2WTypeManager.Create("gameJournalQuestType", "type", cr2w, this);
				}
				return _type;
			}
			set
			{
				if (_type == value)
				{
					return;
				}
				_type = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("recommendedLevelID")] 
		public TweakDBID RecommendedLevelID
		{
			get
			{
				if (_recommendedLevelID == null)
				{
					_recommendedLevelID = (TweakDBID) CR2WTypeManager.Create("TweakDBID", "recommendedLevelID", cr2w, this);
				}
				return _recommendedLevelID;
			}
			set
			{
				if (_recommendedLevelID == value)
				{
					return;
				}
				_recommendedLevelID = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("districtID")] 
		public CString DistrictID
		{
			get
			{
				if (_districtID == null)
				{
					_districtID = (CString) CR2WTypeManager.Create("String", "districtID", cr2w, this);
				}
				return _districtID;
			}
			set
			{
				if (_districtID == value)
				{
					return;
				}
				_districtID = value;
				PropertySet(this);
			}
		}

		public gameJournalQuest(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
