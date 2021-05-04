using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class LoadingScreenProgressBarController : inkWidgetLogicController
	{
		private inkWidgetReference _progressBarRoot;
		private inkWidgetReference _progressBarFill;
		private inkWidgetReference _progressSpinerRoot;
		private CHandle<inkanimProxy> _rotationAnimationProxy;
		private CHandle<inkanimDefinition> _rotationAnimation;
		private CHandle<inkanimRotationInterpolator> _rotationInterpolator;

		[Ordinal(1)] 
		[RED("progressBarRoot")] 
		public inkWidgetReference ProgressBarRoot
		{
			get => GetProperty(ref _progressBarRoot);
			set => SetProperty(ref _progressBarRoot, value);
		}

		[Ordinal(2)] 
		[RED("progressBarFill")] 
		public inkWidgetReference ProgressBarFill
		{
			get => GetProperty(ref _progressBarFill);
			set => SetProperty(ref _progressBarFill, value);
		}

		[Ordinal(3)] 
		[RED("progressSpinerRoot")] 
		public inkWidgetReference ProgressSpinerRoot
		{
			get => GetProperty(ref _progressSpinerRoot);
			set => SetProperty(ref _progressSpinerRoot, value);
		}

		[Ordinal(4)] 
		[RED("rotationAnimationProxy")] 
		public CHandle<inkanimProxy> RotationAnimationProxy
		{
			get => GetProperty(ref _rotationAnimationProxy);
			set => SetProperty(ref _rotationAnimationProxy, value);
		}

		[Ordinal(5)] 
		[RED("rotationAnimation")] 
		public CHandle<inkanimDefinition> RotationAnimation
		{
			get => GetProperty(ref _rotationAnimation);
			set => SetProperty(ref _rotationAnimation, value);
		}

		[Ordinal(6)] 
		[RED("rotationInterpolator")] 
		public CHandle<inkanimRotationInterpolator> RotationInterpolator
		{
			get => GetProperty(ref _rotationInterpolator);
			set => SetProperty(ref _rotationInterpolator, value);
		}

		public LoadingScreenProgressBarController(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
