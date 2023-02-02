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
			LocalTransform = new() { Position = new() { X = new(), Y = new(), Z = new() }, Orientation = new() { R = 1.000000F } };
			Scale = new() { X = 1.000000F, Y = 1.000000F, Z = 1.000000F };
			Color = new();
			OccluderAutohideDistanceScale = 255;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
