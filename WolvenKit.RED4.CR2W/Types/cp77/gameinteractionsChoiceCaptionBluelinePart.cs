using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameinteractionsChoiceCaptionBluelinePart : gameinteractionsChoiceCaptionPart
	{
		[Ordinal(0)] [RED("blueline")] public CHandle<gameinteractionsvisBluelineDescription> Blueline { get; set; }

		public gameinteractionsChoiceCaptionBluelinePart(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
