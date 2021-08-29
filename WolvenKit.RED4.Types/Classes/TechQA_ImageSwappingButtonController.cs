using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class TechQA_ImageSwappingButtonController : inkWidgetLogicController
	{
		private CName _textWidgetPath;
		private CWeakHandle<inkTextWidget> _textWidget;

		[Ordinal(1)] 
		[RED("textWidgetPath")] 
		public CName TextWidgetPath
		{
			get => GetProperty(ref _textWidgetPath);
			set => SetProperty(ref _textWidgetPath, value);
		}

		[Ordinal(2)] 
		[RED("textWidget")] 
		public CWeakHandle<inkTextWidget> TextWidget
		{
			get => GetProperty(ref _textWidget);
			set => SetProperty(ref _textWidget, value);
		}
	}
}
