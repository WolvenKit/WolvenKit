using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class gameJournalCodexEntry : gameJournalContainerEntry
	{
		[Ordinal(0)]  [RED("imageId")] public TweakDBID ImageId { get; set; }
		[Ordinal(1)]  [RED("linkImageId")] public TweakDBID LinkImageId { get; set; }
		[Ordinal(2)]  [RED("title")] public LocalizationString Title { get; set; }

		public gameJournalCodexEntry(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
