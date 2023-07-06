using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class sampleUILoadingBarController : inkWidgetLogicController
	{
		[Ordinal(1)] 
		[RED("minSize")] 
		public Vector2 MinSize
		{
			get => GetPropertyValue<Vector2>();
			set => SetPropertyValue<Vector2>(value);
		}

		[Ordinal(2)] 
		[RED("maxSize")] 
		public Vector2 MaxSize
		{
			get => GetPropertyValue<Vector2>();
			set => SetPropertyValue<Vector2>(value);
		}

		[Ordinal(3)] 
		[RED("imageWidgetPath")] 
		public CName ImageWidgetPath
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(4)] 
		[RED("textWidgetPath")] 
		public CName TextWidgetPath
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(5)] 
		[RED("currentSize")] 
		public Vector2 CurrentSize
		{
			get => GetPropertyValue<Vector2>();
			set => SetPropertyValue<Vector2>(value);
		}

		[Ordinal(6)] 
		[RED("imageWidget")] 
		public CWeakHandle<inkImageWidget> ImageWidget
		{
			get => GetPropertyValue<CWeakHandle<inkImageWidget>>();
			set => SetPropertyValue<CWeakHandle<inkImageWidget>>(value);
		}

		[Ordinal(7)] 
		[RED("textWidget")] 
		public CWeakHandle<inkTextWidget> TextWidget
		{
			get => GetPropertyValue<CWeakHandle<inkTextWidget>>();
			set => SetPropertyValue<CWeakHandle<inkTextWidget>>(value);
		}

		public sampleUILoadingBarController()
		{
			MinSize = new Vector2();
			MaxSize = new Vector2();
			CurrentSize = new Vector2();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
