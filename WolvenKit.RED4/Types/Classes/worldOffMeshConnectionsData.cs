using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class worldOffMeshConnectionsData : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("verts")] 
		public CArray<CFloat> Verts
		{
			get => GetPropertyValue<CArray<CFloat>>();
			set => SetPropertyValue<CArray<CFloat>>(value);
		}

		[Ordinal(1)] 
		[RED("radii")] 
		public CArray<CFloat> Radii
		{
			get => GetPropertyValue<CArray<CFloat>>();
			set => SetPropertyValue<CArray<CFloat>>(value);
		}

		[Ordinal(2)] 
		[RED("flags")] 
		public CArray<CUInt16> Flags
		{
			get => GetPropertyValue<CArray<CUInt16>>();
			set => SetPropertyValue<CArray<CUInt16>>(value);
		}

		[Ordinal(3)] 
		[RED("areas")] 
		public CArray<CUInt8> Areas
		{
			get => GetPropertyValue<CArray<CUInt8>>();
			set => SetPropertyValue<CArray<CUInt8>>(value);
		}

		[Ordinal(4)] 
		[RED("directions")] 
		public CArray<CUInt8> Directions
		{
			get => GetPropertyValue<CArray<CUInt8>>();
			set => SetPropertyValue<CArray<CUInt8>>(value);
		}

		[Ordinal(5)] 
		[RED("ids")] 
		public CArray<CUInt64> Ids
		{
			get => GetPropertyValue<CArray<CUInt64>>();
			set => SetPropertyValue<CArray<CUInt64>>(value);
		}

		[Ordinal(6)] 
		[RED("tagIntervals")] 
		public CArray<CUInt16> TagIntervals
		{
			get => GetPropertyValue<CArray<CUInt16>>();
			set => SetPropertyValue<CArray<CUInt16>>(value);
		}

		[Ordinal(7)] 
		[RED("tagsX")] 
		public CArray<CName> TagsX
		{
			get => GetPropertyValue<CArray<CName>>();
			set => SetPropertyValue<CArray<CName>>(value);
		}

		[Ordinal(8)] 
		[RED("globalNodeIDs")] 
		public CArray<worldGlobalNodeID> GlobalNodeIDs
		{
			get => GetPropertyValue<CArray<worldGlobalNodeID>>();
			set => SetPropertyValue<CArray<worldGlobalNodeID>>(value);
		}

		[Ordinal(9)] 
		[RED("userData")] 
		public CArray<CHandle<worldOffMeshUserData>> UserData
		{
			get => GetPropertyValue<CArray<CHandle<worldOffMeshUserData>>>();
			set => SetPropertyValue<CArray<CHandle<worldOffMeshUserData>>>(value);
		}

		public worldOffMeshConnectionsData()
		{
			Verts = new();
			Radii = new();
			Flags = new();
			Areas = new();
			Directions = new();
			Ids = new();
			TagIntervals = new();
			TagsX = new();
			GlobalNodeIDs = new();
			UserData = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
