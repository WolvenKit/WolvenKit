using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class ModMenuSearchBarController : inkWidgetLogicController
	{
		[Ordinal(1)] 
		[RED("searchBarInput")] 
		public inkTextInputWidgetReference SearchBarInput
		{
			get => GetPropertyValue<inkTextInputWidgetReference>();
			set => SetPropertyValue<inkTextInputWidgetReference>(value);
		}

		[Ordinal(2)] 
		[RED("searchBarDefaultText")] 
		public inkTextWidgetReference SearchBarDefaultText
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(3)] 
		[RED("isFocused")] 
		public CBool IsFocused
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(4)] 
		[RED("ignoreNextUnfocusCall")] 
		public CBool IgnoreNextUnfocusCall
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(5)] 
		[RED("ownerMenu")] 
		public CWeakHandle<BrowserModsMenuGameController> OwnerMenu
		{
			get => GetPropertyValue<CWeakHandle<BrowserModsMenuGameController>>();
			set => SetPropertyValue<CWeakHandle<BrowserModsMenuGameController>>(value);
		}

		public ModMenuSearchBarController()
		{
			SearchBarInput = new inkTextInputWidgetReference();
			SearchBarDefaultText = new inkTextWidgetReference();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
