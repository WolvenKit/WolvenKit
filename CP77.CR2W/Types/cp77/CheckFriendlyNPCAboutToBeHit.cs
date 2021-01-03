using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class CheckFriendlyNPCAboutToBeHit : StatusEffectTasks
	{
		[Ordinal(0)]  [RED("outPositionArgument")] public CHandle<AIArgumentMapping> OutPositionArgument { get; set; }
		[Ordinal(1)]  [RED("outPositionStatusArgument")] public CHandle<AIArgumentMapping> OutPositionStatusArgument { get; set; }
		[Ordinal(2)]  [RED("outStatusArgument")] public CHandle<AIArgumentMapping> OutStatusArgument { get; set; }

		public CheckFriendlyNPCAboutToBeHit(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
