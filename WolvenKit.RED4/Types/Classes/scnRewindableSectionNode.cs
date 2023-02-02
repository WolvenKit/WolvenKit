using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class scnRewindableSectionNode : scnSceneGraphNode
	{
		[Ordinal(3)] 
		[RED("events")] 
		public CArray<CHandle<scnSceneEvent>> Events
		{
			get => GetPropertyValue<CArray<CHandle<scnSceneEvent>>>();
			set => SetPropertyValue<CArray<CHandle<scnSceneEvent>>>(value);
		}

		[Ordinal(4)] 
		[RED("sectionDuration")] 
		public scnSceneTime SectionDuration
		{
			get => GetPropertyValue<scnSceneTime>();
			set => SetPropertyValue<scnSceneTime>(value);
		}

		[Ordinal(5)] 
		[RED("actorBehaviors")] 
		public CArray<scnSectionInternalsActorBehavior> ActorBehaviors
		{
			get => GetPropertyValue<CArray<scnSectionInternalsActorBehavior>>();
			set => SetPropertyValue<CArray<scnSectionInternalsActorBehavior>>(value);
		}

		[Ordinal(6)] 
		[RED("playSpeedModifiers")] 
		public scnRewindableSectionPlaySpeedModifiers PlaySpeedModifiers
		{
			get => GetPropertyValue<scnRewindableSectionPlaySpeedModifiers>();
			set => SetPropertyValue<scnRewindableSectionPlaySpeedModifiers>(value);
		}

		public scnRewindableSectionNode()
		{
			NodeId = new() { Id = 4294967295 };
			OutputSockets = new();
			Events = new();
			SectionDuration = new();
			ActorBehaviors = new();
			PlaySpeedModifiers = new() { ForwardVeryFast = 6.000000F, ForwardFast = 3.000000F, ForwardSlow = 0.500000F, BackwardVeryFast = 6.000000F, BackwardFast = 3.000000F, BackwardSlow = 0.500000F };

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
