using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class DropdownElementController : BaseButtonView
	{
		private inkTextWidgetReference _text;
		private inkImageWidgetReference _arrow;
		private inkWidgetReference _frame;
		private inkWidgetReference _contentContainer;
		private CHandle<DropdownItemData> _data;
		private CBool _active;

		[Ordinal(2)] 
		[RED("text")] 
		public inkTextWidgetReference Text
		{
			get
			{
				if (_text == null)
				{
					_text = (inkTextWidgetReference) CR2WTypeManager.Create("inkTextWidgetReference", "text", cr2w, this);
				}
				return _text;
			}
			set
			{
				if (_text == value)
				{
					return;
				}
				_text = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
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

		[Ordinal(4)] 
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

		[Ordinal(5)] 
		[RED("contentContainer")] 
		public inkWidgetReference ContentContainer
		{
			get
			{
				if (_contentContainer == null)
				{
					_contentContainer = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "contentContainer", cr2w, this);
				}
				return _contentContainer;
			}
			set
			{
				if (_contentContainer == value)
				{
					return;
				}
				_contentContainer = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("data")] 
		public CHandle<DropdownItemData> Data
		{
			get
			{
				if (_data == null)
				{
					_data = (CHandle<DropdownItemData>) CR2WTypeManager.Create("handle:DropdownItemData", "data", cr2w, this);
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

		[Ordinal(7)] 
		[RED("active")] 
		public CBool Active
		{
			get
			{
				if (_active == null)
				{
					_active = (CBool) CR2WTypeManager.Create("Bool", "active", cr2w, this);
				}
				return _active;
			}
			set
			{
				if (_active == value)
				{
					return;
				}
				_active = value;
				PropertySet(this);
			}
		}

		public DropdownElementController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
