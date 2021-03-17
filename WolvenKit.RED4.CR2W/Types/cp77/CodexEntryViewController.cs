using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class CodexEntryViewController : inkWidgetLogicController
	{
		private inkTextWidgetReference _titleText;
		private inkTextWidgetReference _descriptionText;
		private inkImageWidgetReference _imageWidget;
		private inkWidgetReference _imageWidgetFallback;
		private inkWidgetReference _imageWidgetWrapper;
		private inkWidgetReference _scrollWidget;
		private inkWidgetReference _contentWrapper;
		private inkWidgetReference _noEntrySelectedWidget;
		private CHandle<GenericCodexEntryData> _data;
		private wCHandle<inkScrollController> _scroll;

		[Ordinal(1)] 
		[RED("titleText")] 
		public inkTextWidgetReference TitleText
		{
			get => GetProperty(ref _titleText);
			set => SetProperty(ref _titleText, value);
		}

		[Ordinal(2)] 
		[RED("descriptionText")] 
		public inkTextWidgetReference DescriptionText
		{
			get => GetProperty(ref _descriptionText);
			set => SetProperty(ref _descriptionText, value);
		}

		[Ordinal(3)] 
		[RED("imageWidget")] 
		public inkImageWidgetReference ImageWidget
		{
			get => GetProperty(ref _imageWidget);
			set => SetProperty(ref _imageWidget, value);
		}

		[Ordinal(4)] 
		[RED("imageWidgetFallback")] 
		public inkWidgetReference ImageWidgetFallback
		{
			get => GetProperty(ref _imageWidgetFallback);
			set => SetProperty(ref _imageWidgetFallback, value);
		}

		[Ordinal(5)] 
		[RED("imageWidgetWrapper")] 
		public inkWidgetReference ImageWidgetWrapper
		{
			get => GetProperty(ref _imageWidgetWrapper);
			set => SetProperty(ref _imageWidgetWrapper, value);
		}

		[Ordinal(6)] 
		[RED("scrollWidget")] 
		public inkWidgetReference ScrollWidget
		{
			get => GetProperty(ref _scrollWidget);
			set => SetProperty(ref _scrollWidget, value);
		}

		[Ordinal(7)] 
		[RED("contentWrapper")] 
		public inkWidgetReference ContentWrapper
		{
			get => GetProperty(ref _contentWrapper);
			set => SetProperty(ref _contentWrapper, value);
		}

		[Ordinal(8)] 
		[RED("noEntrySelectedWidget")] 
		public inkWidgetReference NoEntrySelectedWidget
		{
			get => GetProperty(ref _noEntrySelectedWidget);
			set => SetProperty(ref _noEntrySelectedWidget, value);
		}

		[Ordinal(9)] 
		[RED("data")] 
		public CHandle<GenericCodexEntryData> Data
		{
			get => GetProperty(ref _data);
			set => SetProperty(ref _data, value);
		}

		[Ordinal(10)] 
		[RED("scroll")] 
		public wCHandle<inkScrollController> Scroll
		{
			get => GetProperty(ref _scroll);
			set => SetProperty(ref _scroll, value);
		}

		public CodexEntryViewController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
