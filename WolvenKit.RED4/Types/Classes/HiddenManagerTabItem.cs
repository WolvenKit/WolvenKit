using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class HiddenManagerTabItem : WarnModificationCosmetic
	{
		[Ordinal(15)] 
		[RED("selectedStateCanvas")] 
		public inkWidgetReference SelectedStateCanvas
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(16)] 
		[RED("tabTextRef")] 
		public inkTextWidgetReference TabTextRef
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(17)] 
		[RED("frameRef")] 
		public inkWidgetReference FrameRef
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(18)] 
		[RED("isSelected")] 
		public CBool IsSelected
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(19)] 
		[RED("colorNames")] 
		public ModsMenuColorsNames ColorNames
		{
			get => GetPropertyValue<ModsMenuColorsNames>();
			set => SetPropertyValue<ModsMenuColorsNames>(value);
		}

		public HiddenManagerTabItem()
		{
			SelectedStateCanvas = new inkWidgetReference();
			TabTextRef = new inkTextWidgetReference();
			FrameRef = new inkWidgetReference();
			ColorNames = new ModsMenuColorsNames();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
