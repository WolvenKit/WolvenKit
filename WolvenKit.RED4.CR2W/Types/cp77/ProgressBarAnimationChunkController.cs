using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ProgressBarAnimationChunkController : inkWidgetLogicController
	{
		private inkWidgetReference _rootCanvas;
		private inkWidgetReference _barCanvas;
		private CHandle<inkanimProxy> _hitAnim;
		private CFloat _fullbarSize;
		private CBool _isNegative;

		[Ordinal(1)] 
		[RED("rootCanvas")] 
		public inkWidgetReference RootCanvas
		{
			get => GetProperty(ref _rootCanvas);
			set => SetProperty(ref _rootCanvas, value);
		}

		[Ordinal(2)] 
		[RED("barCanvas")] 
		public inkWidgetReference BarCanvas
		{
			get => GetProperty(ref _barCanvas);
			set => SetProperty(ref _barCanvas, value);
		}

		[Ordinal(3)] 
		[RED("hitAnim")] 
		public CHandle<inkanimProxy> HitAnim
		{
			get => GetProperty(ref _hitAnim);
			set => SetProperty(ref _hitAnim, value);
		}

		[Ordinal(4)] 
		[RED("fullbarSize")] 
		public CFloat FullbarSize
		{
			get => GetProperty(ref _fullbarSize);
			set => SetProperty(ref _fullbarSize, value);
		}

		[Ordinal(5)] 
		[RED("isNegative")] 
		public CBool IsNegative
		{
			get => GetProperty(ref _isNegative);
			set => SetProperty(ref _isNegative, value);
		}

		public ProgressBarAnimationChunkController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
