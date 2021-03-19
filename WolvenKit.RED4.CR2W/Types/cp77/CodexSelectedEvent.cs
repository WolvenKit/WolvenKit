using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class CodexSelectedEvent : redEvent
	{
		private CBool _group;
		private CInt32 _entryHash;
		private CInt32 _level;
		private wCHandle<CodexEntryData> _data;
		private wCHandle<CodexListSyncData> _activeDataSync;

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
		public wCHandle<CodexEntryData> Data
		{
			get => GetProperty(ref _data);
			set => SetProperty(ref _data, value);
		}

		[Ordinal(4)] 
		[RED("activeDataSync")] 
		public wCHandle<CodexListSyncData> ActiveDataSync
		{
			get => GetProperty(ref _activeDataSync);
			set => SetProperty(ref _activeDataSync, value);
		}

		public CodexSelectedEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
