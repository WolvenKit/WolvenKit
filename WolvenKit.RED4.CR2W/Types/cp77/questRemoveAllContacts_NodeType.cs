using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questRemoveAllContacts_NodeType : questIPhoneManagerNodeType
	{
		private CArray<CHandle<gameJournalPath>> _excludedContacts;

		[Ordinal(0)] 
		[RED("excludedContacts")] 
		public CArray<CHandle<gameJournalPath>> ExcludedContacts
		{
			get => GetProperty(ref _excludedContacts);
			set => SetProperty(ref _excludedContacts, value);
		}

		public questRemoveAllContacts_NodeType(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
