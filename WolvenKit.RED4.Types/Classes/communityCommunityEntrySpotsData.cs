using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class communityCommunityEntrySpotsData : RedBaseClass
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
	}
}
