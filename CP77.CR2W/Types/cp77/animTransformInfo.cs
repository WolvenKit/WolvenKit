using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class animTransformInfo : CVariable
	{
		[Ordinal(0)]  [RED("name")] public CName Name { get; set; }
		[Ordinal(1)]  [RED("parentName")] public CName ParentName { get; set; }
		[Ordinal(2)]  [RED("referenceTransformLs")] public QsTransform ReferenceTransformLs { get; set; }

		public animTransformInfo(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
