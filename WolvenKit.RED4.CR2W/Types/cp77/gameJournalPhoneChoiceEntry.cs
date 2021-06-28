using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameJournalPhoneChoiceEntry : gameJournalEntry
	{
		private LocalizationString _text;
		private CBool _isQuestImportant;

		[Ordinal(1)] 
		[RED("text")] 
		public LocalizationString Text
		{
			get => GetProperty(ref _text);
			set => SetProperty(ref _text, value);
		}

		[Ordinal(2)] 
		[RED("isQuestImportant")] 
		public CBool IsQuestImportant
		{
			get => GetProperty(ref _isQuestImportant);
			set => SetProperty(ref _isQuestImportant, value);
		}

		public gameJournalPhoneChoiceEntry(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
