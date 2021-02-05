using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class interopSelectByDefinitionOptions : CVariable
	{
		[Ordinal(0)]  [RED("searchInSelection")] public CBool SearchInSelection { get; set; }
		[Ordinal(1)]  [RED("minBBoxDiagonalLength")] public CFloat MinBBoxDiagonalLength { get; set; }
		[Ordinal(2)]  [RED("maxBBoxDiagonalLength")] public CFloat MaxBBoxDiagonalLength { get; set; }
		[Ordinal(3)]  [RED("maxBBoxParentPercantageDiagonalLength")] public CFloat MaxBBoxParentPercantageDiagonalLength { get; set; }
		[Ordinal(4)]  [RED("includePrefabNodes")] public CBool IncludePrefabNodes { get; set; }
		[Ordinal(5)]  [RED("includeDecalNodes")] public CBool IncludeDecalNodes { get; set; }
		[Ordinal(6)]  [RED("includeMeshNodes")] public CBool IncludeMeshNodes { get; set; }

		public interopSelectByDefinitionOptions(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
