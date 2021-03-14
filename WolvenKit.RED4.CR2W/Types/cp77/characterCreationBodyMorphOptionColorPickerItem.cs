using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class characterCreationBodyMorphOptionColorPickerItem : inkWidgetLogicController
	{
		private inkWidgetReference _background;
		private inkImageWidgetReference _icon;
		private inkWidgetReference _foreground;
		private inkWidgetReference _selectionMark;

		[Ordinal(1)] 
		[RED("background")] 
		public inkWidgetReference Background
		{
			get
			{
				if (_background == null)
				{
					_background = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "background", cr2w, this);
				}
				return _background;
			}
			set
			{
				if (_background == value)
				{
					return;
				}
				_background = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("icon")] 
		public inkImageWidgetReference Icon
		{
			get
			{
				if (_icon == null)
				{
					_icon = (inkImageWidgetReference) CR2WTypeManager.Create("inkImageWidgetReference", "icon", cr2w, this);
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

		[Ordinal(3)] 
		[RED("foreground")] 
		public inkWidgetReference Foreground
		{
			get
			{
				if (_foreground == null)
				{
					_foreground = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "foreground", cr2w, this);
				}
				return _foreground;
			}
			set
			{
				if (_foreground == value)
				{
					return;
				}
				_foreground = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("selectionMark")] 
		public inkWidgetReference SelectionMark
		{
			get
			{
				if (_selectionMark == null)
				{
					_selectionMark = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "selectionMark", cr2w, this);
				}
				return _selectionMark;
			}
			set
			{
				if (_selectionMark == value)
				{
					return;
				}
				_selectionMark = value;
				PropertySet(this);
			}
		}

		public characterCreationBodyMorphOptionColorPickerItem(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
