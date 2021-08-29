using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class worldBlockoutEdge : RedBaseClass
	{
		private CArrayFixedSize<CUInt32> _points;
		private CArrayFixedSize<CUInt32> _areas;
		private CBool _isFree;

		[Ordinal(0)] 
		[RED("points", 2)] 
		public CArrayFixedSize<CUInt32> Points
		{
			get => GetProperty(ref _points);
			set => SetProperty(ref _points, value);
		}

		[Ordinal(1)] 
		[RED("areas", 2)] 
		public CArrayFixedSize<CUInt32> Areas
		{
			get => GetProperty(ref _areas);
			set => SetProperty(ref _areas, value);
		}

		[Ordinal(2)] 
		[RED("isFree")] 
		public CBool IsFree
		{
			get => GetProperty(ref _isFree);
			set => SetProperty(ref _isFree, value);
		}
	}
}
