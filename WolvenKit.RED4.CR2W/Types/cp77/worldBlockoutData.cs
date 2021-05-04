using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class worldBlockoutData : ISerializable
	{
		private CArray<worldBlockoutPoint> _points;
		private CArray<worldBlockoutEdge> _edges;
		private CArray<worldBlockoutArea> _areas;
		private Vector2 _worldSize;
		private CArray<CUInt32> _freePoints;
		private CArray<CUInt32> _freeEdges;
		private CArray<CUInt32> _freeAreas;

		[Ordinal(0)] 
		[RED("points")] 
		public CArray<worldBlockoutPoint> Points
		{
			get => GetProperty(ref _points);
			set => SetProperty(ref _points, value);
		}

		[Ordinal(1)] 
		[RED("edges")] 
		public CArray<worldBlockoutEdge> Edges
		{
			get => GetProperty(ref _edges);
			set => SetProperty(ref _edges, value);
		}

		[Ordinal(2)] 
		[RED("areas")] 
		public CArray<worldBlockoutArea> Areas
		{
			get => GetProperty(ref _areas);
			set => SetProperty(ref _areas, value);
		}

		[Ordinal(3)] 
		[RED("worldSize")] 
		public Vector2 WorldSize
		{
			get => GetProperty(ref _worldSize);
			set => SetProperty(ref _worldSize, value);
		}

		[Ordinal(4)] 
		[RED("freePoints")] 
		public CArray<CUInt32> FreePoints
		{
			get => GetProperty(ref _freePoints);
			set => SetProperty(ref _freePoints, value);
		}

		[Ordinal(5)] 
		[RED("freeEdges")] 
		public CArray<CUInt32> FreeEdges
		{
			get => GetProperty(ref _freeEdges);
			set => SetProperty(ref _freeEdges, value);
		}

		[Ordinal(6)] 
		[RED("freeAreas")] 
		public CArray<CUInt32> FreeAreas
		{
			get => GetProperty(ref _freeAreas);
			set => SetProperty(ref _freeAreas, value);
		}

		public worldBlockoutData(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
