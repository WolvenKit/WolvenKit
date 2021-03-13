using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameJournalCodexEntry : gameJournalContainerEntry
	{
		[Ordinal(2)] [RED("title")] public LocalizationString Title { get; set; }
		[Ordinal(3)] [RED("imageId")] public TweakDBID ImageId { get; set; }
		[Ordinal(4)] [RED("linkImageId")] public TweakDBID LinkImageId { get; set; }

		public gameJournalCodexEntry(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
