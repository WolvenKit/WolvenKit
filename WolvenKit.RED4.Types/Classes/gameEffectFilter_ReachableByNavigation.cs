using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameEffectFilter_ReachableByNavigation : gameEffectObjectSingleFilter
	{
		private gameEffectInputParameter_Float _maxPathLength;

		[Ordinal(0)] 
		[RED("maxPathLength")] 
		public gameEffectInputParameter_Float MaxPathLength
		{
			get => GetProperty(ref _maxPathLength);
			set => SetProperty(ref _maxPathLength, value);
		}
	}
}
