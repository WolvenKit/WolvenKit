using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class BlackBoardRequestEvent : redEvent
	{
		private CHandle<gameIBlackboard> _blackBoard;
		private CEnum<gameScriptedBlackboardStorage> _storageClass;
		private CName _entryTag;

		[Ordinal(0)] 
		[RED("blackBoard")] 
		public CHandle<gameIBlackboard> BlackBoard
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

		public BlackBoardRequestEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
