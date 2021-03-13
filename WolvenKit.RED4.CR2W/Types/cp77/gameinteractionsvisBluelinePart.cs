using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameinteractionsvisBluelinePart : IScriptable
	{
		[Ordinal(0)] [RED("passed")] public CBool Passed { get; set; }
		[Ordinal(1)] [RED("captionIconRecordId")] public TweakDBID CaptionIconRecordId { get; set; }

		public gameinteractionsvisBluelinePart(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
