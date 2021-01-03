using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class LookAtPresetBaseEvents : DefaultTransition
	{
		[Ordinal(0)]  [RED("attachLeft")] public CBool AttachLeft { get; set; }
		[Ordinal(1)]  [RED("attachRight")] public CBool AttachRight { get; set; }
		[Ordinal(2)]  [RED("lookAtEvents")] public CArray<CHandle<entLookAtAddEvent>> LookAtEvents { get; set; }

		public LookAtPresetBaseEvents(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
