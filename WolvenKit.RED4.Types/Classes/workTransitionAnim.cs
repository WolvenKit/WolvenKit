using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class workTransitionAnim : RedBaseClass
	{
		private CName _fromIdle;
		private CName _toIdle;
		private CName _transitionAnim;

		[Ordinal(0)] 
		[RED("fromIdle")] 
		public CName FromIdle
		{
			get => GetProperty(ref _fromIdle);
			set => SetProperty(ref _fromIdle, value);
		}

		[Ordinal(1)] 
		[RED("toIdle")] 
		public CName ToIdle
		{
			get => GetProperty(ref _toIdle);
			set => SetProperty(ref _toIdle, value);
		}

		[Ordinal(2)] 
		[RED("transitionAnim")] 
		public CName TransitionAnim
		{
			get => GetProperty(ref _transitionAnim);
			set => SetProperty(ref _transitionAnim, value);
		}
	}
}
