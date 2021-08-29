using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class physicsclothPhaseConfig : RedBaseClass
	{
		private CFloat _stiffness;
		private CFloat _stiffnessMultiplier;
		private CFloat _compressionLimit;
		private CFloat _stretchLimit;

		[Ordinal(0)] 
		[RED("stiffness")] 
		public CFloat Stiffness
		{
			get => GetProperty(ref _stiffness);
			set => SetProperty(ref _stiffness, value);
		}

		[Ordinal(1)] 
		[RED("stiffnessMultiplier")] 
		public CFloat StiffnessMultiplier
		{
			get => GetProperty(ref _stiffnessMultiplier);
			set => SetProperty(ref _stiffnessMultiplier, value);
		}

		[Ordinal(2)] 
		[RED("compressionLimit")] 
		public CFloat CompressionLimit
		{
			get => GetProperty(ref _compressionLimit);
			set => SetProperty(ref _compressionLimit, value);
		}

		[Ordinal(3)] 
		[RED("stretchLimit")] 
		public CFloat StretchLimit
		{
			get => GetProperty(ref _stretchLimit);
			set => SetProperty(ref _stretchLimit, value);
		}
	}
}
