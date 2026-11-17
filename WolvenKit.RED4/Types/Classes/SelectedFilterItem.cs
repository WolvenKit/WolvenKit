using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class SelectedFilterItem : inkButtonController
	{
		[Ordinal(13)] 
		[RED("crossButton")] 
		public inkWidgetReference CrossButton
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(14)] 
		[RED("filterName")] 
		public inkTextWidgetReference FilterName
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(15)] 
		[RED("widgetForSize")] 
		public inkWidgetReference WidgetForSize
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(16)] 
		[RED("fluffBackground")] 
		public inkWidgetReference FluffBackground
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(17)] 
		[RED("fluffOutline")] 
		public inkWidgetReference FluffOutline
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(18)] 
		[RED("panelOutline")] 
		public inkWidgetReference PanelOutline
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(19)] 
		[RED("panelBackground")] 
		public inkWidgetReference PanelBackground
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(20)] 
		[RED("owner")] 
		public CWeakHandle<SelectedFilterGroup> Owner
		{
			get => GetPropertyValue<CWeakHandle<SelectedFilterGroup>>();
			set => SetPropertyValue<CWeakHandle<SelectedFilterGroup>>(value);
		}

		[Ordinal(21)] 
		[RED("name")] 
		public CString Name
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}

		[Ordinal(22)] 
		[RED("localizedName")] 
		public CString LocalizedName
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}

		[Ordinal(23)] 
		[RED("bisExceptionFilter")] 
		public CBool BisExceptionFilter
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(24)] 
		[RED("markAsDelete")] 
		public CBool MarkAsDelete
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(25)] 
		[RED("colorNames")] 
		public ModsMenuColorsNames ColorNames
		{
			get => GetPropertyValue<ModsMenuColorsNames>();
			set => SetPropertyValue<ModsMenuColorsNames>(value);
		}

		public SelectedFilterItem()
		{
			CrossButton = new inkWidgetReference();
			FilterName = new inkTextWidgetReference();
			WidgetForSize = new inkWidgetReference();
			FluffBackground = new inkWidgetReference();
			FluffOutline = new inkWidgetReference();
			PanelOutline = new inkWidgetReference();
			PanelBackground = new inkWidgetReference();
			ColorNames = new ModsMenuColorsNames();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
