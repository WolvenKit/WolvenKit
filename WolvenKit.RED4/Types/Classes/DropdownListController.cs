using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class DropdownListController : inkWidgetLogicController
	{
		[Ordinal(1)] 
		[RED("listContainer")] 
		public inkCompoundWidgetReference ListContainer
		{
			get => GetPropertyValue<inkCompoundWidgetReference>();
			set => SetPropertyValue<inkCompoundWidgetReference>(value);
		}

		[Ordinal(2)] 
		[RED("ownerController")] 
		public CWeakHandle<IScriptable> OwnerController
		{
			get => GetPropertyValue<CWeakHandle<IScriptable>>();
			set => SetPropertyValue<CWeakHandle<IScriptable>>(value);
		}

		[Ordinal(3)] 
		[RED("triggerButton")] 
		public CWeakHandle<DropdownButtonController> TriggerButton
		{
			get => GetPropertyValue<CWeakHandle<DropdownButtonController>>();
			set => SetPropertyValue<CWeakHandle<DropdownButtonController>>(value);
		}

		[Ordinal(4)] 
		[RED("displayContext")] 
		public CEnum<DropdownDisplayContext> DisplayContext
		{
			get => GetPropertyValue<CEnum<DropdownDisplayContext>>();
			set => SetPropertyValue<CEnum<DropdownDisplayContext>>(value);
		}

		[Ordinal(5)] 
		[RED("activeElement")] 
		public CWeakHandle<DropdownElementController> ActiveElement
		{
			get => GetPropertyValue<CWeakHandle<DropdownElementController>>();
			set => SetPropertyValue<CWeakHandle<DropdownElementController>>(value);
		}

		[Ordinal(6)] 
		[RED("listOpened")] 
		public CBool ListOpened
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(7)] 
		[RED("data")] 
		public CArray<CHandle<DropdownItemData>> Data
		{
			get => GetPropertyValue<CArray<CHandle<DropdownItemData>>>();
			set => SetPropertyValue<CArray<CHandle<DropdownItemData>>>(value);
		}

		public DropdownListController()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
