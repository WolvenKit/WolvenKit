using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class sampleStylesGameController : gameuiWidgetGameController
	{
		private wCHandle<inkTextWidget> _stateText;
		private wCHandle<inkButtonController> _button1Controller;
		private wCHandle<inkButtonController> _button2Controller;

		[Ordinal(2)] 
		[RED("stateText")] 
		public wCHandle<inkTextWidget> StateText
		{
			get
			{
				if (_stateText == null)
				{
					_stateText = (wCHandle<inkTextWidget>) CR2WTypeManager.Create("whandle:inkTextWidget", "stateText", cr2w, this);
				}
				return _stateText;
			}
			set
			{
				if (_stateText == value)
				{
					return;
				}
				_stateText = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("button1Controller")] 
		public wCHandle<inkButtonController> Button1Controller
		{
			get
			{
				if (_button1Controller == null)
				{
					_button1Controller = (wCHandle<inkButtonController>) CR2WTypeManager.Create("whandle:inkButtonController", "button1Controller", cr2w, this);
				}
				return _button1Controller;
			}
			set
			{
				if (_button1Controller == value)
				{
					return;
				}
				_button1Controller = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("button2Controller")] 
		public wCHandle<inkButtonController> Button2Controller
		{
			get
			{
				if (_button2Controller == null)
				{
					_button2Controller = (wCHandle<inkButtonController>) CR2WTypeManager.Create("whandle:inkButtonController", "button2Controller", cr2w, this);
				}
				return _button2Controller;
			}
			set
			{
				if (_button2Controller == value)
				{
					return;
				}
				_button2Controller = value;
				PropertySet(this);
			}
		}

		public sampleStylesGameController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
