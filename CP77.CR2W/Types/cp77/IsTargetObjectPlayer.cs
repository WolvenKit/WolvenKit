using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class IsTargetObjectPlayer : AIbehaviorconditionScript
	{
		[Ordinal(0)]  [RED("targetObject")] public CHandle<AIArgumentMapping> TargetObject { get; set; }

		public IsTargetObjectPlayer(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
