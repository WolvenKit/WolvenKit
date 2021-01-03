using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class animAnimNode_AnimDatabase : animAnimNode_SkPhaseWithDurationAnim
	{
		[Ordinal(0)]  [RED("animDataBase")] public animAnimDatabaseCollectionEntry AnimDataBase { get; set; }
		[Ordinal(1)]  [RED("inputLinks")] public CArray<animIntLink> InputLinks { get; set; }

		public animAnimNode_AnimDatabase(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
