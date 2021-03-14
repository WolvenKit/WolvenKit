using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class VisibilitySimpleControllerBase : inkWidgetLogicController
	{
		private CArray<CName> _affectedWidgets;
		private CBool _isVisible;
		private wCHandle<inkWidget> _widget;

		[Ordinal(1)] 
		[RED("affectedWidgets")] 
		public CArray<CName> AffectedWidgets
		{
			get
			{
				if (_affectedWidgets == null)
				{
					_affectedWidgets = (CArray<CName>) CR2WTypeManager.Create("array:CName", "affectedWidgets", cr2w, this);
				}
				return _affectedWidgets;
			}
			set
			{
				if (_affectedWidgets == value)
				{
					return;
				}
				_affectedWidgets = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("isVisible")] 
		public CBool IsVisible
		{
			get
			{
				if (_isVisible == null)
				{
					_isVisible = (CBool) CR2WTypeManager.Create("Bool", "isVisible", cr2w, this);
				}
				return _isVisible;
			}
			set
			{
				if (_isVisible == value)
				{
					return;
				}
				_isVisible = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
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

		public VisibilitySimpleControllerBase(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
