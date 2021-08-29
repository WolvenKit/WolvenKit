using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class CodexSelectedEvent : redEvent
	{
		private CBool _group;
		private CInt32 _entryHash;
		private CInt32 _level;
		private CWeakHandle<CodexEntryData> _data;
		private CWeakHandle<CodexListSyncData> _activeDataSync;

		[Ordinal(0)] 
		[RED("group")] 
		public CBool Group
		{
			get => GetProperty(ref _group);
			set => SetProperty(ref _group, value);
		}

		[Ordinal(1)] 
		[RED("entryHash")] 
		public CInt32 EntryHash
		{
			get => GetProperty(ref _entryHash);
			set => SetProperty(ref _entryHash, value);
		}

		[Ordinal(2)] 
		[RED("level")] 
		public CInt32 Level
		{
			get => GetProperty(ref _level);
			set => SetProperty(ref _level, value);
		}

		[Ordinal(3)] 
		[RED("data")] 
		public CWeakHandle<CodexEntryData> Data
		{
			get => GetProperty(ref _data);
			set => SetProperty(ref _data, value);
		}

		[Ordinal(4)] 
		[RED("activeDataSync")] 
		public CWeakHandle<CodexListSyncData> ActiveDataSync
		{
			get => GetProperty(ref _activeDataSync);
			set => SetProperty(ref _activeDataSync, value);
		}
	}
}
