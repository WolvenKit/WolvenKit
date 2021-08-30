using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class animAnimNode_ApplyCorrectivePoseRBF : animAnimNode_OnePoseInput
	{
		private CFloat _rbfCoefficient;
		private CFloat _rbfPowValue;
		private CFloat _correctiveFrame;
		private CArray<animCorrectivePoseEntry> _correctives;

		[Ordinal(12)] 
		[RED("rbfCoefficient")] 
		public CFloat RbfCoefficient
		{
			get => GetProperty(ref _rbfCoefficient);
			set => SetProperty(ref _rbfCoefficient, value);
		}

		[Ordinal(13)] 
		[RED("rbfPowValue")] 
		public CFloat RbfPowValue
		{
			get => GetProperty(ref _rbfPowValue);
			set => SetProperty(ref _rbfPowValue, value);
		}

		[Ordinal(14)] 
		[RED("correctiveFrame")] 
		public CFloat CorrectiveFrame
		{
			get => GetProperty(ref _correctiveFrame);
			set => SetProperty(ref _correctiveFrame, value);
		}

		[Ordinal(15)] 
		[RED("correctives")] 
		public CArray<animCorrectivePoseEntry> Correctives
		{
			get => GetProperty(ref _correctives);
			set => SetProperty(ref _correctives, value);
		}

		public animAnimNode_ApplyCorrectivePoseRBF()
		{
			_rbfCoefficient = 3.500000F;
			_rbfPowValue = 20.000000F;
			_correctiveFrame = 0.033330F;
		}
	}
}
