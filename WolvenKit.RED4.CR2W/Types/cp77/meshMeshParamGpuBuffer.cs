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
			get => GetProperty(ref _stride);
			set => SetProperty(ref _stride, value);
		}

		[Ordinal(1)] 
		[RED("data")] 
		public DataBuffer Data
		{
			get => GetProperty(ref _data);
			set => SetProperty(ref _data, value);
		}

		public meshMeshParamGpuBuffer(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
