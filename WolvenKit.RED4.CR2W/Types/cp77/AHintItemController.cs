using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AHintItemController : inkWidgetLogicController
	{
		private inkImageWidgetReference _icon;
		private inkTextWidgetReference _unavaliableText;
		private wCHandle<inkWidget> _root;

		[Ordinal(1)] 
		[RED("Icon")] 
		public inkImageWidgetReference Icon
		{
			get
			{
				if (_icon == null)
				{
					_icon = (inkImageWidgetReference) CR2WTypeManager.Create("inkImageWidgetReference", "Icon", cr2w, this);
				}
				return _icon;
			}
			set
			{
				if (_icon == value)
				{
					return;
				}
				_icon = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("UnavaliableText")] 
		public inkTextWidgetReference UnavaliableText
		{
			get
			{
				if (_unavaliableText == null)
				{
					_unavaliableText = (inkTextWidgetReference) CR2WTypeManager.Create("inkTextWidgetReference", "UnavaliableText", cr2w, this);
				}
				return _unavaliableText;
			}
			set
			{
				if (_unavaliableText == value)
				{
					return;
				}
				_unavaliableText = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("Root")] 
		public wCHandle<inkWidget> Root
		{
			get
			{
				if (_root == null)
				{
					_root = (wCHandle<inkWidget>) CR2WTypeManager.Create("whandle:inkWidget", "Root", cr2w, this);
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

		public AHintItemController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
