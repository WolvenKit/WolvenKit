using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class SampleInteractiveEntityThatBumpsTheCounter : gameObject
	{
		[Ordinal(40)] [RED("targetEntityWithCounter")] public NodeRef TargetEntityWithCounter { get; set; }
		[Ordinal(41)] [RED("targetPersistentID")] public gamePersistentID TargetPersistentID { get; set; }

		public SampleInteractiveEntityThatBumpsTheCounter(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
