using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class animLookAtAdditionalPreset_FullControl : animLookAtAdditionalPreset
	{
		[Ordinal(0)]  [RED("attachHandToOtherOne")] public CBool AttachHandToOtherOne { get; set; }
		[Ordinal(1)]  [RED("limits")] public animLookAtLimits Limits { get; set; }
		[Ordinal(2)]  [RED("mode")] public CInt32 Mode { get; set; }
		[Ordinal(3)]  [RED("suppress")] public CFloat Suppress { get; set; }
		[Ordinal(4)]  [RED("useRightHand")] public CBool UseRightHand { get; set; }

		public animLookAtAdditionalPreset_FullControl(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
