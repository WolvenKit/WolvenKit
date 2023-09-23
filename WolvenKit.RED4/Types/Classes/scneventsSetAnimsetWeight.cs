using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class scneventsSetAnimsetWeight : scnSceneEvent
	{
		[Ordinal(6)] 
		[RED("actorId")] 
		public scnActorId ActorId
		{
			get => GetPropertyValue<scnActorId>();
			set => SetPropertyValue<scnActorId>(value);
		}

		[Ordinal(7)] 
		[RED("animsetName")] 
		public CName AnimsetName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(8)] 
		[RED("weight")] 
		public CFloat Weight
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		public scneventsSetAnimsetWeight()
		{
			Id = new scnSceneEventId { Id = long.MaxValue };
			ActorId = new scnActorId { Id = uint.MaxValue };

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
