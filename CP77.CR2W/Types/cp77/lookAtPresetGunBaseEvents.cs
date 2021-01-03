using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class lookAtPresetGunBaseEvents : LookAtPresetBaseEvents
	{
		[Ordinal(0)]  [RED("gunState")] public CInt32 GunState { get; set; }
		[Ordinal(1)]  [RED("originalAttachLeft")] public CBool OriginalAttachLeft { get; set; }
		[Ordinal(2)]  [RED("originalAttachRight")] public CBool OriginalAttachRight { get; set; }
		[Ordinal(3)]  [RED("overrideLookAtEvents")] public CArray<CHandle<entLookAtAddEvent>> OverrideLookAtEvents { get; set; }

		public lookAtPresetGunBaseEvents(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
