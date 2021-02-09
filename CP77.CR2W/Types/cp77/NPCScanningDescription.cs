using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class NPCScanningDescription : ObjectScanningDescription
	{
		[Ordinal(0)]  [RED("NPCGameplayDescription")] public TweakDBID NPCGameplayDescription { get; set; }
		[Ordinal(1)]  [RED("NPCCustomDescriptions")] public CArray<TweakDBID> NPCCustomDescriptions { get; set; }

		public NPCScanningDescription(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
