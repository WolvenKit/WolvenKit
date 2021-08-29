using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameJournalQuestPhase : gameJournalContainerEntry
	{
		private NodeRef _locationPrefabRef;

		[Ordinal(2)] 
		[RED("locationPrefabRef")] 
		public NodeRef LocationPrefabRef
		{
			get => GetProperty(ref _locationPrefabRef);
			set => SetProperty(ref _locationPrefabRef, value);
		}
	}
}
