using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class ReactiveEventSender : AISignalSenderTask
	{
		[Ordinal(4)] [RED("behaviorArgumentNameTag")] public CName BehaviorArgumentNameTag { get; set; }
		[Ordinal(5)] [RED("behaviorArgumentFloatPriority")] public CName BehaviorArgumentFloatPriority { get; set; }
		[Ordinal(6)] [RED("behaviorArgumentNameFlag")] public CName BehaviorArgumentNameFlag { get; set; }
		[Ordinal(7)] [RED("reactiveType")] public CName ReactiveType { get; set; }

		public ReactiveEventSender(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
