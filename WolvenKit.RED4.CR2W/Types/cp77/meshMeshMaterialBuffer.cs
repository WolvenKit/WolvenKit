using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class meshMeshMaterialBuffer : CVariable
	{
		private DataBuffer _rawData;
		private CArray<meshLocalMaterialHeader> _rawDataHeaders;

		[Ordinal(0)] 
		[RED("rawData")] 
		public DataBuffer RawData
		{
			get => GetProperty(ref _rawData);
			set => SetProperty(ref _rawData, value);
		}

		[Ordinal(1)] 
		[RED("rawDataHeaders")] 
		public CArray<meshLocalMaterialHeader> RawDataHeaders
		{
			get => GetProperty(ref _rawDataHeaders);
			set => SetProperty(ref _rawDataHeaders, value);
		}

		public meshMeshMaterialBuffer(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
