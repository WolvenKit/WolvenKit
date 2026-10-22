using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class entStaticOccluderMeshComponent : entIPlacedComponent
	{
		[Ordinal(5)] 
		[RED("mesh")] 
		public CResourceReference<CMesh> Mesh
		{
			get => GetPropertyValue<CResourceReference<CMesh>>();
			set => SetPropertyValue<CResourceReference<CMesh>>(value);
		}

		[Ordinal(6)] 
		[RED("scale")] 
		public Vector3 Scale
		{
			get => GetPropertyValue<Vector3>();
			set => SetPropertyValue<Vector3>(value);
		}

		[Ordinal(7)] 
		[RED("color")] 
		public CColor Color
		{
			get => GetPropertyValue<CColor>();
			set => SetPropertyValue<CColor>(value);
		}

		[Ordinal(8)] 
		[RED("occluderType")] 
		public CEnum<visWorldOccluderType> OccluderType
		{
			get => GetPropertyValue<CEnum<visWorldOccluderType>>();
			set => SetPropertyValue<CEnum<visWorldOccluderType>>(value);
		}

		[Ordinal(9)] 
		[RED("occluderAutohideDistanceScale")] 
		public CUInt8 OccluderAutohideDistanceScale
		{
			get => GetPropertyValue<CUInt8>();
			set => SetPropertyValue<CUInt8>(value);
		}

		public entStaticOccluderMeshComponent()
		{
			Name = "Component";
			LocalTransform = new WorldTransform();
			Mesh = new CResourceReference<CMesh>(@"engine\meshes\editor\box_occluder.w2mesh");
			Scale = new Vector3 { X = 1.000000F, Y = 1.000000F, Z = 1.000000F };
			Color = new CColor { Red = 96, Green = 96, Blue = 128, Alpha = 64 };
			OccluderAutohideDistanceScale = 255;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
