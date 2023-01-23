using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class inkVirtualCompoundController : inkDiscreteNavigationController
	{
		[Ordinal(4)] 
		[RED("ItemSelected")] 
		public inkVirtualCompoundControllerCallback ItemSelected
		{
			get => GetPropertyValue<inkVirtualCompoundControllerCallback>();
			set => SetPropertyValue<inkVirtualCompoundControllerCallback>(value);
		}

		[Ordinal(5)] 
		[RED("ItemActivated")] 
		public inkVirtualCompoundControllerCallback ItemActivated
		{
			get => GetPropertyValue<inkVirtualCompoundControllerCallback>();
			set => SetPropertyValue<inkVirtualCompoundControllerCallback>(value);
		}

		[Ordinal(6)] 
		[RED("AllElementsSpawned")] 
		public inkEmptyCallback AllElementsSpawned
		{
			get => GetPropertyValue<inkEmptyCallback>();
			set => SetPropertyValue<inkEmptyCallback>(value);
		}

		public inkVirtualCompoundController()
		{
			IsNavigalbe = true;
			SupportsHoldInput = true;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
