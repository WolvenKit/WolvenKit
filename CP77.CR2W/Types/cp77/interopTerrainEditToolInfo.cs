using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class interopTerrainEditToolInfo : CVariable
	{
		[Ordinal(0)]  [RED("creationSlots")] public CArray<interopTerrainEditToolCreationSlotInfo> CreationSlots { get; set; }
		[Ordinal(1)]  [RED("defaultColormap1")] public CString DefaultColormap1 { get; set; }
		[Ordinal(2)]  [RED("defaultColormap2")] public CString DefaultColormap2 { get; set; }
		[Ordinal(3)]  [RED("defaultEmptyHeightmapHeight")] public CInt32 DefaultEmptyHeightmapHeight { get; set; }
		[Ordinal(4)]  [RED("defaultEmptyHeightmapMaskFalloff")] public CFloat DefaultEmptyHeightmapMaskFalloff { get; set; }
		[Ordinal(5)]  [RED("defaultEmptyHeightmapMaskRoundness")] public CFloat DefaultEmptyHeightmapMaskRoundness { get; set; }
		[Ordinal(6)]  [RED("defaultEmptyHeightmapWidth")] public CInt32 DefaultEmptyHeightmapWidth { get; set; }
		[Ordinal(7)]  [RED("defaultEmptyHeightmapZeroMaskMargin")] public CUInt32 DefaultEmptyHeightmapZeroMaskMargin { get; set; }
		[Ordinal(8)]  [RED("defaultHeightmap1")] public CString DefaultHeightmap1 { get; set; }
		[Ordinal(9)]  [RED("defaultHeightmap2")] public CString DefaultHeightmap2 { get; set; }
		[Ordinal(10)]  [RED("defaultHeightmapMode")] public CInt32 DefaultHeightmapMode { get; set; }

		public interopTerrainEditToolInfo(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
