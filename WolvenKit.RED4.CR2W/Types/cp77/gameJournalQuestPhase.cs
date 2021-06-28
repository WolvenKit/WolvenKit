using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameJournalQuestPhase : gameJournalContainerEntry
	{
		private NodeRef _locationPrefabRef;

		[Ordinal(2)] 
		[RED("locationPrefabRef")] 
		public NodeRef LocationPrefabRef
		{
			get => GetProperty(ref _locationPrefabRef);
			set => SetProperty(ref _locationPrefabRef, value);
		}

		public gameJournalQuestPhase(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
