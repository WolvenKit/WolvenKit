using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class NPCScanningDescription : ObjectScanningDescription
	{
		[Ordinal(0)]  [RED("NPCCustomDescriptions")] public CArray<TweakDBID> NPCCustomDescriptions { get; set; }
		[Ordinal(1)]  [RED("NPCGameplayDescription")] public TweakDBID NPCGameplayDescription { get; set; }

		public NPCScanningDescription(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
