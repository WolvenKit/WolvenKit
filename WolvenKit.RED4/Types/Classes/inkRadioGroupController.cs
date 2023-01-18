using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class inkRadioGroupController : inkWidgetLogicController
	{
		[Ordinal(1)] 
		[RED("toggleRefs")] 
		public CArray<inkWidgetReference> ToggleRefs
		{
			get => GetPropertyValue<CArray<inkWidgetReference>>();
			set => SetPropertyValue<CArray<inkWidgetReference>>(value);
		}

		[Ordinal(2)] 
		[RED("alwaysToggled")] 
		public CBool AlwaysToggled
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(3)] 
		[RED("selectedIndex")] 
		public CInt32 SelectedIndex
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(4)] 
		[RED("ValueChanged")] 
		public inkRadioGroupChangedCallback ValueChanged
		{
			get => GetPropertyValue<inkRadioGroupChangedCallback>();
			set => SetPropertyValue<inkRadioGroupChangedCallback>(value);
		}

		public inkRadioGroupController()
		{
			ToggleRefs = new();
			SelectedIndex = -1;
			ValueChanged = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
