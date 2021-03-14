using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class meshMeshParamTopologyData : meshMeshParameter
	{
		private DataBuffer _data;
		private CArray<CUInt32> _offsets;
		private CArray<CUInt32> _sizes;

		[Ordinal(0)] 
		[RED("data")] 
		public DataBuffer Data
		{
			get
			{
				if (_data == null)
				{
					_data = (DataBuffer) CR2WTypeManager.Create("DataBuffer", "data", cr2w, this);
				}
				return _data;
			}
			set
			{
				if (_data == value)
				{
					return;
				}
				_data = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("offsets")] 
		public CArray<CUInt32> Offsets
		{
			get
			{
				if (_offsets == null)
				{
					_offsets = (CArray<CUInt32>) CR2WTypeManager.Create("array:Uint32", "offsets", cr2w, this);
				}
				return _offsets;
			}
			set
			{
				if (_offsets == value)
				{
					return;
				}
				_offsets = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("sizes")] 
		public CArray<CUInt32> Sizes
		{
			get
			{
				if (_sizes == null)
				{
					_sizes = (CArray<CUInt32>) CR2WTypeManager.Create("array:Uint32", "sizes", cr2w, this);
				}
				return _sizes;
			}
			set
			{
				if (_sizes == value)
				{
					return;
				}
				_sizes = value;
				PropertySet(this);
			}
		}

		public meshMeshParamTopologyData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
