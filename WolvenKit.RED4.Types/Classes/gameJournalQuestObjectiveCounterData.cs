using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameJournalQuestObjectiveCounterData : RedBaseClass
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
	}
}
