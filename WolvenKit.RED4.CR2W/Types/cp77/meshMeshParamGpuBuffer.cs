using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class meshMeshParamGpuBuffer : meshMeshParameter
	{
		private CUInt32 _stride;
		private DataBuffer _data;

		[Ordinal(0)] 
		[RED("stride")] 
		public CUInt32 Stride
		{
			get
			{
				if (_stride == null)
				{
					_stride = (CUInt32) CR2WTypeManager.Create("Uint32", "stride", cr2w, this);
				}
				return _stride;
			}
			set
			{
				if (_stride == value)
				{
					return;
				}
				_stride = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
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

		public meshMeshParamGpuBuffer(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
