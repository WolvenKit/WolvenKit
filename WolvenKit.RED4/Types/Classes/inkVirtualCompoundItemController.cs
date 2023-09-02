using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class inkVirtualCompoundItemController : inkButtonController
	{
		[Ordinal(10)] 
		[RED("ToggledOff")] 
		public inkVirtualCompoundItemControllerCallback ToggledOff
		{
			get => GetPropertyValue<inkVirtualCompoundItemControllerCallback>();
			set => SetPropertyValue<inkVirtualCompoundItemControllerCallback>(value);
		}

		[Ordinal(11)] 
		[RED("ToggledOn")] 
		public inkVirtualCompoundItemControllerCallback ToggledOn
		{
			get => GetPropertyValue<inkVirtualCompoundItemControllerCallback>();
			set => SetPropertyValue<inkVirtualCompoundItemControllerCallback>(value);
		}

		[Ordinal(12)] 
		[RED("Selected")] 
		public inkVirtualCompoundItemSelectControllerCallback Selected_672
		{
			get => GetPropertyValue<inkVirtualCompoundItemSelectControllerCallback>();
			set => SetPropertyValue<inkVirtualCompoundItemSelectControllerCallback>(value);
		}

		[Ordinal(13)] 
		[RED("Deselected")] 
		public inkVirtualCompoundItemControllerCallback Deselected
		{
			get => GetPropertyValue<inkVirtualCompoundItemControllerCallback>();
			set => SetPropertyValue<inkVirtualCompoundItemControllerCallback>(value);
		}

		[Ordinal(14)] 
		[RED("Added")] 
		public inkVirtualCompoundItemControllerCallback Added
		{
			get => GetPropertyValue<inkVirtualCompoundItemControllerCallback>();
			set => SetPropertyValue<inkVirtualCompoundItemControllerCallback>(value);
		}

		public inkVirtualCompoundItemController()
		{
			ToggledOff = new inkVirtualCompoundItemControllerCallback();
			ToggledOn = new inkVirtualCompoundItemControllerCallback();
			Selected_672 = new inkVirtualCompoundItemSelectControllerCallback();
			Deselected = new inkVirtualCompoundItemControllerCallback();
			Added = new inkVirtualCompoundItemControllerCallback();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
