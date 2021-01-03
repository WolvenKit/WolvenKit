using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class AIArgumentDefinition : ISerializable
	{
		[Ordinal(0)]  [RED("behaviorCallbackName")] public CName BehaviorCallbackName { get; set; }
		[Ordinal(1)]  [RED("isPersistent")] public CBool IsPersistent { get; set; }
		[Ordinal(2)]  [RED("name")] public CName Name { get; set; }

		public AIArgumentDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
