using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class InventoryStatsList : inkWidgetLogicController
	{
		private wCHandle<inkTextWidget> _titleText;
		private wCHandle<inkCompoundWidget> _containerWidget;
		private CArray<wCHandle<inkWidget>> _widgtesList;

		[Ordinal(1)] 
		[RED("titleText")] 
		public wCHandle<inkTextWidget> TitleText
		{
			get
			{
				if (_titleText == null)
				{
					_titleText = (wCHandle<inkTextWidget>) CR2WTypeManager.Create("whandle:inkTextWidget", "titleText", cr2w, this);
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
		[RED("containerWidget")] 
		public wCHandle<inkCompoundWidget> ContainerWidget
		{
			get
			{
				if (_containerWidget == null)
				{
					_containerWidget = (wCHandle<inkCompoundWidget>) CR2WTypeManager.Create("whandle:inkCompoundWidget", "containerWidget", cr2w, this);
				}
				return _containerWidget;
			}
			set
			{
				if (_containerWidget == value)
				{
					return;
				}
				_containerWidget = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("widgtesList")] 
		public CArray<wCHandle<inkWidget>> WidgtesList
		{
			get
			{
				if (_widgtesList == null)
				{
					_widgtesList = (CArray<wCHandle<inkWidget>>) CR2WTypeManager.Create("array:whandle:inkWidget", "widgtesList", cr2w, this);
				}
				return _widgtesList;
			}
			set
			{
				if (_widgtesList == value)
				{
					return;
				}
				_widgtesList = value;
				PropertySet(this);
			}
		}

		public InventoryStatsList(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
