using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameEffectObjectFilter_DistanceFromRoot : gameEffectObjectGroupFilter
	{
		private CFloat _rootZOffset;
		private CFloat _bonusRange;

		[Ordinal(0)] 
		[RED("rootZOffset")] 
		public CFloat RootZOffset
		{
			get => GetProperty(ref _rootZOffset);
			set => SetProperty(ref _rootZOffset, value);
		}

		[Ordinal(1)] 
		[RED("bonusRange")] 
		public CFloat BonusRange
		{
			get => GetProperty(ref _bonusRange);
			set => SetProperty(ref _bonusRange, value);
		}

		public gameEffectObjectFilter_DistanceFromRoot()
		{
			_rootZOffset = 1.000000F;
			_bonusRange = 0.500000F;
		}
	}
}
