using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class worldStaticOccluderMeshNode : worldNode
	{
		[Ordinal(4)] 
		[RED("occluderType")] 
		public CEnum<visWorldOccluderType> OccluderType
		{
			get => GetPropertyValue<CEnum<visWorldOccluderType>>();
			set => SetPropertyValue<CEnum<visWorldOccluderType>>(value);
		}

		[Ordinal(5)] 
		[RED("color")] 
		public CColor Color
		{
			get => GetPropertyValue<CColor>();
			set => SetPropertyValue<CColor>(value);
		}

		[Ordinal(6)] 
		[RED("autohideDistanceScale")] 
		public CUInt8 AutohideDistanceScale
		{
			get => GetPropertyValue<CUInt8>();
			set => SetPropertyValue<CUInt8>(value);
		}

		[Ordinal(7)] 
		[RED("mesh")] 
		public CResourceAsyncReference<CMesh> Mesh
		{
			get => GetPropertyValue<CResourceAsyncReference<CMesh>>();
			set => SetPropertyValue<CResourceAsyncReference<CMesh>>(value);
		}

		public worldStaticOccluderMeshNode()
		{
			Color = new CColor();
			AutohideDistanceScale = 255;
			Mesh = new CResourceAsyncReference<CMesh>(@"engine\meshes\editor\box_occluder.w2mesh");

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
