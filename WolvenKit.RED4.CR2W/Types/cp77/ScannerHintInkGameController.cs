using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ScannerHintInkGameController : gameuiWidgetGameController
	{
		private wCHandle<inkTextWidget> _messegeWidget;
		private wCHandle<inkWidget> _root;
		private inkImageWidgetReference _iconWidget;

		[Ordinal(2)] 
		[RED("messegeWidget")] 
		public wCHandle<inkTextWidget> MessegeWidget
		{
			get
			{
				if (_messegeWidget == null)
				{
					_messegeWidget = (wCHandle<inkTextWidget>) CR2WTypeManager.Create("whandle:inkTextWidget", "messegeWidget", cr2w, this);
				}
				return _messegeWidget;
			}
			set
			{
				if (_messegeWidget == value)
				{
					return;
				}
				_messegeWidget = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("root")] 
		public wCHandle<inkWidget> Root
		{
			get
			{
				if (_root == null)
				{
					_root = (wCHandle<inkWidget>) CR2WTypeManager.Create("whandle:inkWidget", "root", cr2w, this);
				}
				return _root;
			}
			set
			{
				if (_root == value)
				{
					return;
				}
				_root = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("iconWidget")] 
		public inkImageWidgetReference IconWidget
		{
			get
			{
				if (_iconWidget == null)
				{
					_iconWidget = (inkImageWidgetReference) CR2WTypeManager.Create("inkImageWidgetReference", "iconWidget", cr2w, this);
				}
				return _iconWidget;
			}
			set
			{
				if (_iconWidget == value)
				{
					return;
				}
				_iconWidget = value;
				PropertySet(this);
			}
		}

		public ScannerHintInkGameController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
