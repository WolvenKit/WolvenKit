using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class scnAdditionalSpeaker : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("actorId")] 
		public scnActorId ActorId
		{
			get => GetPropertyValue<scnActorId>();
			set => SetPropertyValue<scnActorId>(value);
		}

		[Ordinal(1)] 
		[RED("type")] 
		public CEnum<scnAdditionalSpeakerType> Type
		{
			get => GetPropertyValue<CEnum<scnAdditionalSpeakerType>>();
			set => SetPropertyValue<CEnum<scnAdditionalSpeakerType>>(value);
		}

		public scnAdditionalSpeaker()
		{
			ActorId = new() { Id = 4294967295 };

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
