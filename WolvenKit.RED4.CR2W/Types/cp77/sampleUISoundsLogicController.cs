using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class sampleUISoundsLogicController : inkWidgetLogicController
	{
		private wCHandle<inkTextWidget> _textWidget;

		[Ordinal(1)] 
		[RED("textWidget")] 
		public wCHandle<inkTextWidget> TextWidget
		{
			get => GetProperty(ref _textWidget);
			set => SetProperty(ref _textWidget, value);
		}

		public sampleUISoundsLogicController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
