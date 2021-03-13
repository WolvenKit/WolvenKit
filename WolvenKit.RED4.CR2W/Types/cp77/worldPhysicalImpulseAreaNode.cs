using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class worldPhysicalImpulseAreaNode : worldPhysicalTriggerAreaNode
	{
		[Ordinal(7)] [RED("impulse")] public Vector3 Impulse { get; set; }
		[Ordinal(8)] [RED("impulseRadius")] public CFloat ImpulseRadius { get; set; }

		public worldPhysicalImpulseAreaNode(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
