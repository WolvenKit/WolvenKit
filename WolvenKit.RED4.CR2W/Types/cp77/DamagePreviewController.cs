using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class DamagePreviewController : inkWidgetLogicController
	{
		private inkWidgetReference _fullBar;
		private inkWidgetReference _stippedBar;
		private inkWidgetReference _rootCanvas;
		private CFloat _width;
		private CFloat _height;
		private CFloat _heightStripped;
		private CFloat _heightRoot;
		private CHandle<inkanimProxy> _animProxy;

		[Ordinal(1)] 
		[RED("fullBar")] 
		public inkWidgetReference FullBar
		{
			get => GetProperty(ref _fullBar);
			set => SetProperty(ref _fullBar, value);
		}

		[Ordinal(2)] 
		[RED("stippedBar")] 
		public inkWidgetReference StippedBar
		{
			get => GetProperty(ref _stippedBar);
			set => SetProperty(ref _stippedBar, value);
		}

		[Ordinal(3)] 
		[RED("rootCanvas")] 
		public inkWidgetReference RootCanvas
		{
			get => GetProperty(ref _rootCanvas);
			set => SetProperty(ref _rootCanvas, value);
		}

		[Ordinal(4)] 
		[RED("width")] 
		public CFloat Width
		{
			get => GetProperty(ref _width);
			set => SetProperty(ref _width, value);
		}

		[Ordinal(5)] 
		[RED("height")] 
		public CFloat Height
		{
			get => GetProperty(ref _height);
			set => SetProperty(ref _height, value);
		}

		[Ordinal(6)] 
		[RED("heightStripped")] 
		public CFloat HeightStripped
		{
			get => GetProperty(ref _heightStripped);
			set => SetProperty(ref _heightStripped, value);
		}

		[Ordinal(7)] 
		[RED("heightRoot")] 
		public CFloat HeightRoot
		{
			get => GetProperty(ref _heightRoot);
			set => SetProperty(ref _heightRoot, value);
		}

		[Ordinal(8)] 
		[RED("animProxy")] 
		public CHandle<inkanimProxy> AnimProxy
		{
			get => GetProperty(ref _animProxy);
			set => SetProperty(ref _animProxy, value);
		}

		public DamagePreviewController(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
