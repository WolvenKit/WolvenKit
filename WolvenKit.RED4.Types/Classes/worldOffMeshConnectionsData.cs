using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class worldOffMeshConnectionsData : RedBaseClass
	{
		private CArray<CFloat> _verts;
		private CArray<CFloat> _radii;
		private CArray<CUInt16> _flags;
		private CArray<CUInt8> _areas;
		private CArray<CUInt8> _directions;
		private CArray<CUInt64> _ids;
		private CArray<CUInt16> _tagIntervals;
		private CArray<CName> _tagsX;
		private CArray<worldGlobalNodeID> _globalNodeIDs;
		private CArray<CHandle<worldOffMeshUserData>> _userData;

		[Ordinal(0)] 
		[RED("verts")] 
		public CArray<CFloat> Verts
		{
			get => GetProperty(ref _verts);
			set => SetProperty(ref _verts, value);
		}

		[Ordinal(1)] 
		[RED("radii")] 
		public CArray<CFloat> Radii
		{
			get => GetProperty(ref _radii);
			set => SetProperty(ref _radii, value);
		}

		[Ordinal(2)] 
		[RED("flags")] 
		public CArray<CUInt16> Flags
		{
			get => GetProperty(ref _flags);
			set => SetProperty(ref _flags, value);
		}

		[Ordinal(3)] 
		[RED("areas")] 
		public CArray<CUInt8> Areas
		{
			get => GetProperty(ref _areas);
			set => SetProperty(ref _areas, value);
		}

		[Ordinal(4)] 
		[RED("directions")] 
		public CArray<CUInt8> Directions
		{
			get => GetProperty(ref _directions);
			set => SetProperty(ref _directions, value);
		}

		[Ordinal(5)] 
		[RED("ids")] 
		public CArray<CUInt64> Ids
		{
			get => GetProperty(ref _ids);
			set => SetProperty(ref _ids, value);
		}

		[Ordinal(6)] 
		[RED("tagIntervals")] 
		public CArray<CUInt16> TagIntervals
		{
			get => GetProperty(ref _tagIntervals);
			set => SetProperty(ref _tagIntervals, value);
		}

		[Ordinal(7)] 
		[RED("tagsX")] 
		public CArray<CName> TagsX
		{
			get => GetProperty(ref _tagsX);
			set => SetProperty(ref _tagsX, value);
		}

		[Ordinal(8)] 
		[RED("globalNodeIDs")] 
		public CArray<worldGlobalNodeID> GlobalNodeIDs
		{
			get => GetProperty(ref _globalNodeIDs);
			set => SetProperty(ref _globalNodeIDs, value);
		}

		[Ordinal(9)] 
		[RED("userData")] 
		public CArray<CHandle<worldOffMeshUserData>> UserData
		{
			get => GetProperty(ref _userData);
			set => SetProperty(ref _userData, value);
		}
	}
}
