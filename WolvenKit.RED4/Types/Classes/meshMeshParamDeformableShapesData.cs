using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class meshMeshParamDeformableShapesData : meshMeshParameter
	{
		[Ordinal(0)] 
		[RED("ownerIndex")] 
		public CArray<CUInt8> OwnerIndex
		{
			get => GetPropertyValue<CArray<CUInt8>>();
			set => SetPropertyValue<CArray<CUInt8>>(value);
		}

		[Ordinal(1)] 
		[RED("startingPose")] 
		public CArray<Transform> StartingPose
		{
			get => GetPropertyValue<CArray<Transform>>();
			set => SetPropertyValue<CArray<Transform>>(value);
		}

		[Ordinal(2)] 
		[RED("finalPose")] 
		public CArray<Transform> FinalPose
		{
			get => GetPropertyValue<CArray<Transform>>();
			set => SetPropertyValue<CArray<Transform>>(value);
		}

		public meshMeshParamDeformableShapesData()
		{
			OwnerIndex = new();
			StartingPose = new();
			FinalPose = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
