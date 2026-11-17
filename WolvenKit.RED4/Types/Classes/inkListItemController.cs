using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class inkListItemController : inkButtonController
	{
		[Ordinal(13)] 
		[RED("ToggledOff")] 
		public inkListItemControllerCallback ToggledOff
		{
			get => GetPropertyValue<inkListItemControllerCallback>();
			set => SetPropertyValue<inkListItemControllerCallback>(value);
		}

		[Ordinal(14)] 
		[RED("ToggledOn")] 
		public inkListItemControllerCallback ToggledOn
		{
			get => GetPropertyValue<inkListItemControllerCallback>();
			set => SetPropertyValue<inkListItemControllerCallback>(value);
		}

		[Ordinal(15)] 
		[RED("Selected")] 
		public inkListItemControllerCallback Selected_744
		{
			get => GetPropertyValue<inkListItemControllerCallback>();
			set => SetPropertyValue<inkListItemControllerCallback>(value);
		}

		[Ordinal(16)] 
		[RED("Deselected")] 
		public inkListItemControllerCallback Deselected
		{
			get => GetPropertyValue<inkListItemControllerCallback>();
			set => SetPropertyValue<inkListItemControllerCallback>(value);
		}

		[Ordinal(17)] 
		[RED("AddedToList")] 
		public inkListItemControllerCallback AddedToList
		{
			get => GetPropertyValue<inkListItemControllerCallback>();
			set => SetPropertyValue<inkListItemControllerCallback>(value);
		}

		[Ordinal(18)] 
		[RED("labelPathRef")] 
		public inkTextWidgetReference LabelPathRef
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		public inkListItemController()
		{
			ToggledOff = new inkListItemControllerCallback { CallbackName = "OnToggledOff" };
			ToggledOn = new inkListItemControllerCallback { CallbackName = "OnToggledOn" };
			Selected_744 = new inkListItemControllerCallback { CallbackName = "OnSelected" };
			Deselected = new inkListItemControllerCallback { CallbackName = "OnDeselected" };
			AddedToList = new inkListItemControllerCallback { CallbackName = "OnAddedToList" };
			LabelPathRef = new inkTextWidgetReference();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
