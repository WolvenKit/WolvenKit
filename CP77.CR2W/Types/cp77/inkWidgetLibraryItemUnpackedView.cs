using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class inkWidgetLibraryItemUnpackedView : ISerializable
	{
		[Ordinal(0)] [RED("name")] public CName Name { get; set; }
		[Ordinal(1)] [RED("instance")] public CHandle<inkWidgetLibraryItemInstance> Instance { get; set; }

		public inkWidgetLibraryItemUnpackedView(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
