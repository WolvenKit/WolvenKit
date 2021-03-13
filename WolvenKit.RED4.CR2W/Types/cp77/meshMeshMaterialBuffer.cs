using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class meshMeshMaterialBuffer : CVariable
	{
		[Ordinal(0)] [RED("rawData")] public DataBuffer RawData { get; set; }
		[Ordinal(1)] [RED("rawDataHeaders")] public CArray<meshLocalMaterialHeader> RawDataHeaders { get; set; }

		public meshMeshMaterialBuffer(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
