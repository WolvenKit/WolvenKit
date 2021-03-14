using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class worldOffMeshConnectionsData : CVariable
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
			get
			{
				if (_verts == null)
				{
					_verts = (CArray<CFloat>) CR2WTypeManager.Create("array:Float", "verts", cr2w, this);
				}
				return _verts;
			}
			set
			{
				if (_verts == value)
				{
					return;
				}
				_verts = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("radii")] 
		public CArray<CFloat> Radii
		{
			get
			{
				if (_radii == null)
				{
					_radii = (CArray<CFloat>) CR2WTypeManager.Create("array:Float", "radii", cr2w, this);
				}
				return _radii;
			}
			set
			{
				if (_radii == value)
				{
					return;
				}
				_radii = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("flags")] 
		public CArray<CUInt16> Flags
		{
			get
			{
				if (_flags == null)
				{
					_flags = (CArray<CUInt16>) CR2WTypeManager.Create("array:Uint16", "flags", cr2w, this);
				}
				return _flags;
			}
			set
			{
				if (_flags == value)
				{
					return;
				}
				_flags = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("areas")] 
		public CArray<CUInt8> Areas
		{
			get
			{
				if (_areas == null)
				{
					_areas = (CArray<CUInt8>) CR2WTypeManager.Create("array:Uint8", "areas", cr2w, this);
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

		[Ordinal(4)] 
		[RED("directions")] 
		public CArray<CUInt8> Directions
		{
			get
			{
				if (_directions == null)
				{
					_directions = (CArray<CUInt8>) CR2WTypeManager.Create("array:Uint8", "directions", cr2w, this);
				}
				return _directions;
			}
			set
			{
				if (_directions == value)
				{
					return;
				}
				_directions = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("ids")] 
		public CArray<CUInt64> Ids
		{
			get
			{
				if (_ids == null)
				{
					_ids = (CArray<CUInt64>) CR2WTypeManager.Create("array:Uint64", "ids", cr2w, this);
				}
				return _ids;
			}
			set
			{
				if (_ids == value)
				{
					return;
				}
				_ids = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("tagIntervals")] 
		public CArray<CUInt16> TagIntervals
		{
			get
			{
				if (_tagIntervals == null)
				{
					_tagIntervals = (CArray<CUInt16>) CR2WTypeManager.Create("array:Uint16", "tagIntervals", cr2w, this);
				}
				return _tagIntervals;
			}
			set
			{
				if (_tagIntervals == value)
				{
					return;
				}
				_tagIntervals = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("tagsX")] 
		public CArray<CName> TagsX
		{
			get
			{
				if (_tagsX == null)
				{
					_tagsX = (CArray<CName>) CR2WTypeManager.Create("array:CName", "tagsX", cr2w, this);
				}
				return _tagsX;
			}
			set
			{
				if (_tagsX == value)
				{
					return;
				}
				_tagsX = value;
				PropertySet(this);
			}
		}

		[Ordinal(8)] 
		[RED("globalNodeIDs")] 
		public CArray<worldGlobalNodeID> GlobalNodeIDs
		{
			get
			{
				if (_globalNodeIDs == null)
				{
					_globalNodeIDs = (CArray<worldGlobalNodeID>) CR2WTypeManager.Create("array:worldGlobalNodeID", "globalNodeIDs", cr2w, this);
				}
				return _globalNodeIDs;
			}
			set
			{
				if (_globalNodeIDs == value)
				{
					return;
				}
				_globalNodeIDs = value;
				PropertySet(this);
			}
		}

		[Ordinal(9)] 
		[RED("userData")] 
		public CArray<CHandle<worldOffMeshUserData>> UserData
		{
			get
			{
				if (_userData == null)
				{
					_userData = (CArray<CHandle<worldOffMeshUserData>>) CR2WTypeManager.Create("array:handle:worldOffMeshUserData", "userData", cr2w, this);
				}
				return _userData;
			}
			set
			{
				if (_userData == value)
				{
					return;
				}
				_userData = value;
				PropertySet(this);
			}
		}

		public worldOffMeshConnectionsData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
