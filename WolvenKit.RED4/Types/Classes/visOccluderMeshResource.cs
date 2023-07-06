using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class visOccluderMeshResource : visIOccluderResource
	{
		[Ordinal(1)] 
		[RED("resourceVersion")] 
		public CUInt32 ResourceVersion
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		[Ordinal(2)] 
		[RED("vertices")] 
		public DataBuffer Vertices
		{
			get => GetPropertyValue<DataBuffer>();
			set => SetPropertyValue<DataBuffer>(value);
		}

		[Ordinal(3)] 
		[RED("indices")] 
		public DataBuffer Indices
		{
			get => GetPropertyValue<DataBuffer>();
			set => SetPropertyValue<DataBuffer>(value);
		}

		[Ordinal(4)] 
		[RED("boundingBox")] 
		public Box BoundingBox
		{
			get => GetPropertyValue<Box>();
			set => SetPropertyValue<Box>(value);
		}

		[Ordinal(5)] 
		[RED("twoSided")] 
		public CBool TwoSided
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public visOccluderMeshResource()
		{
			BoundingBox = new Box { Min = new Vector4(), Max = new Vector4() };

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
