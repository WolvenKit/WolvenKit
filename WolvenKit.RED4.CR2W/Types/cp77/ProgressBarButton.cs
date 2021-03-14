using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ProgressBarButton : inkWidgetLogicController
	{
		private inkWidgetReference _craftingFill;
		private inkTextWidgetReference _craftingLabel;
		private wCHandle<inkButtonController> _buttonController;
		private wCHandle<ProgressBarsController> _progressController;
		private CBool _available;

		[Ordinal(1)] 
		[RED("craftingFill")] 
		public inkWidgetReference CraftingFill
		{
			get
			{
				if (_craftingFill == null)
				{
					_craftingFill = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "craftingFill", cr2w, this);
				}
				return _craftingFill;
			}
			set
			{
				if (_craftingFill == value)
				{
					return;
				}
				_craftingFill = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("craftingLabel")] 
		public inkTextWidgetReference CraftingLabel
		{
			get
			{
				if (_craftingLabel == null)
				{
					_craftingLabel = (inkTextWidgetReference) CR2WTypeManager.Create("inkTextWidgetReference", "craftingLabel", cr2w, this);
				}
				return _craftingLabel;
			}
			set
			{
				if (_craftingLabel == value)
				{
					return;
				}
				_craftingLabel = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("ButtonController")] 
		public wCHandle<inkButtonController> ButtonController
		{
			get
			{
				if (_buttonController == null)
				{
					_buttonController = (wCHandle<inkButtonController>) CR2WTypeManager.Create("whandle:inkButtonController", "ButtonController", cr2w, this);
				}
				return _buttonController;
			}
			set
			{
				if (_buttonController == value)
				{
					return;
				}
				_buttonController = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("progressController")] 
		public wCHandle<ProgressBarsController> ProgressController
		{
			get
			{
				if (_progressController == null)
				{
					_progressController = (wCHandle<ProgressBarsController>) CR2WTypeManager.Create("whandle:ProgressBarsController", "progressController", cr2w, this);
				}
				return _progressController;
			}
			set
			{
				if (_progressController == value)
				{
					return;
				}
				_progressController = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("available")] 
		public CBool Available
		{
			get
			{
				if (_available == null)
				{
					_available = (CBool) CR2WTypeManager.Create("Bool", "available", cr2w, this);
				}
				return _available;
			}
			set
			{
				if (_available == value)
				{
					return;
				}
				_available = value;
				PropertySet(this);
			}
		}

		public ProgressBarButton(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
