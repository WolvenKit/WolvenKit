using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class ResourceLibraryComponent : gameScriptableComponent
	{
		[Ordinal(0)]  [RED("resources")] public CArray<FxResourceMapData> Resources { get; set; }

		public ResourceLibraryComponent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
