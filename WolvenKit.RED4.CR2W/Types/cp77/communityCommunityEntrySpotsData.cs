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
			get => GetProperty(ref _phasesData);
			set => SetProperty(ref _phasesData, value);
		}

		[Ordinal(1)] 
		[RED("entryName")] 
		public CName EntryName
		{
			get => GetProperty(ref _entryName);
			set => SetProperty(ref _entryName, value);
		}

		public communityCommunityEntrySpotsData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
