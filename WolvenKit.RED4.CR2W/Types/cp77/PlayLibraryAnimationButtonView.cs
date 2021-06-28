using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class PlayLibraryAnimationButtonView : BaseButtonView
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

		public PlayLibraryAnimationButtonView(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
