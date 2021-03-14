using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ListItemStateMapper : inkWidgetLogicController
	{
		private CBool _toggled;
		private CBool _selected;
		private CBool _new;
		private wCHandle<inkWidget> _widget;

		[Ordinal(1)] 
		[RED("toggled")] 
		public CBool Toggled
		{
			get
			{
				if (_toggled == null)
				{
					_toggled = (CBool) CR2WTypeManager.Create("Bool", "toggled", cr2w, this);
				}
				return _toggled;
			}
			set
			{
				if (_toggled == value)
				{
					return;
				}
				_toggled = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("selected")] 
		public CBool Selected
		{
			get
			{
				if (_selected == null)
				{
					_selected = (CBool) CR2WTypeManager.Create("Bool", "selected", cr2w, this);
				}
				return _selected;
			}
			set
			{
				if (_selected == value)
				{
					return;
				}
				_selected = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("new")] 
		public CBool New
		{
			get
			{
				if (_new == null)
				{
					_new = (CBool) CR2WTypeManager.Create("Bool", "new", cr2w, this);
				}
				return _new;
			}
			set
			{
				if (_new == value)
				{
					return;
				}
				_new = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("widget")] 
		public wCHandle<inkWidget> Widget
		{
			get
			{
				if (_widget == null)
				{
					_widget = (wCHandle<inkWidget>) CR2WTypeManager.Create("whandle:inkWidget", "widget", cr2w, this);
				}
				return _widget;
			}
			set
			{
				if (_widget == value)
				{
					return;
				}
				_widget = value;
				PropertySet(this);
			}
		}

		public ListItemStateMapper(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
