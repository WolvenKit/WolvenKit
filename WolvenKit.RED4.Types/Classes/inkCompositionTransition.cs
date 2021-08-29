using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class inkCompositionTransition : RedBaseClass
	{
		private CName _targetState;
		private CArray<inkCompositionInterpolator> _interpolators;

		[Ordinal(0)] 
		[RED("targetState")] 
		public CName TargetState
		{
			get => GetProperty(ref _targetState);
			set => SetProperty(ref _targetState, value);
		}

		[Ordinal(1)] 
		[RED("interpolators")] 
		public CArray<inkCompositionInterpolator> Interpolators
		{
			get => GetProperty(ref _interpolators);
			set => SetProperty(ref _interpolators, value);
		}
	}
}
