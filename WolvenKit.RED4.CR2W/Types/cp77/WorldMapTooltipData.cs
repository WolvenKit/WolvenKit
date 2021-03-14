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
			get
			{
				if (_controller == null)
				{
					_controller = (wCHandle<gameuiBaseWorldMapMappinController>) CR2WTypeManager.Create("whandle:gameuiBaseWorldMapMappinController", "controller", cr2w, this);
				}
				return _controller;
			}
			set
			{
				if (_controller == value)
				{
					return;
				}
				_controller = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("mappin")] 
		public wCHandle<gamemappinsIMappin> Mappin
		{
			get
			{
				if (_mappin == null)
				{
					_mappin = (wCHandle<gamemappinsIMappin>) CR2WTypeManager.Create("whandle:gamemappinsIMappin", "mappin", cr2w, this);
				}
				return _mappin;
			}
			set
			{
				if (_mappin == value)
				{
					return;
				}
				_mappin = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("journalEntry")] 
		public wCHandle<gameJournalEntry> JournalEntry
		{
			get
			{
				if (_journalEntry == null)
				{
					_journalEntry = (wCHandle<gameJournalEntry>) CR2WTypeManager.Create("whandle:gameJournalEntry", "journalEntry", cr2w, this);
				}
				return _journalEntry;
			}
			set
			{
				if (_journalEntry == value)
				{
					return;
				}
				_journalEntry = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("fastTravelEnabled")] 
		public CBool FastTravelEnabled
		{
			get
			{
				if (_fastTravelEnabled == null)
				{
					_fastTravelEnabled = (CBool) CR2WTypeManager.Create("Bool", "fastTravelEnabled", cr2w, this);
				}
				return _fastTravelEnabled;
			}
			set
			{
				if (_fastTravelEnabled == value)
				{
					return;
				}
				_fastTravelEnabled = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("readJournal")] 
		public CBool ReadJournal
		{
			get
			{
				if (_readJournal == null)
				{
					_readJournal = (CBool) CR2WTypeManager.Create("Bool", "readJournal", cr2w, this);
				}
				return _readJournal;
			}
			set
			{
				if (_readJournal == value)
				{
					return;
				}
				_readJournal = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("district")] 
		public CEnum<gamedataDistrict> District
		{
			get
			{
				if (_district == null)
				{
					_district = (CEnum<gamedataDistrict>) CR2WTypeManager.Create("gamedataDistrict", "district", cr2w, this);
				}
				return _district;
			}
			set
			{
				if (_district == value)
				{
					return;
				}
				_district = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("isCollection")] 
		public CBool IsCollection
		{
			get
			{
				if (_isCollection == null)
				{
					_isCollection = (CBool) CR2WTypeManager.Create("Bool", "isCollection", cr2w, this);
				}
				return _isCollection;
			}
			set
			{
				if (_isCollection == value)
				{
					return;
				}
				_isCollection = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("collectionCount")] 
		public CInt32 CollectionCount
		{
			get
			{
				if (_collectionCount == null)
				{
					_collectionCount = (CInt32) CR2WTypeManager.Create("Int32", "collectionCount", cr2w, this);
				}
				return _collectionCount;
			}
			set
			{
				if (_collectionCount == value)
				{
					return;
				}
				_collectionCount = value;
				PropertySet(this);
			}
		}

		public WorldMapTooltipData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
