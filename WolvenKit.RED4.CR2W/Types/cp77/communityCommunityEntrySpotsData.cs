using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class communityCommunityEntrySpotsData : CVariable
	{
		private CArray<communityCommunityEntryPhaseSpotsData> _phasesData;
		private CName _entryName;

		[Ordinal(0)] 
		[RED("phasesData")] 
		public CArray<communityCommunityEntryPhaseSpotsData> PhasesData
		{
			get
			{
				if (_phasesData == null)
				{
					_phasesData = (CArray<communityCommunityEntryPhaseSpotsData>) CR2WTypeManager.Create("array:communityCommunityEntryPhaseSpotsData", "phasesData", cr2w, this);
				}
				return _phasesData;
			}
			set
			{
				if (_phasesData == value)
				{
					return;
				}
				_phasesData = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("entryName")] 
		public CName EntryName
		{
			get
			{
				if (_entryName == null)
				{
					_entryName = (CName) CR2WTypeManager.Create("CName", "entryName", cr2w, this);
				}
				return _entryName;
			}
			set
			{
				if (_entryName == value)
				{
					return;
				}
				_entryName = value;
				PropertySet(this);
			}
		}

		public communityCommunityEntrySpotsData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
