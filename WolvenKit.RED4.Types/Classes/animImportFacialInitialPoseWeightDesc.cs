using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class animImportFacialInitialPoseWeightDesc : RedBaseClass
	{
		private CArray<CName> _poseNames;
		private CArray<CFloat> _weights;

		[Ordinal(0)] 
		[RED("poseNames")] 
		public CArray<CName> PoseNames
		{
			get => GetProperty(ref _poseNames);
			set => SetProperty(ref _poseNames, value);
		}

		[Ordinal(1)] 
		[RED("weights")] 
		public CArray<CFloat> Weights
		{
			get => GetProperty(ref _weights);
			set => SetProperty(ref _weights, value);
		}
	}
}
