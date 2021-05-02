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
			get => GetProperty(ref _points);
			set => SetProperty(ref _points, value);
		}

		[Ordinal(1)] 
		[RED("edges")] 
		public CArray<CUInt32> Edges
		{
			get => GetProperty(ref _edges);
			set => SetProperty(ref _edges, value);
		}

		public worldBlockoutAreaOutline(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
