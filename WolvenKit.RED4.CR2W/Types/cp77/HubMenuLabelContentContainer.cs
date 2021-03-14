using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class HubMenuLabelContentContainer : inkWidgetLogicController
	{
		private inkTextWidgetReference _label;
		private inkImageWidgetReference _icon;
		private inkWidgetReference _desiredSizeWrapper;
		private inkBorderWidgetReference _border;
		private CInt32 _carouselPosition;
		private CString _labelName;
		private MenuData _data;

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
		[RED("desiredSizeWrapper")] 
		public inkWidgetReference DesiredSizeWrapper
		{
			get
			{
				if (_desiredSizeWrapper == null)
				{
					_desiredSizeWrapper = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "desiredSizeWrapper", cr2w, this);
				}
				return _desiredSizeWrapper;
			}
			set
			{
				if (_desiredSizeWrapper == value)
				{
					return;
				}
				_desiredSizeWrapper = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("border")] 
		public inkBorderWidgetReference Border
		{
			get
			{
				if (_border == null)
				{
					_border = (inkBorderWidgetReference) CR2WTypeManager.Create("inkBorderWidgetReference", "border", cr2w, this);
				}
				return _border;
			}
			set
			{
				if (_border == value)
				{
					return;
				}
				_border = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("carouselPosition")] 
		public CInt32 CarouselPosition
		{
			get
			{
				if (_carouselPosition == null)
				{
					_carouselPosition = (CInt32) CR2WTypeManager.Create("Int32", "carouselPosition", cr2w, this);
				}
				return _carouselPosition;
			}
			set
			{
				if (_carouselPosition == value)
				{
					return;
				}
				_carouselPosition = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("labelName")] 
		public CString LabelName
		{
			get
			{
				if (_labelName == null)
				{
					_labelName = (CString) CR2WTypeManager.Create("String", "labelName", cr2w, this);
				}
				return _labelName;
			}
			set
			{
				if (_labelName == value)
				{
					return;
				}
				_labelName = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("data")] 
		public MenuData Data
		{
			get
			{
				if (_data == null)
				{
					_data = (MenuData) CR2WTypeManager.Create("MenuData", "data", cr2w, this);
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

		public HubMenuLabelContentContainer(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
