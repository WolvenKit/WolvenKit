using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class inkWidgetLibraryItemInstance : ISerializable
	{
		[Ordinal(0)] 
		[RED("rootWidget")] 
		public CHandle<inkWidget> RootWidget
		{
			get => GetPropertyValue<CHandle<inkWidget>>();
			set => SetPropertyValue<CHandle<inkWidget>>(value);
		}

		[Ordinal(1)] 
		[RED("gameController")] 
		public CHandle<inkIWidgetController> GameController
		{
			get => GetPropertyValue<CHandle<inkIWidgetController>>();
			set => SetPropertyValue<CHandle<inkIWidgetController>>(value);
		}

		[Ordinal(2)] 
		[RED("rootResolution")] 
		public CEnum<inkETextureResolution> RootResolution
		{
			get => GetPropertyValue<CEnum<inkETextureResolution>>();
			set => SetPropertyValue<CEnum<inkETextureResolution>>(value);
		}

		public inkWidgetLibraryItemInstance()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
