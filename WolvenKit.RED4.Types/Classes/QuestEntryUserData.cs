using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class QuestEntryUserData : IScriptable
	{
		private CName _categoryName;
		private CName _entryName;
		private TweakDBID _recordID;
		private CWeakHandle<inkAsyncSpawnRequest> _asyncSpawnRequest;

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
		public CWeakHandle<inkAsyncSpawnRequest> AsyncSpawnRequest
		{
			get => GetProperty(ref _asyncSpawnRequest);
			set => SetProperty(ref _asyncSpawnRequest, value);
		}
	}
}
