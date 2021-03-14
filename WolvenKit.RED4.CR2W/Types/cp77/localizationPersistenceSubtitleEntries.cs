using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class localizationPersistenceSubtitleEntries : ISerializable
	{
		[Ordinal(0)] [RED("entries")] public CArray<localizationPersistenceSubtitleEntry> Entries { get; set; }

		public localizationPersistenceSubtitleEntries(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
