using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class meshMeshParamCloth : meshMeshParameter
	{
		private CArray<CArray<CUInt16>> _lodChunkIndices;
		private CArray<meshPhxClothChunkData> _chunks;
		private CArray<CArray<CUInt16>> _drivers;
		private CHandle<physicsclothClothCapsuleExportData> _capsules;

		[Ordinal(0)] 
		[RED("lodChunkIndices")] 
		public CArray<CArray<CUInt16>> LodChunkIndices
		{
			get
			{
				if (_lodChunkIndices == null)
				{
					_lodChunkIndices = (CArray<CArray<CUInt16>>) CR2WTypeManager.Create("array:array:Uint16", "lodChunkIndices", cr2w, this);
				}
				return _lodChunkIndices;
			}
			set
			{
				if (_lodChunkIndices == value)
				{
					return;
				}
				_lodChunkIndices = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("chunks")] 
		public CArray<meshPhxClothChunkData> Chunks
		{
			get
			{
				if (_chunks == null)
				{
					_chunks = (CArray<meshPhxClothChunkData>) CR2WTypeManager.Create("array:meshPhxClothChunkData", "chunks", cr2w, this);
				}
				return _chunks;
			}
			set
			{
				if (_chunks == value)
				{
					return;
				}
				_chunks = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("drivers")] 
		public CArray<CArray<CUInt16>> Drivers
		{
			get
			{
				if (_drivers == null)
				{
					_drivers = (CArray<CArray<CUInt16>>) CR2WTypeManager.Create("array:array:Uint16", "drivers", cr2w, this);
				}
				return _drivers;
			}
			set
			{
				if (_drivers == value)
				{
					return;
				}
				_drivers = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("capsules")] 
		public CHandle<physicsclothClothCapsuleExportData> Capsules
		{
			get
			{
				if (_capsules == null)
				{
					_capsules = (CHandle<physicsclothClothCapsuleExportData>) CR2WTypeManager.Create("handle:physicsclothClothCapsuleExportData", "capsules", cr2w, this);
				}
				return _capsules;
			}
			set
			{
				if (_capsules == value)
				{
					return;
				}
				_capsules = value;
				PropertySet(this);
			}
		}

		public meshMeshParamCloth(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
