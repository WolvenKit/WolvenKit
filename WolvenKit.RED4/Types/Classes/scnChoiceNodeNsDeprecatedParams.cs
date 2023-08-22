using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class scnChoiceNodeNsDeprecatedParams : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("actorId")] 
		public scnActorId ActorId
		{
			get => GetPropertyValue<scnActorId>();
			set => SetPropertyValue<scnActorId>(value);
		}

		[Ordinal(1)] 
		[RED("propId")] 
		public scnPropId PropId
		{
			get => GetPropertyValue<scnPropId>();
			set => SetPropertyValue<scnPropId>(value);
		}

		public scnChoiceNodeNsDeprecatedParams()
		{
			ActorId = new scnActorId { Id = uint.MaxValue };
			PropId = new scnPropId { Id = uint.MaxValue };

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
