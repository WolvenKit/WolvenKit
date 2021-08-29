using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class inkComboBoxController : inkWidgetLogicController
	{
		private inkWidgetReference _comboBoxObjectRef;
		private inkComboBoxVisibleChangedCallback _comboBoxVisibleChanged;

		[Ordinal(1)] 
		[RED("comboBoxObjectRef")] 
		public inkWidgetReference ComboBoxObjectRef
		{
			get => GetProperty(ref _comboBoxObjectRef);
			set => SetProperty(ref _comboBoxObjectRef, value);
		}

		[Ordinal(2)] 
		[RED("ComboBoxVisibleChanged")] 
		public inkComboBoxVisibleChangedCallback ComboBoxVisibleChanged
		{
			get => GetProperty(ref _comboBoxVisibleChanged);
			set => SetProperty(ref _comboBoxVisibleChanged, value);
		}
	}
}
