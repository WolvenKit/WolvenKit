using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class DropdownButtonController : inkWidgetLogicController
	{
		private inkTextWidgetReference _label;
		private inkImageWidgetReference _icon;
		private inkWidgetReference _frame;
		private inkImageWidgetReference _arrow;

		[Ordinal(1)] 
		[RED("label")] 
		public inkTextWidgetReference Label
		{
			get
			{
				if (_label == null)
				{
					_label = (inkTextWidgetReference) CR2WTypeManager.Create("inkTextWidgetReference", "label", cr2w, this);
				}
				return _label;
			}
			set
			{
				if (_label == value)
				{
					return;
				}
				_label = value;
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
		[RED("frame")] 
		public inkWidgetReference Frame
		{
			get
			{
				if (_frame == null)
				{
					_frame = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "frame", cr2w, this);
				}
				return _frame;
			}
			set
			{
				if (_frame == value)
				{
					return;
				}
				_frame = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("arrow")] 
		public inkImageWidgetReference Arrow
		{
			get
			{
				if (_arrow == null)
				{
					_arrow = (inkImageWidgetReference) CR2WTypeManager.Create("inkImageWidgetReference", "arrow", cr2w, this);
				}
				return _arrow;
			}
			set
			{
				if (_arrow == value)
				{
					return;
				}
				_arrow = value;
				PropertySet(this);
			}
		}

		public DropdownButtonController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
