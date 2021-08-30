using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gamePlayerProximityPrereq : gameIPrereq
	{
		private CFloat _squaredRange;

		[Ordinal(0)] 
		[RED("squaredRange")] 
		public CFloat SquaredRange
		{
			get => GetProperty(ref _squaredRange);
			set => SetProperty(ref _squaredRange, value);
		}

		public gamePlayerProximityPrereq()
		{
			_squaredRange = 1.000000F;
		}
	}
}
