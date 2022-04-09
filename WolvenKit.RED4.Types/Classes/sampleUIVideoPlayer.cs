using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class sampleUIVideoPlayer : inkWidgetLogicController
	{
		[Ordinal(1)] 
		[RED("videoWidgetPath")] 
		public CName VideoWidgetPath
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(2)] 
		[RED("counterWidgetPath")] 
		public CName CounterWidgetPath
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(3)] 
		[RED("lastFramePath")] 
		public CName LastFramePath
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(4)] 
		[RED("currentFramePath")] 
		public CName CurrentFramePath
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(5)] 
		[RED("videoWidget")] 
		public CWeakHandle<inkVideoWidget> VideoWidget
		{
			get => GetPropertyValue<CWeakHandle<inkVideoWidget>>();
			set => SetPropertyValue<CWeakHandle<inkVideoWidget>>(value);
		}

		[Ordinal(6)] 
		[RED("framesToSkipCounterWidget")] 
		public CWeakHandle<inkTextWidget> FramesToSkipCounterWidget
		{
			get => GetPropertyValue<CWeakHandle<inkTextWidget>>();
			set => SetPropertyValue<CWeakHandle<inkTextWidget>>(value);
		}

		[Ordinal(7)] 
		[RED("lastFrameWidget")] 
		public CWeakHandle<inkTextWidget> LastFrameWidget
		{
			get => GetPropertyValue<CWeakHandle<inkTextWidget>>();
			set => SetPropertyValue<CWeakHandle<inkTextWidget>>(value);
		}

		[Ordinal(8)] 
		[RED("currentFrameWidget")] 
		public CWeakHandle<inkTextWidget> CurrentFrameWidget
		{
			get => GetPropertyValue<CWeakHandle<inkTextWidget>>();
			set => SetPropertyValue<CWeakHandle<inkTextWidget>>(value);
		}

		[Ordinal(9)] 
		[RED("numberOfFrames")] 
		public CUInt32 NumberOfFrames
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		public sampleUIVideoPlayer()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
