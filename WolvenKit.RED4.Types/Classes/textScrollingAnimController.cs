using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class textScrollingAnimController : inkWidgetLogicController
	{
		[Ordinal(1)] 
		[RED("scannerDetailsHackLog")] 
		public inkTextWidgetReference ScannerDetailsHackLog
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(2)] 
		[RED("defaultScrollSpeed")] 
		public CFloat DefaultScrollSpeed
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(3)] 
		[RED("playOnInit")] 
		public CBool PlayOnInit
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(4)] 
		[RED("numOfLines")] 
		public CInt32 NumOfLines
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(5)] 
		[RED("numOfStartingLines")] 
		public CInt32 NumOfStartingLines
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(6)] 
		[RED("transparency")] 
		public CFloat Transparency
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(7)] 
		[RED("gapIndex")] 
		public CInt32 GapIndex
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(8)] 
		[RED("binaryOnly")] 
		public CBool BinaryOnly
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(9)] 
		[RED("binaryClusterCount")] 
		public CInt32 BinaryClusterCount
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(10)] 
		[RED("scrollingText")] 
		public ScrollingText ScrollingText
		{
			get => GetPropertyValue<ScrollingText>();
			set => SetPropertyValue<ScrollingText>(value);
		}

		[Ordinal(11)] 
		[RED("logArray")] 
		public CArray<CString> LogArray
		{
			get => GetPropertyValue<CArray<CString>>();
			set => SetPropertyValue<CArray<CString>>(value);
		}

		[Ordinal(12)] 
		[RED("upload_counter")] 
		public CFloat Upload_counter
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(13)] 
		[RED("scrollSpeed")] 
		public CFloat ScrollSpeed
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(14)] 
		[RED("fastScrollSpeed")] 
		public CFloat FastScrollSpeed
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(15)] 
		[RED("panel")] 
		public CWeakHandle<inkCompoundWidget> Panel
		{
			get => GetPropertyValue<CWeakHandle<inkCompoundWidget>>();
			set => SetPropertyValue<CWeakHandle<inkCompoundWidget>>(value);
		}

		[Ordinal(16)] 
		[RED("alpha_fadein")] 
		public CHandle<inkanimDefinition> Alpha_fadein
		{
			get => GetPropertyValue<CHandle<inkanimDefinition>>();
			set => SetPropertyValue<CHandle<inkanimDefinition>>(value);
		}

		[Ordinal(17)] 
		[RED("AnimProxy")] 
		public CHandle<inkanimProxy> AnimProxy
		{
			get => GetPropertyValue<CHandle<inkanimProxy>>();
			set => SetPropertyValue<CHandle<inkanimProxy>>(value);
		}

		[Ordinal(18)] 
		[RED("AnimOptions")] 
		public inkanimPlaybackOptions AnimOptions
		{
			get => GetPropertyValue<inkanimPlaybackOptions>();
			set => SetPropertyValue<inkanimPlaybackOptions>(value);
		}

		[Ordinal(19)] 
		[RED("lineCount")] 
		public CInt32 LineCount
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		public textScrollingAnimController()
		{
			ScannerDetailsHackLog = new();
			DefaultScrollSpeed = 0.050000F;
			NumOfLines = 4;
			Transparency = 1.000000F;
			BinaryClusterCount = 4;
			ScrollingText = new() { TextArray = new() };
			LogArray = new();
			AnimOptions = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
