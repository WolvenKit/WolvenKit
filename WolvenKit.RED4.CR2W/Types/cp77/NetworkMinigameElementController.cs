using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class NetworkMinigameElementController : inkWidgetLogicController
	{
		private ElementData _data;
		private inkTextWidgetReference _text;
		private CColor _textNormalColor;
		private CColor _textHighlightColor;
		private inkRectangleWidgetReference _bg;
		private inkWidgetReference _colorAccent;
		private CFloat _dimmedOpacity;
		private CFloat _notDimmedOpacity;
		private CInt32 _defaultFontSize;
		private CBool _wasConsumed;
		private wCHandle<inkWidget> _root;

		[Ordinal(1)] 
		[RED("data")] 
		public ElementData Data
		{
			get => GetProperty(ref _data);
			set => SetProperty(ref _data, value);
		}

		[Ordinal(2)] 
		[RED("text")] 
		public inkTextWidgetReference Text
		{
			get => GetProperty(ref _text);
			set => SetProperty(ref _text, value);
		}

		[Ordinal(3)] 
		[RED("textNormalColor")] 
		public CColor TextNormalColor
		{
			get => GetProperty(ref _textNormalColor);
			set => SetProperty(ref _textNormalColor, value);
		}

		[Ordinal(4)] 
		[RED("textHighlightColor")] 
		public CColor TextHighlightColor
		{
			get => GetProperty(ref _textHighlightColor);
			set => SetProperty(ref _textHighlightColor, value);
		}

		[Ordinal(5)] 
		[RED("bg")] 
		public inkRectangleWidgetReference Bg
		{
			get => GetProperty(ref _bg);
			set => SetProperty(ref _bg, value);
		}

		[Ordinal(6)] 
		[RED("colorAccent")] 
		public inkWidgetReference ColorAccent
		{
			get => GetProperty(ref _colorAccent);
			set => SetProperty(ref _colorAccent, value);
		}

		[Ordinal(7)] 
		[RED("dimmedOpacity")] 
		public CFloat DimmedOpacity
		{
			get => GetProperty(ref _dimmedOpacity);
			set => SetProperty(ref _dimmedOpacity, value);
		}

		[Ordinal(8)] 
		[RED("notDimmedOpacity")] 
		public CFloat NotDimmedOpacity
		{
			get => GetProperty(ref _notDimmedOpacity);
			set => SetProperty(ref _notDimmedOpacity, value);
		}

		[Ordinal(9)] 
		[RED("defaultFontSize")] 
		public CInt32 DefaultFontSize
		{
			get => GetProperty(ref _defaultFontSize);
			set => SetProperty(ref _defaultFontSize, value);
		}

		[Ordinal(10)] 
		[RED("wasConsumed")] 
		public CBool WasConsumed
		{
			get => GetProperty(ref _wasConsumed);
			set => SetProperty(ref _wasConsumed, value);
		}

		[Ordinal(11)] 
		[RED("root")] 
		public wCHandle<inkWidget> Root
		{
			get => GetProperty(ref _root);
			set => SetProperty(ref _root, value);
		}

		public NetworkMinigameElementController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
