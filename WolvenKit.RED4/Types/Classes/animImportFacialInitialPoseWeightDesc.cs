using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class animImportFacialInitialPoseWeightDesc : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("poseNames")] 
		public CArray<CName> PoseNames
		{
			get => GetPropertyValue<CArray<CName>>();
			set => SetPropertyValue<CArray<CName>>(value);
		}

		[Ordinal(1)] 
		[RED("weights")] 
		public CArray<CFloat> Weights
		{
			get => GetPropertyValue<CArray<CFloat>>();
			set => SetPropertyValue<CArray<CFloat>>(value);
		}

		public animImportFacialInitialPoseWeightDesc()
		{
			PoseNames = new();
			Weights = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
