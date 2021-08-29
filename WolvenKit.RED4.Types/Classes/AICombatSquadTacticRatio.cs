using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class AICombatSquadTacticRatio : RedBaseClass
	{
		private CFloat _ratioSum;
		private CFloat _reachSum;
		private CFloat _area;

		[Ordinal(0)] 
		[RED("ratioSum")] 
		public CFloat RatioSum
		{
			get => GetProperty(ref _ratioSum);
			set => SetProperty(ref _ratioSum, value);
		}

		[Ordinal(1)] 
		[RED("reachSum")] 
		public CFloat ReachSum
		{
			get => GetProperty(ref _reachSum);
			set => SetProperty(ref _reachSum, value);
		}

		[Ordinal(2)] 
		[RED("area")] 
		public CFloat Area
		{
			get => GetProperty(ref _area);
			set => SetProperty(ref _area, value);
		}
	}
}
