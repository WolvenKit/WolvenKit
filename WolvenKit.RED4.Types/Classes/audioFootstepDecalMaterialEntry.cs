using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class audioFootstepDecalMaterialEntry : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("materialTag")] 
		public CName MaterialTag
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(1)] 
		[RED("eventsByLocomotionState")] 
		public CHandle<audioLocomotionStateEventDictionary> EventsByLocomotionState
		{
			get => GetPropertyValue<CHandle<audioLocomotionStateEventDictionary>>();
			set => SetPropertyValue<CHandle<audioLocomotionStateEventDictionary>>(value);
		}

		public audioFootstepDecalMaterialEntry()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
