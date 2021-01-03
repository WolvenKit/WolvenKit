using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class ReactiveEventSender : AISignalSenderTask
	{
		[Ordinal(0)]  [RED("behaviorArgumentFloatPriority")] public CName BehaviorArgumentFloatPriority { get; set; }
		[Ordinal(1)]  [RED("behaviorArgumentNameFlag")] public CName BehaviorArgumentNameFlag { get; set; }
		[Ordinal(2)]  [RED("behaviorArgumentNameTag")] public CName BehaviorArgumentNameTag { get; set; }
		[Ordinal(3)]  [RED("reactiveType")] public CName ReactiveType { get; set; }

		public ReactiveEventSender(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
