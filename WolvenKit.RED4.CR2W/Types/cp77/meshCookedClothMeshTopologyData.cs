using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class meshCookedClothMeshTopologyData : CVariable
	{
		private DataBuffer _cookedData;
		private CArray<CUInt32> _gfxIndexToTriangles;
		private CArray<CUInt32> _phxIndexToTriangles;
		private CArray<CUInt32> _gfxBarycentrics;
		private CArray<CUInt32> _phxBarycentrics;
		private CArray<CUInt32> _phxLodSwitchData;
		private CArray<CUInt32> _phxSimulated;
		private CUInt32 _gfxNumIndicesToTriangles;
		private CUInt32 _phxNumIndicesToTriangles;
		private CUInt32 _gfxNumBarycentrics;
		private CUInt32 _phxNumBarycentrics;
		private CUInt32 _phxNumLodSwitchData;
		private CUInt32 _phxNumSimulated;

		[Ordinal(0)] 
		[RED("cookedData")] 
		public DataBuffer CookedData
		{
			get
			{
				if (_cookedData == null)
				{
					_cookedData = (DataBuffer) CR2WTypeManager.Create("DataBuffer", "cookedData", cr2w, this);
				}
				return _cookedData;
			}
			set
			{
				if (_cookedData == value)
				{
					return;
				}
				_cookedData = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("gfxIndexToTriangles")] 
		public CArray<CUInt32> GfxIndexToTriangles
		{
			get
			{
				if (_gfxIndexToTriangles == null)
				{
					_gfxIndexToTriangles = (CArray<CUInt32>) CR2WTypeManager.Create("array:Uint32", "gfxIndexToTriangles", cr2w, this);
				}
				return _gfxIndexToTriangles;
			}
			set
			{
				if (_gfxIndexToTriangles == value)
				{
					return;
				}
				_gfxIndexToTriangles = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("phxIndexToTriangles")] 
		public CArray<CUInt32> PhxIndexToTriangles
		{
			get
			{
				if (_phxIndexToTriangles == null)
				{
					_phxIndexToTriangles = (CArray<CUInt32>) CR2WTypeManager.Create("array:Uint32", "phxIndexToTriangles", cr2w, this);
				}
				return _phxIndexToTriangles;
			}
			set
			{
				if (_phxIndexToTriangles == value)
				{
					return;
				}
				_phxIndexToTriangles = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("gfxBarycentrics")] 
		public CArray<CUInt32> GfxBarycentrics
		{
			get
			{
				if (_gfxBarycentrics == null)
				{
					_gfxBarycentrics = (CArray<CUInt32>) CR2WTypeManager.Create("array:Uint32", "gfxBarycentrics", cr2w, this);
				}
				return _gfxBarycentrics;
			}
			set
			{
				if (_gfxBarycentrics == value)
				{
					return;
				}
				_gfxBarycentrics = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("phxBarycentrics")] 
		public CArray<CUInt32> PhxBarycentrics
		{
			get
			{
				if (_phxBarycentrics == null)
				{
					_phxBarycentrics = (CArray<CUInt32>) CR2WTypeManager.Create("array:Uint32", "phxBarycentrics", cr2w, this);
				}
				return _phxBarycentrics;
			}
			set
			{
				if (_phxBarycentrics == value)
				{
					return;
				}
				_phxBarycentrics = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("phxLodSwitchData")] 
		public CArray<CUInt32> PhxLodSwitchData
		{
			get
			{
				if (_phxLodSwitchData == null)
				{
					_phxLodSwitchData = (CArray<CUInt32>) CR2WTypeManager.Create("array:Uint32", "phxLodSwitchData", cr2w, this);
				}
				return _phxLodSwitchData;
			}
			set
			{
				if (_phxLodSwitchData == value)
				{
					return;
				}
				_phxLodSwitchData = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("phxSimulated")] 
		public CArray<CUInt32> PhxSimulated
		{
			get
			{
				if (_phxSimulated == null)
				{
					_phxSimulated = (CArray<CUInt32>) CR2WTypeManager.Create("array:Uint32", "phxSimulated", cr2w, this);
				}
				return _phxSimulated;
			}
			set
			{
				if (_phxSimulated == value)
				{
					return;
				}
				_phxSimulated = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("gfxNumIndicesToTriangles")] 
		public CUInt32 GfxNumIndicesToTriangles
		{
			get
			{
				if (_gfxNumIndicesToTriangles == null)
				{
					_gfxNumIndicesToTriangles = (CUInt32) CR2WTypeManager.Create("Uint32", "gfxNumIndicesToTriangles", cr2w, this);
				}
				return _gfxNumIndicesToTriangles;
			}
			set
			{
				if (_gfxNumIndicesToTriangles == value)
				{
					return;
				}
				_gfxNumIndicesToTriangles = value;
				PropertySet(this);
			}
		}

		[Ordinal(8)] 
		[RED("phxNumIndicesToTriangles")] 
		public CUInt32 PhxNumIndicesToTriangles
		{
			get
			{
				if (_phxNumIndicesToTriangles == null)
				{
					_phxNumIndicesToTriangles = (CUInt32) CR2WTypeManager.Create("Uint32", "phxNumIndicesToTriangles", cr2w, this);
				}
				return _phxNumIndicesToTriangles;
			}
			set
			{
				if (_phxNumIndicesToTriangles == value)
				{
					return;
				}
				_phxNumIndicesToTriangles = value;
				PropertySet(this);
			}
		}

		[Ordinal(9)] 
		[RED("gfxNumBarycentrics")] 
		public CUInt32 GfxNumBarycentrics
		{
			get
			{
				if (_gfxNumBarycentrics == null)
				{
					_gfxNumBarycentrics = (CUInt32) CR2WTypeManager.Create("Uint32", "gfxNumBarycentrics", cr2w, this);
				}
				return _gfxNumBarycentrics;
			}
			set
			{
				if (_gfxNumBarycentrics == value)
				{
					return;
				}
				_gfxNumBarycentrics = value;
				PropertySet(this);
			}
		}

		[Ordinal(10)] 
		[RED("phxNumBarycentrics")] 
		public CUInt32 PhxNumBarycentrics
		{
			get
			{
				if (_phxNumBarycentrics == null)
				{
					_phxNumBarycentrics = (CUInt32) CR2WTypeManager.Create("Uint32", "phxNumBarycentrics", cr2w, this);
				}
				return _phxNumBarycentrics;
			}
			set
			{
				if (_phxNumBarycentrics == value)
				{
					return;
				}
				_phxNumBarycentrics = value;
				PropertySet(this);
			}
		}

		[Ordinal(11)] 
		[RED("phxNumLodSwitchData")] 
		public CUInt32 PhxNumLodSwitchData
		{
			get
			{
				if (_phxNumLodSwitchData == null)
				{
					_phxNumLodSwitchData = (CUInt32) CR2WTypeManager.Create("Uint32", "phxNumLodSwitchData", cr2w, this);
				}
				return _phxNumLodSwitchData;
			}
			set
			{
				if (_phxNumLodSwitchData == value)
				{
					return;
				}
				_phxNumLodSwitchData = value;
				PropertySet(this);
			}
		}

		[Ordinal(12)] 
		[RED("phxNumSimulated")] 
		public CUInt32 PhxNumSimulated
		{
			get
			{
				if (_phxNumSimulated == null)
				{
					_phxNumSimulated = (CUInt32) CR2WTypeManager.Create("Uint32", "phxNumSimulated", cr2w, this);
				}
				return _phxNumSimulated;
			}
			set
			{
				if (_phxNumSimulated == value)
				{
					return;
				}
				_phxNumSimulated = value;
				PropertySet(this);
			}
		}

		public meshCookedClothMeshTopologyData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
