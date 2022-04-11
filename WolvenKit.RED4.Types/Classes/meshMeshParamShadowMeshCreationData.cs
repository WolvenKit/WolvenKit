using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class meshMeshParamShadowMeshCreationData : meshMeshParameter
	{
		[Ordinal(0)] 
		[RED("geometries")] 
		public CArray<CHandle<physicsICollider>> Geometries
		{
			get => GetPropertyValue<CArray<CHandle<physicsICollider>>>();
			set => SetPropertyValue<CArray<CHandle<physicsICollider>>>(value);
		}

		[Ordinal(1)] 
		[RED("bonesPerGeometry")] 
		public CArray<CInt32> BonesPerGeometry
		{
			get => GetPropertyValue<CArray<CInt32>>();
			set => SetPropertyValue<CArray<CInt32>>(value);
		}

		public meshMeshParamShadowMeshCreationData()
		{
			Geometries = new();
			BonesPerGeometry = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
