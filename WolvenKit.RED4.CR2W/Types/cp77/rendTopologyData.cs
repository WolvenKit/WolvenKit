using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class rendTopologyData : CVariable
	{
		[Ordinal(0)] [RED("data")] public CArray<CUInt8> Data { get; set; }
		[Ordinal(1)] [RED("metadata")] public CArray<CUInt8> Metadata { get; set; }
		[Ordinal(2)] [RED("dataStride")] public CUInt32 DataStride { get; set; }
		[Ordinal(3)] [RED("metadataStride")] public CUInt32 MetadataStride { get; set; }

		public rendTopologyData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
