using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class gameTPPRepresentationComponent : entIComponent
	{
		[Ordinal(0)]  [RED("affectedAppearanceSlots")] public CArray<TweakDBID> AffectedAppearanceSlots { get; set; }
		[Ordinal(1)]  [RED("attachedObjectInfo")] public CArray<gameTppRepAttachedObjectInfo> AttachedObjectInfo { get; set; }
		[Ordinal(2)]  [RED("detachedObjectInfo")] public CArray<gameFppRepDetachedObjectInfo> DetachedObjectInfo { get; set; }

		public gameTPPRepresentationComponent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
