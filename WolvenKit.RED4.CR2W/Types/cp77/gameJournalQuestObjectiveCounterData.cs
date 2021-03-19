using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameJournalQuestObjectiveCounterData : CVariable
	{
		private CHandle<gameJournalPath> _entryPath;
		private CInt32 _oldValue;
		private CInt32 _newValue;

		[Ordinal(0)] 
		[RED("entryPath")] 
		public CHandle<gameJournalPath> EntryPath
		{
			get => GetProperty(ref _entryPath);
			set => SetProperty(ref _entryPath, value);
		}

		[Ordinal(1)] 
		[RED("oldValue")] 
		public CInt32 OldValue
		{
			get => GetProperty(ref _oldValue);
			set => SetProperty(ref _oldValue, value);
		}

		[Ordinal(2)] 
		[RED("newValue")] 
		public CInt32 NewValue
		{
			get => GetProperty(ref _newValue);
			set => SetProperty(ref _newValue, value);
		}

		public gameJournalQuestObjectiveCounterData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
