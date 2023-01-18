using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class worldInstancedOccluderNode : worldNode
	{
		[Ordinal(4)] 
		[RED("worldBounds")] 
		public Box WorldBounds
		{
			get => GetPropertyValue<Box>();
			set => SetPropertyValue<Box>(value);
		}

		[Ordinal(5)] 
		[RED("occluderType")] 
		public CEnum<visWorldOccluderType> OccluderType
		{
			get => GetPropertyValue<CEnum<visWorldOccluderType>>();
			set => SetPropertyValue<CEnum<visWorldOccluderType>>(value);
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

		public worldInstancedOccluderNode()
		{
			WorldBounds = new() { Min = new() { X = 340282346638528859811704183484516925440.000000F, Y = 340282346638528859811704183484516925440.000000F, Z = 340282346638528859811704183484516925440.000000F, W = 340282346638528859811704183484516925440.000000F }, Max = new() { X = -340282346638528859811704183484516925440.000000F, Y = -340282346638528859811704183484516925440.000000F, Z = -340282346638528859811704183484516925440.000000F, W = -340282346638528859811704183484516925440.000000F } };
			AutohideDistanceScale = 255;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
