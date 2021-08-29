using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class ModifyDamageWithDistance : ModifyDamageEffector
	{
		private CBool _increaseWithDistance;
		private CFloat _percentMult;
		private CFloat _unitThreshold;

		[Ordinal(2)] 
		[RED("increaseWithDistance")] 
		public CBool IncreaseWithDistance
		{
			get => GetProperty(ref _increaseWithDistance);
			set => SetProperty(ref _increaseWithDistance, value);
		}

		[Ordinal(3)] 
		[RED("percentMult")] 
		public CFloat PercentMult
		{
			get => GetProperty(ref _percentMult);
			set => SetProperty(ref _percentMult, value);
		}

		[Ordinal(4)] 
		[RED("unitThreshold")] 
		public CFloat UnitThreshold
		{
			get => GetProperty(ref _unitThreshold);
			set => SetProperty(ref _unitThreshold, value);
		}
	}
}
