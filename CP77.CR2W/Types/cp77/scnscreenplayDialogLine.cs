using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class scnscreenplayDialogLine : CVariable
	{
		[Ordinal(0)]  [RED("addressee")] public scnActorId Addressee { get; set; }
		[Ordinal(1)]  [RED("femaleLipsyncAnimationName")] public CName FemaleLipsyncAnimationName { get; set; }
		[Ordinal(2)]  [RED("itemId")] public scnscreenplayItemId ItemId { get; set; }
		[Ordinal(3)]  [RED("locstringId")] public scnlocLocstringId LocstringId { get; set; }
		[Ordinal(4)]  [RED("maleLipsyncAnimationName")] public CName MaleLipsyncAnimationName { get; set; }
		[Ordinal(5)]  [RED("speaker")] public scnActorId Speaker { get; set; }
		[Ordinal(6)]  [RED("usage")] public scnscreenplayLineUsage Usage { get; set; }

		public scnscreenplayDialogLine(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
