using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class sampleUIInteractionWidgetLogicController : inkWidgetLogicController
	{
		private CColor _enableStateColor;
		private CColor _disableStateColor;
		private wCHandle<inkTextWidget> _textWidget;

		[Ordinal(1)] 
		[RED("enableStateColor")] 
		public CColor EnableStateColor
		{
			get => GetProperty(ref _enableStateColor);
			set => SetProperty(ref _enableStateColor, value);
		}

		[Ordinal(2)] 
		[RED("disableStateColor")] 
		public CColor DisableStateColor
		{
			get => GetProperty(ref _disableStateColor);
			set => SetProperty(ref _disableStateColor, value);
		}

		[Ordinal(3)] 
		[RED("textWidget")] 
		public wCHandle<inkTextWidget> TextWidget
		{
			get => GetProperty(ref _textWidget);
			set => SetProperty(ref _textWidget, value);
		}

		public sampleUIInteractionWidgetLogicController(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
