using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class TechQA_ImageSwappingButtonController : inkWidgetLogicController
	{
		private CName _textWidgetPath;
		private wCHandle<inkTextWidget> _textWidget;

		[Ordinal(1)] 
		[RED("textWidgetPath")] 
		public CName TextWidgetPath
		{
			get => GetProperty(ref _textWidgetPath);
			set => SetProperty(ref _textWidgetPath, value);
		}

		[Ordinal(2)] 
		[RED("textWidget")] 
		public wCHandle<inkTextWidget> TextWidget
		{
			get => GetProperty(ref _textWidget);
			set => SetProperty(ref _textWidget, value);
		}

		public TechQA_ImageSwappingButtonController(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
