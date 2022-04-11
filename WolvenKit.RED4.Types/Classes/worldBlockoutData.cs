using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class worldBlockoutData : ISerializable
	{
		[Ordinal(0)] 
		[RED("points")] 
		public CArray<worldBlockoutPoint> Points
		{
			get => GetPropertyValue<CArray<worldBlockoutPoint>>();
			set => SetPropertyValue<CArray<worldBlockoutPoint>>(value);
		}

		[Ordinal(1)] 
		[RED("edges")] 
		public CArray<worldBlockoutEdge> Edges
		{
			get => GetPropertyValue<CArray<worldBlockoutEdge>>();
			set => SetPropertyValue<CArray<worldBlockoutEdge>>(value);
		}

		[Ordinal(2)] 
		[RED("areas")] 
		public CArray<worldBlockoutArea> Areas
		{
			get => GetPropertyValue<CArray<worldBlockoutArea>>();
			set => SetPropertyValue<CArray<worldBlockoutArea>>(value);
		}

		[Ordinal(3)] 
		[RED("worldSize")] 
		public Vector2 WorldSize
		{
			get => GetPropertyValue<Vector2>();
			set => SetPropertyValue<Vector2>(value);
		}

		[Ordinal(4)] 
		[RED("freePoints")] 
		public CArray<CUInt32> FreePoints
		{
			get => GetPropertyValue<CArray<CUInt32>>();
			set => SetPropertyValue<CArray<CUInt32>>(value);
		}

		[Ordinal(5)] 
		[RED("freeEdges")] 
		public CArray<CUInt32> FreeEdges
		{
			get => GetPropertyValue<CArray<CUInt32>>();
			set => SetPropertyValue<CArray<CUInt32>>(value);
		}

		[Ordinal(6)] 
		[RED("freeAreas")] 
		public CArray<CUInt32> FreeAreas
		{
			get => GetPropertyValue<CArray<CUInt32>>();
			set => SetPropertyValue<CArray<CUInt32>>(value);
		}

		public worldBlockoutData()
		{
			Points = new() { new(), new(), new(), new() };
			Edges = new() { new(), new(), new(), new() };
			Areas = new() { new() { Name = "area_0", Color = new(), Parent = 4294967295, Children = new(), Outlines = new() { null } } };
			WorldSize = new() { X = 8000.000000F, Y = 8000.000000F };
			FreePoints = new();
			FreeEdges = new();
			FreeAreas = new();
		}
	}
}
