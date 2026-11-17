using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class MutedItemCosmetic : WarnModificationCosmetic
	{
		[Ordinal(15)] 
		[RED("checkboxFill")] 
		public inkWidgetReference CheckboxFill
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(16)] 
		[RED("isHiddenText")] 
		public inkTextWidgetReference IsHiddenText
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(17)] 
		[RED("panelOutline")] 
		public inkWidgetReference PanelOutline
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(18)] 
		[RED("panelBackground")] 
		public inkWidgetReference PanelBackground
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(19)] 
		[RED("colorNames")] 
		public ModsMenuColorsNames ColorNames
		{
			get => GetPropertyValue<ModsMenuColorsNames>();
			set => SetPropertyValue<ModsMenuColorsNames>(value);
		}

		public MutedItemCosmetic()
		{
			CheckboxFill = new inkWidgetReference();
			IsHiddenText = new inkTextWidgetReference();
			PanelOutline = new inkWidgetReference();
			PanelBackground = new inkWidgetReference();
			ColorNames = new ModsMenuColorsNames();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
