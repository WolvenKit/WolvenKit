using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class TargetHitIndicatorLogicController : inkWidgetLogicController
	{
		private CName _animName;
		private CInt32 _animationPriority;

		[Ordinal(1)] 
		[RED("animName")] 
		public CName AnimName
		{
			get => GetProperty(ref _animName);
			set => SetProperty(ref _animName, value);
		}

		[Ordinal(2)] 
		[RED("animationPriority")] 
		public CInt32 AnimationPriority
		{
			get => GetProperty(ref _animationPriority);
			set => SetProperty(ref _animationPriority, value);
		}
	}
}
