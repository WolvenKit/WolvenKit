using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class inkComboBoxController : inkWidgetLogicController
	{
		[Ordinal(1)] 
		[RED("comboBoxObjectRef")] 
		public inkWidgetReference ComboBoxObjectRef
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(2)] 
		[RED("ComboBoxVisibleChanged")] 
		public inkComboBoxVisibleChangedCallback ComboBoxVisibleChanged
		{
			get => GetPropertyValue<inkComboBoxVisibleChangedCallback>();
			set => SetPropertyValue<inkComboBoxVisibleChangedCallback>(value);
		}

		public inkComboBoxController()
		{
			ComboBoxObjectRef = new();
			ComboBoxVisibleChanged = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
