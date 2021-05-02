using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class scannerQuestEntry : CVariable
	{
		private CName _categoryName;
		private CName _entryName;
		private TweakDBID _recordID;

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

		public scannerQuestEntry(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
