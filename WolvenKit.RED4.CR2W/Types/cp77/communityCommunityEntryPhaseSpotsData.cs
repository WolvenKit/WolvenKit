using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class communityCommunityEntryPhaseSpotsData : CVariable
	{
		private CArray<communityCommunityEntryPhaseTimePeriodData> _timePeriodsData;
		private CName _entryPhaseName;

		[Ordinal(0)] 
		[RED("timePeriodsData")] 
		public CArray<communityCommunityEntryPhaseTimePeriodData> TimePeriodsData
		{
			get
			{
				if (_timePeriodsData == null)
				{
					_timePeriodsData = (CArray<communityCommunityEntryPhaseTimePeriodData>) CR2WTypeManager.Create("array:communityCommunityEntryPhaseTimePeriodData", "timePeriodsData", cr2w, this);
				}
				return _timePeriodsData;
			}
			set
			{
				if (_timePeriodsData == value)
				{
					return;
				}
				_timePeriodsData = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("entryPhaseName")] 
		public CName EntryPhaseName
		{
			get
			{
				if (_entryPhaseName == null)
				{
					_entryPhaseName = (CName) CR2WTypeManager.Create("CName", "entryPhaseName", cr2w, this);
				}
				return _entryPhaseName;
			}
			set
			{
				if (_entryPhaseName == value)
				{
					return;
				}
				_entryPhaseName = value;
				PropertySet(this);
			}
		}

		public communityCommunityEntryPhaseSpotsData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
