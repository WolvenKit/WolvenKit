using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class inkWidgetBackendData : IBackendData
	{
		[Ordinal(0)]  [RED("boundLibraryItemName")] public CName BoundLibraryItemName { get; set; }
		[Ordinal(1)]  [RED("isHiddenInEditor")] public CBool IsHiddenInEditor { get; set; }
		[Ordinal(2)]  [RED("isLocked")] public CBool IsLocked { get; set; }
		[Ordinal(3)]  [RED("owner")] public wCHandle<inkWidget> Owner { get; set; }

		public inkWidgetBackendData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
