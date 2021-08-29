using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class PlayLibraryAnimationButtonView : BaseButtonView
	{
		private CName _toHoverAnimationName;
		private CName _toPressedAnimationName;
		private CName _toDefaultAnimationName;
		private CName _toDisabledAnimationName;
		private CHandle<inkanimProxy> _inputAnimation;

		[Ordinal(2)] 
		[RED("ToHoverAnimationName")] 
		public CName ToHoverAnimationName
		{
			get => GetProperty(ref _toHoverAnimationName);
			set => SetProperty(ref _toHoverAnimationName, value);
		}

		[Ordinal(3)] 
		[RED("ToPressedAnimationName")] 
		public CName ToPressedAnimationName
		{
			get => GetProperty(ref _toPressedAnimationName);
			set => SetProperty(ref _toPressedAnimationName, value);
		}

		[Ordinal(4)] 
		[RED("ToDefaultAnimationName")] 
		public CName ToDefaultAnimationName
		{
			get => GetProperty(ref _toDefaultAnimationName);
			set => SetProperty(ref _toDefaultAnimationName, value);
		}

		[Ordinal(5)] 
		[RED("ToDisabledAnimationName")] 
		public CName ToDisabledAnimationName
		{
			get => GetProperty(ref _toDisabledAnimationName);
			set => SetProperty(ref _toDisabledAnimationName, value);
		}

		[Ordinal(6)] 
		[RED("InputAnimation")] 
		public CHandle<inkanimProxy> InputAnimation
		{
			get => GetProperty(ref _inputAnimation);
			set => SetProperty(ref _inputAnimation, value);
		}
	}
}
