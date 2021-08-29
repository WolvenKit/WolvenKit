using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class hudCorpoController : gameuiHUDGameController
	{
		private inkTextWidgetReference _scrollText;
		private inkWidgetReference _scrollTextWidget;
		private inkWidgetReference _root_canvas;
		private CWeakHandle<inkCompoundWidget> _root;
		private CUInt32 _fact1ListenerId;
		private CUInt32 _fact2ListenerId;
		private CUInt32 _fact3ListenerId;
		private CUInt32 _fact4ListenerId;
		private CUInt32 _fact5ListenerId;

		[Ordinal(9)] 
		[RED("ScrollText")] 
		public inkTextWidgetReference ScrollText
		{
			get => GetProperty(ref _scrollText);
			set => SetProperty(ref _scrollText, value);
		}

		[Ordinal(10)] 
		[RED("ScrollTextWidget")] 
		public inkWidgetReference ScrollTextWidget
		{
			get => GetProperty(ref _scrollTextWidget);
			set => SetProperty(ref _scrollTextWidget, value);
		}

		[Ordinal(11)] 
		[RED("root_canvas")] 
		public inkWidgetReference Root_canvas
		{
			get => GetProperty(ref _root_canvas);
			set => SetProperty(ref _root_canvas, value);
		}

		[Ordinal(12)] 
		[RED("root")] 
		public CWeakHandle<inkCompoundWidget> Root
		{
			get => GetProperty(ref _root);
			set => SetProperty(ref _root, value);
		}

		[Ordinal(13)] 
		[RED("fact1ListenerId")] 
		public CUInt32 Fact1ListenerId
		{
			get => GetProperty(ref _fact1ListenerId);
			set => SetProperty(ref _fact1ListenerId, value);
		}

		[Ordinal(14)] 
		[RED("fact2ListenerId")] 
		public CUInt32 Fact2ListenerId
		{
			get => GetProperty(ref _fact2ListenerId);
			set => SetProperty(ref _fact2ListenerId, value);
		}

		[Ordinal(15)] 
		[RED("fact3ListenerId")] 
		public CUInt32 Fact3ListenerId
		{
			get => GetProperty(ref _fact3ListenerId);
			set => SetProperty(ref _fact3ListenerId, value);
		}

		[Ordinal(16)] 
		[RED("fact4ListenerId")] 
		public CUInt32 Fact4ListenerId
		{
			get => GetProperty(ref _fact4ListenerId);
			set => SetProperty(ref _fact4ListenerId, value);
		}

		[Ordinal(17)] 
		[RED("fact5ListenerId")] 
		public CUInt32 Fact5ListenerId
		{
			get => GetProperty(ref _fact5ListenerId);
			set => SetProperty(ref _fact5ListenerId, value);
		}
	}
}
