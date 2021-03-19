using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questJournalEntry_ConditionType : questIJournalConditionType
	{
		private CHandle<gameJournalPath> _path;
		private CEnum<gameJournalEntryUserState> _state;

		[Ordinal(0)] 
		[RED("path")] 
		public CHandle<gameJournalPath> Path
		{
			get => GetProperty(ref _path);
			set => SetProperty(ref _path, value);
		}

		[Ordinal(1)] 
		[RED("state")] 
		public CEnum<gameJournalEntryUserState> State
		{
			get => GetProperty(ref _state);
			set => SetProperty(ref _state, value);
		}

		public questJournalEntry_ConditionType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
