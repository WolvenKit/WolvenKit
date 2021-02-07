using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class gameObject : entGameEntity
	{
		[Ordinal(0)]  [RED("persistentState")] public CHandle<gamePersistentState> PersistentState { get; set; }
		[Ordinal(1)]  [RED("playerSocket")] public gamePlayerSocket PlayerSocket { get; set; }
		[Ordinal(2)]  [RED("tags")] public redTagList Tags { get; set; }
		[Ordinal(3)]  [RED("displayName")] public LocalizationString DisplayName { get; set; }
		[Ordinal(4)]  [RED("displayDescription")] public LocalizationString DisplayDescription { get; set; }
		[Ordinal(5)]  [RED("audioResourceName")] public CName AudioResourceName { get; set; }
		[Ordinal(6)]  [RED("visibilityCheckDistance")] public CFloat VisibilityCheckDistance { get; set; }

		public gameObject(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
