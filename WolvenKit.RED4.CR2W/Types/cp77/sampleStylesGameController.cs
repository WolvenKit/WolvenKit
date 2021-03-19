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
			get => GetProperty(ref _stateText);
			set => SetProperty(ref _stateText, value);
		}

		[Ordinal(3)] 
		[RED("button1Controller")] 
		public wCHandle<inkButtonController> Button1Controller
		{
			get => GetProperty(ref _button1Controller);
			set => SetProperty(ref _button1Controller, value);
		}

		[Ordinal(4)] 
		[RED("button2Controller")] 
		public wCHandle<inkButtonController> Button2Controller
		{
			get => GetProperty(ref _button2Controller);
			set => SetProperty(ref _button2Controller, value);
		}

		public sampleStylesGameController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
