using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class meshMeshParamCloth_Graphical : meshMeshParameter
	{
		private CArray<CArray<CUInt16>> _lodChunkIndices;
		private CArray<meshGfxClothChunkData> _chunks;
		private CArray<CArray<CArray<CUInt16>>> _latchers;

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
		public CArray<meshGfxClothChunkData> Chunks
		{
			get
			{
				if (_chunks == null)
				{
					_chunks = (CArray<meshGfxClothChunkData>) CR2WTypeManager.Create("array:meshGfxClothChunkData", "chunks", cr2w, this);
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
		[RED("latchers")] 
		public CArray<CArray<CArray<CUInt16>>> Latchers
		{
			get
			{
				if (_latchers == null)
				{
					_latchers = (CArray<CArray<CArray<CUInt16>>>) CR2WTypeManager.Create("array:array:array:Uint16", "latchers", cr2w, this);
				}
				return _latchers;
			}
			set
			{
				if (_latchers == value)
				{
					return;
				}
				_latchers = value;
				PropertySet(this);
			}
		}

		public meshMeshParamCloth_Graphical(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
