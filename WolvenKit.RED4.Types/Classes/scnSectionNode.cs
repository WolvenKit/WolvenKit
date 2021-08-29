using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class scnSectionNode : scnSceneGraphNode
	{
		private CArray<CHandle<scnSceneEvent>> _events;
		private scnSceneTime _sectionDuration;
		private CArray<scnSectionInternalsActorBehavior> _actorBehaviors;
		private CBool _isFocusClue;

		[Ordinal(3)] 
		[RED("events")] 
		public CArray<CHandle<scnSceneEvent>> Events
		{
			get => GetProperty(ref _events);
			set => SetProperty(ref _events, value);
		}

		[Ordinal(4)] 
		[RED("sectionDuration")] 
		public scnSceneTime SectionDuration
		{
			get => GetProperty(ref _sectionDuration);
			set => SetProperty(ref _sectionDuration, value);
		}

		[Ordinal(5)] 
		[RED("actorBehaviors")] 
		public CArray<scnSectionInternalsActorBehavior> ActorBehaviors
		{
			get => GetProperty(ref _actorBehaviors);
			set => SetProperty(ref _actorBehaviors, value);
		}

		[Ordinal(6)] 
		[RED("isFocusClue")] 
		public CBool IsFocusClue
		{
			get => GetProperty(ref _isFocusClue);
			set => SetProperty(ref _isFocusClue, value);
		}
	}
}
