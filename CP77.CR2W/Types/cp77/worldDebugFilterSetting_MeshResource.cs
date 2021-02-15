using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class worldDebugFilterSetting_MeshResource : worldEditorDebugFilterSettings
	{
		[Ordinal(0)] [RED("resourcePaths")] public CArray<CString> ResourcePaths { get; set; }

		public worldDebugFilterSetting_MeshResource(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
