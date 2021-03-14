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
			get
			{
				if (_titleWidget == null)
				{
					_titleWidget = (inkTextWidgetReference) CR2WTypeManager.Create("inkTextWidgetReference", "titleWidget", cr2w, this);
				}
				return _titleWidget;
			}
			set
			{
				if (_titleWidget == value)
				{
					return;
				}
				_titleWidget = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("ownerNameWidget")] 
		public inkTextWidgetReference OwnerNameWidget
		{
			get
			{
				if (_ownerNameWidget == null)
				{
					_ownerNameWidget = (inkTextWidgetReference) CR2WTypeManager.Create("inkTextWidgetReference", "ownerNameWidget", cr2w, this);
				}
				return _ownerNameWidget;
			}
			set
			{
				if (_ownerNameWidget == value)
				{
					return;
				}
				_ownerNameWidget = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("dateWidget")] 
		public inkTextWidgetReference DateWidget
		{
			get
			{
				if (_dateWidget == null)
				{
					_dateWidget = (inkTextWidgetReference) CR2WTypeManager.Create("inkTextWidgetReference", "dateWidget", cr2w, this);
				}
				return _dateWidget;
			}
			set
			{
				if (_dateWidget == value)
				{
					return;
				}
				_dateWidget = value;
				PropertySet(this);
			}
		}

		[Ordinal(8)] 
		[RED("datePanelWidget")] 
		public inkTextWidgetReference DatePanelWidget
		{
			get
			{
				if (_datePanelWidget == null)
				{
					_datePanelWidget = (inkTextWidgetReference) CR2WTypeManager.Create("inkTextWidgetReference", "datePanelWidget", cr2w, this);
				}
				return _datePanelWidget;
			}
			set
			{
				if (_datePanelWidget == value)
				{
					return;
				}
				_datePanelWidget = value;
				PropertySet(this);
			}
		}

		[Ordinal(9)] 
		[RED("ownerPanelWidget")] 
		public inkTextWidgetReference OwnerPanelWidget
		{
			get
			{
				if (_ownerPanelWidget == null)
				{
					_ownerPanelWidget = (inkTextWidgetReference) CR2WTypeManager.Create("inkTextWidgetReference", "ownerPanelWidget", cr2w, this);
				}
				return _ownerPanelWidget;
			}
			set
			{
				if (_ownerPanelWidget == value)
				{
					return;
				}
				_ownerPanelWidget = value;
				PropertySet(this);
			}
		}

		[Ordinal(10)] 
		[RED("textContentWidget")] 
		public inkTextWidgetReference TextContentWidget
		{
			get
			{
				if (_textContentWidget == null)
				{
					_textContentWidget = (inkTextWidgetReference) CR2WTypeManager.Create("inkTextWidgetReference", "textContentWidget", cr2w, this);
				}
				return _textContentWidget;
			}
			set
			{
				if (_textContentWidget == value)
				{
					return;
				}
				_textContentWidget = value;
				PropertySet(this);
			}
		}

		[Ordinal(11)] 
		[RED("textContentHolder")] 
		public inkWidgetReference TextContentHolder
		{
			get
			{
				if (_textContentHolder == null)
				{
					_textContentHolder = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "textContentHolder", cr2w, this);
				}
				return _textContentHolder;
			}
			set
			{
				if (_textContentHolder == value)
				{
					return;
				}
				_textContentHolder = value;
				PropertySet(this);
			}
		}

		[Ordinal(12)] 
		[RED("videoContentWidget")] 
		public inkVideoWidgetReference VideoContentWidget
		{
			get
			{
				if (_videoContentWidget == null)
				{
					_videoContentWidget = (inkVideoWidgetReference) CR2WTypeManager.Create("inkVideoWidgetReference", "videoContentWidget", cr2w, this);
				}
				return _videoContentWidget;
			}
			set
			{
				if (_videoContentWidget == value)
				{
					return;
				}
				_videoContentWidget = value;
				PropertySet(this);
			}
		}

		[Ordinal(13)] 
		[RED("imageContentWidget")] 
		public inkImageWidgetReference ImageContentWidget
		{
			get
			{
				if (_imageContentWidget == null)
				{
					_imageContentWidget = (inkImageWidgetReference) CR2WTypeManager.Create("inkImageWidgetReference", "imageContentWidget", cr2w, this);
				}
				return _imageContentWidget;
			}
			set
			{
				if (_imageContentWidget == value)
				{
					return;
				}
				_imageContentWidget = value;
				PropertySet(this);
			}
		}

		[Ordinal(14)] 
		[RED("closeButtonWidget")] 
		public inkWidgetReference CloseButtonWidget
		{
			get
			{
				if (_closeButtonWidget == null)
				{
					_closeButtonWidget = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "closeButtonWidget", cr2w, this);
				}
				return _closeButtonWidget;
			}
			set
			{
				if (_closeButtonWidget == value)
				{
					return;
				}
				_closeButtonWidget = value;
				PropertySet(this);
			}
		}

		[Ordinal(15)] 
		[RED("documentType")] 
		public CEnum<EDocumentType> DocumentType
		{
			get
			{
				if (_documentType == null)
				{
					_documentType = (CEnum<EDocumentType>) CR2WTypeManager.Create("EDocumentType", "documentType", cr2w, this);
				}
				return _documentType;
			}
			set
			{
				if (_documentType == value)
				{
					return;
				}
				_documentType = value;
				PropertySet(this);
			}
		}

		[Ordinal(16)] 
		[RED("lastPlayedVideo")] 
		public redResourceReferenceScriptToken LastPlayedVideo
		{
			get
			{
				if (_lastPlayedVideo == null)
				{
					_lastPlayedVideo = (redResourceReferenceScriptToken) CR2WTypeManager.Create("redResourceReferenceScriptToken", "lastPlayedVideo", cr2w, this);
				}
				return _lastPlayedVideo;
			}
			set
			{
				if (_lastPlayedVideo == value)
				{
					return;
				}
				_lastPlayedVideo = value;
				PropertySet(this);
			}
		}

		public ComputerDocumentWidgetController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
