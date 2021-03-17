using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class BrowserGameController : gameuiWidgetGameController
	{
		private inkWidgetReference _logicControllerRef;
		private wCHandle<gameJournalManager> _journalManager;
		private CArray<CName> _locationTags;

		[Ordinal(2)] 
		[RED("logicControllerRef")] 
		public inkWidgetReference LogicControllerRef
		{
			get => GetProperty(ref _logicControllerRef);
			set => SetProperty(ref _logicControllerRef, value);
		}

		[Ordinal(3)] 
		[RED("journalManager")] 
		public wCHandle<gameJournalManager> JournalManager
		{
			get => GetProperty(ref _journalManager);
			set => SetProperty(ref _journalManager, value);
		}

		[Ordinal(4)] 
		[RED("locationTags")] 
		public CArray<CName> LocationTags
		{
			get => GetProperty(ref _locationTags);
			set => SetProperty(ref _locationTags, value);
		}

		public BrowserGameController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
