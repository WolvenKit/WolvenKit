using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class DropdownListController : inkWidgetLogicController
	{
		private inkCompoundWidgetReference _listContainer;
		private CWeakHandle<IScriptable> _ownerController;
		private CWeakHandle<DropdownButtonController> _triggerButton;
		private CEnum<DropdownDisplayContext> _displayContext;
		private CWeakHandle<DropdownElementController> _activeElement;
		private CBool _listOpened;
		private CArray<CHandle<DropdownItemData>> _data;

		[Ordinal(1)] 
		[RED("listContainer")] 
		public inkCompoundWidgetReference ListContainer
		{
			get => GetProperty(ref _listContainer);
			set => SetProperty(ref _listContainer, value);
		}

		[Ordinal(2)] 
		[RED("ownerController")] 
		public CWeakHandle<IScriptable> OwnerController
		{
			get => GetProperty(ref _ownerController);
			set => SetProperty(ref _ownerController, value);
		}

		[Ordinal(3)] 
		[RED("triggerButton")] 
		public CWeakHandle<DropdownButtonController> TriggerButton
		{
			get => GetProperty(ref _triggerButton);
			set => SetProperty(ref _triggerButton, value);
		}

		[Ordinal(4)] 
		[RED("displayContext")] 
		public CEnum<DropdownDisplayContext> DisplayContext
		{
			get => GetProperty(ref _displayContext);
			set => SetProperty(ref _displayContext, value);
		}

		[Ordinal(5)] 
		[RED("activeElement")] 
		public CWeakHandle<DropdownElementController> ActiveElement
		{
			get => GetProperty(ref _activeElement);
			set => SetProperty(ref _activeElement, value);
		}

		[Ordinal(6)] 
		[RED("listOpened")] 
		public CBool ListOpened
		{
			get => GetProperty(ref _listOpened);
			set => SetProperty(ref _listOpened, value);
		}

		[Ordinal(7)] 
		[RED("data")] 
		public CArray<CHandle<DropdownItemData>> Data
		{
			get => GetProperty(ref _data);
			set => SetProperty(ref _data, value);
		}
	}
}
