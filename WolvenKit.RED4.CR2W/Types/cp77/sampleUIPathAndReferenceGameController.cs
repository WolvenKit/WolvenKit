using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class sampleUIPathAndReferenceGameController : gameuiWidgetGameController
	{
		private inkTextWidgetReference _textWidget;
		private inkWidgetPath _imageWidgetPath;
		private wCHandle<inkImageWidget> _imageWidget;
		private wCHandle<inkBasePanelWidget> _panelWidget;

		[Ordinal(2)] 
		[RED("textWidget")] 
		public inkTextWidgetReference TextWidget
		{
			get
			{
				if (_textWidget == null)
				{
					_textWidget = (inkTextWidgetReference) CR2WTypeManager.Create("inkTextWidgetReference", "textWidget", cr2w, this);
				}
				return _textWidget;
			}
			set
			{
				if (_textWidget == value)
				{
					return;
				}
				_textWidget = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("imageWidgetPath")] 
		public inkWidgetPath ImageWidgetPath
		{
			get
			{
				if (_imageWidgetPath == null)
				{
					_imageWidgetPath = (inkWidgetPath) CR2WTypeManager.Create("inkWidgetPath", "imageWidgetPath", cr2w, this);
				}
				return _imageWidgetPath;
			}
			set
			{
				if (_imageWidgetPath == value)
				{
					return;
				}
				_imageWidgetPath = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("imageWidget")] 
		public wCHandle<inkImageWidget> ImageWidget
		{
			get
			{
				if (_imageWidget == null)
				{
					_imageWidget = (wCHandle<inkImageWidget>) CR2WTypeManager.Create("whandle:inkImageWidget", "imageWidget", cr2w, this);
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

		[Ordinal(5)] 
		[RED("panelWidget")] 
		public wCHandle<inkBasePanelWidget> PanelWidget
		{
			get
			{
				if (_panelWidget == null)
				{
					_panelWidget = (wCHandle<inkBasePanelWidget>) CR2WTypeManager.Create("whandle:inkBasePanelWidget", "panelWidget", cr2w, this);
				}
				return _panelWidget;
			}
			set
			{
				if (_panelWidget == value)
				{
					return;
				}
				_panelWidget = value;
				PropertySet(this);
			}
		}

		public sampleUIPathAndReferenceGameController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
