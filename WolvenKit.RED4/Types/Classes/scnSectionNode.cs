using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class scnSectionNode : scnSceneGraphNode
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
		[RED("isFocusClue")] 
		public CBool IsFocusClue
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public scnSectionNode()
		{
			NodeId = new() { Id = 4294967295 };
			OutputSockets = new();
			Events = new();
			SectionDuration = new();
			ActorBehaviors = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
