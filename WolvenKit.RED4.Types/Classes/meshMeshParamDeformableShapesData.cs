using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class meshMeshParamDeformableShapesData : meshMeshParameter
	{
		private CArray<CUInt8> _ownerIndex;
		private CArray<Transform> _startingPose;
		private CArray<Transform> _finalPose;

		[Ordinal(0)] 
		[RED("ownerIndex")] 
		public CArray<CUInt8> OwnerIndex
		{
			get => GetProperty(ref _ownerIndex);
			set => SetProperty(ref _ownerIndex, value);
		}

		[Ordinal(1)] 
		[RED("startingPose")] 
		public CArray<Transform> StartingPose
		{
			get => GetProperty(ref _startingPose);
			set => SetProperty(ref _startingPose, value);
		}

		[Ordinal(2)] 
		[RED("finalPose")] 
		public CArray<Transform> FinalPose
		{
			get => GetProperty(ref _finalPose);
			set => SetProperty(ref _finalPose, value);
		}
	}
}
