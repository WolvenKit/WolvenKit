using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class lookAtPresetGunBaseEvents : LookAtPresetBaseEvents
	{
		[Ordinal(3)] [RED("overrideLookAtEvents")] public CArray<CHandle<entLookAtAddEvent>> OverrideLookAtEvents { get; set; }
		[Ordinal(4)] [RED("gunState")] public CInt32 GunState { get; set; }
		[Ordinal(5)] [RED("originalAttachLeft")] public CBool OriginalAttachLeft { get; set; }
		[Ordinal(6)] [RED("originalAttachRight")] public CBool OriginalAttachRight { get; set; }

		public lookAtPresetGunBaseEvents(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
