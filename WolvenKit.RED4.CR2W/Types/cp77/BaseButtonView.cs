using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class BaseButtonView : inkWidgetLogicController
	{
		private wCHandle<inkButtonController> _buttonController;

		[Ordinal(1)] 
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

		public BaseButtonView(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
