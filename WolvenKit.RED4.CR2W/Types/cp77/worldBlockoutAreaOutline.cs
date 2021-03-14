using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class worldBlockoutAreaOutline : ISerializable
	{
		private CArray<CUInt32> _points;
		private CArray<CUInt32> _edges;

		[Ordinal(0)] 
		[RED("points")] 
		public CArray<CUInt32> Points
		{
			get
			{
				if (_points == null)
				{
					_points = (CArray<CUInt32>) CR2WTypeManager.Create("array:Uint32", "points", cr2w, this);
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
		public CArray<CUInt32> Edges
		{
			get
			{
				if (_edges == null)
				{
					_edges = (CArray<CUInt32>) CR2WTypeManager.Create("array:Uint32", "edges", cr2w, this);
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

		public worldBlockoutAreaOutline(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
