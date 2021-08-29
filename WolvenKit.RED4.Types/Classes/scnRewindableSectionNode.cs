using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class scnRewindableSectionNode : scnSceneGraphNode
	{
		private CArray<CHandle<scnSceneEvent>> _events;
		private scnSceneTime _sectionDuration;
		private CArray<scnSectionInternalsActorBehavior> _actorBehaviors;
		private scnRewindableSectionPlaySpeedModifiers _playSpeedModifiers;

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
		[RED("playSpeedModifiers")] 
		public scnRewindableSectionPlaySpeedModifiers PlaySpeedModifiers
		{
			get => GetProperty(ref _playSpeedModifiers);
			set => SetProperty(ref _playSpeedModifiers, value);
		}
	}
}
