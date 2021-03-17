using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ComputerDocumentWidgetController : DeviceInkLogicControllerBase
	{
		private inkTextWidgetReference _titleWidget;
		private inkTextWidgetReference _ownerNameWidget;
		private inkTextWidgetReference _dateWidget;
		private inkTextWidgetReference _datePanelWidget;
		private inkTextWidgetReference _ownerPanelWidget;
		private inkTextWidgetReference _textContentWidget;
		private inkWidgetReference _textContentHolder;
		private inkVideoWidgetReference _videoContentWidget;
		private inkImageWidgetReference _imageContentWidget;
		private inkWidgetReference _closeButtonWidget;
		private CEnum<EDocumentType> _documentType;
		private redResourceReferenceScriptToken _lastPlayedVideo;

		[Ordinal(5)] 
		[RED("titleWidget")] 
		public inkTextWidgetReference TitleWidget
		{
			get => GetProperty(ref _titleWidget);
			set => SetProperty(ref _titleWidget, value);
		}

		[Ordinal(6)] 
		[RED("ownerNameWidget")] 
		public inkTextWidgetReference OwnerNameWidget
		{
			get => GetProperty(ref _ownerNameWidget);
			set => SetProperty(ref _ownerNameWidget, value);
		}

		[Ordinal(7)] 
		[RED("dateWidget")] 
		public inkTextWidgetReference DateWidget
		{
			get => GetProperty(ref _dateWidget);
			set => SetProperty(ref _dateWidget, value);
		}

		[Ordinal(8)] 
		[RED("datePanelWidget")] 
		public inkTextWidgetReference DatePanelWidget
		{
			get => GetProperty(ref _datePanelWidget);
			set => SetProperty(ref _datePanelWidget, value);
		}

		[Ordinal(9)] 
		[RED("ownerPanelWidget")] 
		public inkTextWidgetReference OwnerPanelWidget
		{
			get => GetProperty(ref _ownerPanelWidget);
			set => SetProperty(ref _ownerPanelWidget, value);
		}

		[Ordinal(10)] 
		[RED("textContentWidget")] 
		public inkTextWidgetReference TextContentWidget
		{
			get => GetProperty(ref _textContentWidget);
			set => SetProperty(ref _textContentWidget, value);
		}

		[Ordinal(11)] 
		[RED("textContentHolder")] 
		public inkWidgetReference TextContentHolder
		{
			get => GetProperty(ref _textContentHolder);
			set => SetProperty(ref _textContentHolder, value);
		}

		[Ordinal(12)] 
		[RED("videoContentWidget")] 
		public inkVideoWidgetReference VideoContentWidget
		{
			get => GetProperty(ref _videoContentWidget);
			set => SetProperty(ref _videoContentWidget, value);
		}

		[Ordinal(13)] 
		[RED("imageContentWidget")] 
		public inkImageWidgetReference ImageContentWidget
		{
			get => GetProperty(ref _imageContentWidget);
			set => SetProperty(ref _imageContentWidget, value);
		}

		[Ordinal(14)] 
		[RED("closeButtonWidget")] 
		public inkWidgetReference CloseButtonWidget
		{
			get => GetProperty(ref _closeButtonWidget);
			set => SetProperty(ref _closeButtonWidget, value);
		}

		[Ordinal(15)] 
		[RED("documentType")] 
		public CEnum<EDocumentType> DocumentType
		{
			get => GetProperty(ref _documentType);
			set => SetProperty(ref _documentType, value);
		}

		[Ordinal(16)] 
		[RED("lastPlayedVideo")] 
		public redResourceReferenceScriptToken LastPlayedVideo
		{
			get => GetProperty(ref _lastPlayedVideo);
			set => SetProperty(ref _lastPlayedVideo, value);
		}

		public ComputerDocumentWidgetController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
