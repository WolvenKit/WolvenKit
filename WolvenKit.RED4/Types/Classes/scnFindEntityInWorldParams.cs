using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class scnFindEntityInWorldParams : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("actorRef")] 
		public gameEntityReference ActorRef
		{
			get => GetPropertyValue<gameEntityReference>();
			set => SetPropertyValue<gameEntityReference>(value);
		}

		[Ordinal(1)] 
		[RED("forceMaxVisibility")] 
		public CBool ForceMaxVisibility
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public scnFindEntityInWorldParams()
		{
			ActorRef = new gameEntityReference { Names = new() };

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
