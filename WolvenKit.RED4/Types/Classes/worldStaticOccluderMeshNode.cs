using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class worldStaticOccluderMeshNode : worldNode
	{
		[Ordinal(2)] 
		[RED("occluderType")] 
		public CEnum<visWorldOccluderType> OccluderType
		{
			get => GetPropertyValue<CEnum<visWorldOccluderType>>();
			set => SetPropertyValue<CEnum<visWorldOccluderType>>(value);
		}

		[Ordinal(3)] 
		[RED("color")] 
		public CColor Color
		{
			get => GetPropertyValue<CColor>();
			set => SetPropertyValue<CColor>(value);
		}

		[Ordinal(4)] 
		[RED("autohideDistanceScale")] 
		public CUInt8 AutohideDistanceScale
		{
			get => GetPropertyValue<CUInt8>();
			set => SetPropertyValue<CUInt8>(value);
		}

		[Ordinal(5)] 
		[RED("mesh")] 
		public CResourceAsyncReference<CMesh> Mesh
		{
			get => GetPropertyValue<CResourceAsyncReference<CMesh>>();
			set => SetPropertyValue<CResourceAsyncReference<CMesh>>(value);
		}

		public worldStaticOccluderMeshNode()
		{
			Color = new CColor { Red = 96, Green = 96, Blue = 128, Alpha = 64 };
			AutohideDistanceScale = 255;
			Mesh = new CResourceAsyncReference<CMesh>(@"engine\meshes\editor\box_occluder.w2mesh");

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
