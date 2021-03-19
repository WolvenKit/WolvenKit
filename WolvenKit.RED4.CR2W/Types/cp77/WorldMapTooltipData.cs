using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class WorldMapTooltipData : CVariable
	{
		private wCHandle<gameuiBaseWorldMapMappinController> _controller;
		private wCHandle<gamemappinsIMappin> _mappin;
		private wCHandle<gameJournalEntry> _journalEntry;
		private CBool _fastTravelEnabled;
		private CBool _readJournal;
		private CEnum<gamedataDistrict> _district;
		private CBool _isCollection;
		private CInt32 _collectionCount;

		[Ordinal(0)] 
		[RED("controller")] 
		public wCHandle<gameuiBaseWorldMapMappinController> Controller
		{
			get => GetProperty(ref _controller);
			set => SetProperty(ref _controller, value);
		}

		[Ordinal(1)] 
		[RED("mappin")] 
		public wCHandle<gamemappinsIMappin> Mappin
		{
			get => GetProperty(ref _mappin);
			set => SetProperty(ref _mappin, value);
		}

		[Ordinal(2)] 
		[RED("journalEntry")] 
		public wCHandle<gameJournalEntry> JournalEntry
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

		public WorldMapTooltipData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
