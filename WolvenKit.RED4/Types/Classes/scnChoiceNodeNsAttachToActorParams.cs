using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class scnChoiceNodeNsAttachToActorParams : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("actorId")] 
		public scnActorId ActorId
		{
			get => GetPropertyValue<scnActorId>();
			set => SetPropertyValue<scnActorId>(value);
		}

		[Ordinal(1)] 
		[RED("visualizerStyle")] 
		public CEnum<scnChoiceNodeNsVisualizerStyle> VisualizerStyle
		{
			get => GetPropertyValue<CEnum<scnChoiceNodeNsVisualizerStyle>>();
			set => SetPropertyValue<CEnum<scnChoiceNodeNsVisualizerStyle>>(value);
		}

		public scnChoiceNodeNsAttachToActorParams()
		{
			ActorId = new scnActorId { Id = uint.MaxValue };

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
