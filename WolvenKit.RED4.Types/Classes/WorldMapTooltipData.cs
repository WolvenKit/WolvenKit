using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class WorldMapTooltipData : RedBaseClass
	{
		private CWeakHandle<gameuiBaseWorldMapMappinController> _controller;
		private CWeakHandle<gamemappinsIMappin> _mappin;
		private CWeakHandle<gameJournalEntry> _journalEntry;
		private CBool _fastTravelEnabled;
		private CBool _readJournal;
		private CEnum<gamedataDistrict> _district;
		private CBool _isCollection;
		private CInt32 _collectionCount;

		[Ordinal(0)] 
		[RED("controller")] 
		public CWeakHandle<gameuiBaseWorldMapMappinController> Controller
		{
			get => GetProperty(ref _controller);
			set => SetProperty(ref _controller, value);
		}

		[Ordinal(1)] 
		[RED("mappin")] 
		public CWeakHandle<gamemappinsIMappin> Mappin
		{
			get => GetProperty(ref _mappin);
			set => SetProperty(ref _mappin, value);
		}

		[Ordinal(2)] 
		[RED("journalEntry")] 
		public CWeakHandle<gameJournalEntry> JournalEntry
		{
			get => GetProperty(ref _journalEntry);
			set => SetProperty(ref _journalEntry, value);
		}

		[Ordinal(3)] 
		[RED("fastTravelEnabled")] 
		public CBool FastTravelEnabled
		{
			get => GetProperty(ref _fastTravelEnabled);
			set => SetProperty(ref _fastTravelEnabled, value);
		}

		[Ordinal(4)] 
		[RED("readJournal")] 
		public CBool ReadJournal
		{
			get => GetProperty(ref _readJournal);
			set => SetProperty(ref _readJournal, value);
		}

		[Ordinal(5)] 
		[RED("district")] 
		public CEnum<gamedataDistrict> District
		{
			get => GetProperty(ref _district);
			set => SetProperty(ref _district, value);
		}

		[Ordinal(6)] 
		[RED("isCollection")] 
		public CBool IsCollection
		{
			get => GetProperty(ref _isCollection);
			set => SetProperty(ref _isCollection, value);
		}

		[Ordinal(7)] 
		[RED("collectionCount")] 
		public CInt32 CollectionCount
		{
			get => GetProperty(ref _collectionCount);
			set => SetProperty(ref _collectionCount, value);
		}
	}
}
