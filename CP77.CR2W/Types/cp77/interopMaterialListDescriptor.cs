using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class interopMaterialListDescriptor : CVariable
	{
		[Ordinal(0)] [RED("chunksInfo")] public CString ChunksInfo { get; set; }
		[Ordinal(1)] [RED("chunksLODInfo")] public CString ChunksLODInfo { get; set; }
		[Ordinal(2)] [RED("numLayers")] public CUInt32 NumLayers { get; set; }
		[Ordinal(3)] [RED("isForward")] public CBool IsForward { get; set; }
		[Ordinal(4)] [RED("isMultilayer")] public CBool IsMultilayer { get; set; }
		[Ordinal(5)] [RED("isLocalInstance")] public CBool IsLocalInstance { get; set; }
		[Ordinal(6)] [RED("isTemplate")] public CBool IsTemplate { get; set; }
		[Ordinal(7)] [RED("itemMaterialIndex")] public CUInt32 ItemMaterialIndex { get; set; }
		[Ordinal(8)] [RED("materialName")] public CString MaterialName { get; set; }
		[Ordinal(9)] [RED("appearanceName")] public CString AppearanceName { get; set; }
		[Ordinal(10)] [RED("availableMaterials")] public CArray<CString> AvailableMaterials { get; set; }

		public interopMaterialListDescriptor(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
