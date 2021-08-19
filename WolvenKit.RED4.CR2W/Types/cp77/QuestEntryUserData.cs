using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class QuestEntryUserData : IScriptable
	{
		private CName _categoryName;
		private CName _entryName;
		private TweakDBID _recordID;
		private wCHandle<inkAsyncSpawnRequest> _asyncSpawnRequest;

		[Ordinal(0)] 
		[RED("categoryName")] 
		public CName CategoryName
		{
			get => GetProperty(ref _categoryName);
			set => SetProperty(ref _categoryName, value);
		}

		[Ordinal(1)] 
		[RED("entryName")] 
		public CName EntryName
		{
			get => GetProperty(ref _entryName);
			set => SetProperty(ref _entryName, value);
		}

		[Ordinal(2)] 
		[RED("recordID")] 
		public TweakDBID RecordID
		{
			get => GetProperty(ref _recordID);
			set => SetProperty(ref _recordID, value);
		}

		[Ordinal(3)] 
		[RED("asyncSpawnRequest")] 
		public wCHandle<inkAsyncSpawnRequest> AsyncSpawnRequest
		{
			get => GetProperty(ref _asyncSpawnRequest);
			set => SetProperty(ref _asyncSpawnRequest, value);
		}

		public QuestEntryUserData(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
