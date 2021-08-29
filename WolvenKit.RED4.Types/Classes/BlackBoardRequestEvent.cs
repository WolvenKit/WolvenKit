using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class BlackBoardRequestEvent : redEvent
	{
		private CWeakHandle<gameIBlackboard> _blackBoard;
		private CEnum<gameScriptedBlackboardStorage> _storageClass;
		private CName _entryTag;

		[Ordinal(0)] 
		[RED("blackBoard")] 
		public CWeakHandle<gameIBlackboard> BlackBoard
		{
			get => GetProperty(ref _blackBoard);
			set => SetProperty(ref _blackBoard, value);
		}

		[Ordinal(1)] 
		[RED("storageClass")] 
		public CEnum<gameScriptedBlackboardStorage> StorageClass
		{
			get => GetProperty(ref _storageClass);
			set => SetProperty(ref _storageClass, value);
		}

		[Ordinal(2)] 
		[RED("entryTag")] 
		public CName EntryTag
		{
			get => GetProperty(ref _entryTag);
			set => SetProperty(ref _entryTag, value);
		}
	}
}
