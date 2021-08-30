using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameQuestDistanceRequestFilter : gameCustomRequestFilter
	{
		private CFloat _distanceSquared;

		[Ordinal(0)] 
		[RED("distanceSquared")] 
		public CFloat DistanceSquared
		{
			get => GetProperty(ref _distanceSquared);
			set => SetProperty(ref _distanceSquared, value);
		}

		public gameQuestDistanceRequestFilter()
		{
			_distanceSquared = 1000000.000000F;
		}
	}
}
