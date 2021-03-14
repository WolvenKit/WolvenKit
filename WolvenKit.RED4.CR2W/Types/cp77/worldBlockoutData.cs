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
			get
			{
				if (_points == null)
				{
					_points = (CArray<worldBlockoutPoint>) CR2WTypeManager.Create("array:worldBlockoutPoint", "points", cr2w, this);
				}
				return _points;
			}
			set
			{
				if (_points == value)
				{
					return;
				}
				_points = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("edges")] 
		public CArray<worldBlockoutEdge> Edges
		{
			get
			{
				if (_edges == null)
				{
					_edges = (CArray<worldBlockoutEdge>) CR2WTypeManager.Create("array:worldBlockoutEdge", "edges", cr2w, this);
				}
				return _edges;
			}
			set
			{
				if (_edges == value)
				{
					return;
				}
				_edges = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("areas")] 
		public CArray<worldBlockoutArea> Areas
		{
			get
			{
				if (_areas == null)
				{
					_areas = (CArray<worldBlockoutArea>) CR2WTypeManager.Create("array:worldBlockoutArea", "areas", cr2w, this);
				}
				return _areas;
			}
			set
			{
				if (_areas == value)
				{
					return;
				}
				_areas = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("worldSize")] 
		public Vector2 WorldSize
		{
			get
			{
				if (_worldSize == null)
				{
					_worldSize = (Vector2) CR2WTypeManager.Create("Vector2", "worldSize", cr2w, this);
				}
				return _worldSize;
			}
			set
			{
				if (_worldSize == value)
				{
					return;
				}
				_worldSize = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("freePoints")] 
		public CArray<CUInt32> FreePoints
		{
			get
			{
				if (_freePoints == null)
				{
					_freePoints = (CArray<CUInt32>) CR2WTypeManager.Create("array:Uint32", "freePoints", cr2w, this);
				}
				return _freePoints;
			}
			set
			{
				if (_freePoints == value)
				{
					return;
				}
				_freePoints = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("freeEdges")] 
		public CArray<CUInt32> FreeEdges
		{
			get
			{
				if (_freeEdges == null)
				{
					_freeEdges = (CArray<CUInt32>) CR2WTypeManager.Create("array:Uint32", "freeEdges", cr2w, this);
				}
				return _freeEdges;
			}
			set
			{
				if (_freeEdges == value)
				{
					return;
				}
				_freeEdges = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("freeAreas")] 
		public CArray<CUInt32> FreeAreas
		{
			get
			{
				if (_freeAreas == null)
				{
					_freeAreas = (CArray<CUInt32>) CR2WTypeManager.Create("array:Uint32", "freeAreas", cr2w, this);
				}
				return _freeAreas;
			}
			set
			{
				if (_freeAreas == value)
				{
					return;
				}
				_freeAreas = value;
				PropertySet(this);
			}
		}

		public worldBlockoutData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
