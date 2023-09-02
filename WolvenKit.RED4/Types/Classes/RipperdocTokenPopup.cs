using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class RipperdocTokenPopup : gameuiWidgetGameController
	{
		[Ordinal(2)] 
		[RED("option1")] 
		public inkWidgetReference Option1
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(3)] 
		[RED("option2")] 
		public inkWidgetReference Option2
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(4)] 
		[RED("option3")] 
		public inkWidgetReference Option3
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(5)] 
		[RED("buttonCancel")] 
		public inkWidgetReference ButtonCancel
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(6)] 
		[RED("buttonHintsRoot")] 
		public inkWidgetReference ButtonHintsRoot
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(7)] 
		[RED("data")] 
		public CHandle<RipperdocTokenPopupData> Data
		{
			get => GetPropertyValue<CHandle<RipperdocTokenPopupData>>();
			set => SetPropertyValue<CHandle<RipperdocTokenPopupData>>(value);
		}

		[Ordinal(8)] 
		[RED("libraryPath")] 
		public inkWidgetLibraryReference LibraryPath
		{
			get => GetPropertyValue<inkWidgetLibraryReference>();
			set => SetPropertyValue<inkWidgetLibraryReference>(value);
		}

		public RipperdocTokenPopup()
		{
			Option1 = new inkWidgetReference();
			Option2 = new inkWidgetReference();
			Option3 = new inkWidgetReference();
			ButtonCancel = new inkWidgetReference();
			ButtonHintsRoot = new inkWidgetReference();
			LibraryPath = new inkWidgetLibraryReference { WidgetLibrary = new inkWidgetLibraryResourceWrapper() };

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
