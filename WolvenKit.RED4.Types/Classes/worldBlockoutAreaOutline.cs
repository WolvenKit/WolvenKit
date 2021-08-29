using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class worldBlockoutAreaOutline : ISerializable
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
	}
}
