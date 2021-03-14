using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animAnimDatabaseCollection : CVariable
	{
		[Ordinal(0)] [RED("animDatabases")] public CArray<animAnimDatabaseCollectionEntry> AnimDatabases { get; set; }

		public animAnimDatabaseCollection(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
