using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class characterCreationBodyMorphOptionColorPicker : inkWidgetLogicController
	{
		[Ordinal(1)] 
		[RED("grid")] 
		public inkUniformGridWidgetReference Grid
		{
			get => GetPropertyValue<inkUniformGridWidgetReference>();
			set => SetPropertyValue<inkUniformGridWidgetReference>(value);
		}

		[Ordinal(2)] 
		[RED("title")] 
		public inkTextWidgetReference Title
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(3)] 
		[RED("option")] 
		public CWeakHandle<gameuiCharacterCustomizationOption> Option
		{
			get => GetPropertyValue<CWeakHandle<gameuiCharacterCustomizationOption>>();
			set => SetPropertyValue<CWeakHandle<gameuiCharacterCustomizationOption>>(value);
		}

		[Ordinal(4)] 
		[RED("selectedIndex")] 
		public CInt32 SelectedIndex
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		public characterCreationBodyMorphOptionColorPicker()
		{
			Grid = new inkUniformGridWidgetReference();
			Title = new inkTextWidgetReference();
			SelectedIndex = -1;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
