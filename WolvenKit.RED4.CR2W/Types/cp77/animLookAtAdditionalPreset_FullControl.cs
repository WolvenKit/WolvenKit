using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animLookAtAdditionalPreset_FullControl : animLookAtAdditionalPreset
	{
		[Ordinal(0)] [RED("useRightHand")] public CBool UseRightHand { get; set; }
		[Ordinal(1)] [RED("attachHandToOtherOne")] public CBool AttachHandToOtherOne { get; set; }
		[Ordinal(2)] [RED("limits")] public animLookAtLimits Limits { get; set; }
		[Ordinal(3)] [RED("suppress")] public CFloat Suppress { get; set; }
		[Ordinal(4)] [RED("mode")] public CInt32 Mode { get; set; }

		public animLookAtAdditionalPreset_FullControl(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
