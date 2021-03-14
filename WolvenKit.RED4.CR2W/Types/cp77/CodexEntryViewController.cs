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
			get
			{
				if (_titleText == null)
				{
					_titleText = (inkTextWidgetReference) CR2WTypeManager.Create("inkTextWidgetReference", "titleText", cr2w, this);
				}
				return _titleText;
			}
			set
			{
				if (_titleText == value)
				{
					return;
				}
				_titleText = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("descriptionText")] 
		public inkTextWidgetReference DescriptionText
		{
			get
			{
				if (_descriptionText == null)
				{
					_descriptionText = (inkTextWidgetReference) CR2WTypeManager.Create("inkTextWidgetReference", "descriptionText", cr2w, this);
				}
				return _descriptionText;
			}
			set
			{
				if (_descriptionText == value)
				{
					return;
				}
				_descriptionText = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("imageWidget")] 
		public inkImageWidgetReference ImageWidget
		{
			get
			{
				if (_imageWidget == null)
				{
					_imageWidget = (inkImageWidgetReference) CR2WTypeManager.Create("inkImageWidgetReference", "imageWidget", cr2w, this);
				}
				return _imageWidget;
			}
			set
			{
				if (_imageWidget == value)
				{
					return;
				}
				_imageWidget = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("imageWidgetFallback")] 
		public inkWidgetReference ImageWidgetFallback
		{
			get
			{
				if (_imageWidgetFallback == null)
				{
					_imageWidgetFallback = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "imageWidgetFallback", cr2w, this);
				}
				return _imageWidgetFallback;
			}
			set
			{
				if (_imageWidgetFallback == value)
				{
					return;
				}
				_imageWidgetFallback = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("imageWidgetWrapper")] 
		public inkWidgetReference ImageWidgetWrapper
		{
			get
			{
				if (_imageWidgetWrapper == null)
				{
					_imageWidgetWrapper = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "imageWidgetWrapper", cr2w, this);
				}
				return _imageWidgetWrapper;
			}
			set
			{
				if (_imageWidgetWrapper == value)
				{
					return;
				}
				_imageWidgetWrapper = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("scrollWidget")] 
		public inkWidgetReference ScrollWidget
		{
			get
			{
				if (_scrollWidget == null)
				{
					_scrollWidget = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "scrollWidget", cr2w, this);
				}
				return _scrollWidget;
			}
			set
			{
				if (_scrollWidget == value)
				{
					return;
				}
				_scrollWidget = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("contentWrapper")] 
		public inkWidgetReference ContentWrapper
		{
			get
			{
				if (_contentWrapper == null)
				{
					_contentWrapper = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "contentWrapper", cr2w, this);
				}
				return _contentWrapper;
			}
			set
			{
				if (_contentWrapper == value)
				{
					return;
				}
				_contentWrapper = value;
				PropertySet(this);
			}
		}

		[Ordinal(8)] 
		[RED("noEntrySelectedWidget")] 
		public inkWidgetReference NoEntrySelectedWidget
		{
			get
			{
				if (_noEntrySelectedWidget == null)
				{
					_noEntrySelectedWidget = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "noEntrySelectedWidget", cr2w, this);
				}
				return _noEntrySelectedWidget;
			}
			set
			{
				if (_noEntrySelectedWidget == value)
				{
					return;
				}
				_noEntrySelectedWidget = value;
				PropertySet(this);
			}
		}

		[Ordinal(9)] 
		[RED("data")] 
		public CHandle<GenericCodexEntryData> Data
		{
			get
			{
				if (_data == null)
				{
					_data = (CHandle<GenericCodexEntryData>) CR2WTypeManager.Create("handle:GenericCodexEntryData", "data", cr2w, this);
				}
				return _data;
			}
			set
			{
				if (_data == value)
				{
					return;
				}
				_data = value;
				PropertySet(this);
			}
		}

		[Ordinal(10)] 
		[RED("scroll")] 
		public wCHandle<inkScrollController> Scroll
		{
			get
			{
				if (_scroll == null)
				{
					_scroll = (wCHandle<inkScrollController>) CR2WTypeManager.Create("whandle:inkScrollController", "scroll", cr2w, this);
				}
				return _scroll;
			}
			set
			{
				if (_scroll == value)
				{
					return;
				}
				_scroll = value;
				PropertySet(this);
			}
		}

		public CodexEntryViewController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
