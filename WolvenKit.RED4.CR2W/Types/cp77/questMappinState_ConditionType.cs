using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questMappinState_ConditionType : questIJournalConditionType
	{
		private CHandle<gameJournalPath> _mappinPath;
		private CBool _active;

		[Ordinal(0)] 
		[RED("mappinPath")] 
		public CHandle<gameJournalPath> MappinPath
		{
			get => GetProperty(ref _mappinPath);
			set => SetProperty(ref _mappinPath, value);
		}

		[Ordinal(1)] 
		[RED("active")] 
		public CBool Active
		{
			get => GetProperty(ref _active);
			set => SetProperty(ref _active, value);
		}

		public questMappinState_ConditionType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
