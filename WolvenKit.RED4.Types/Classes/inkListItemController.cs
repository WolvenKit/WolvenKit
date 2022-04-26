using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class inkListItemController : inkButtonController
	{
		[Ordinal(10)] 
		[RED("ToggledOff")] 
		public inkListItemControllerCallback ToggledOff
		{
			get => GetPropertyValue<inkListItemControllerCallback>();
			set => SetPropertyValue<inkListItemControllerCallback>(value);
		}

		[Ordinal(11)] 
		[RED("ToggledOn")] 
		public inkListItemControllerCallback ToggledOn
		{
			get => GetPropertyValue<inkListItemControllerCallback>();
			set => SetPropertyValue<inkListItemControllerCallback>(value);
		}

		[Ordinal(12)] 
		[RED("Selected")] 
		public inkListItemControllerCallback Selected_672
		{
			get => GetPropertyValue<inkListItemControllerCallback>();
			set => SetPropertyValue<inkListItemControllerCallback>(value);
		}

		[Ordinal(13)] 
		[RED("Deselected")] 
		public inkListItemControllerCallback Deselected
		{
			get => GetPropertyValue<inkListItemControllerCallback>();
			set => SetPropertyValue<inkListItemControllerCallback>(value);
		}

		[Ordinal(14)] 
		[RED("AddedToList")] 
		public inkListItemControllerCallback AddedToList
		{
			get => GetPropertyValue<inkListItemControllerCallback>();
			set => SetPropertyValue<inkListItemControllerCallback>(value);
		}

		[Ordinal(15)] 
		[RED("labelPathRef")] 
		public inkTextWidgetReference LabelPathRef
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		public inkListItemController()
		{
			ToggledOff = new();
			ToggledOn = new();
			Selected_672 = new();
			Deselected = new();
			AddedToList = new();
			LabelPathRef = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
