using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gamestateMachineparameterTypeInteractionDescription : IScriptable
	{
		[Ordinal(0)] 
		[RED("interactionEntity")] 
		public CWeakHandle<entEntity> InteractionEntity
		{
			get => GetPropertyValue<CWeakHandle<entEntity>>();
			set => SetPropertyValue<CWeakHandle<entEntity>>(value);
		}

		[Ordinal(1)] 
		[RED("interactionType")] 
		public CName InteractionType
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		public gamestateMachineparameterTypeInteractionDescription()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
