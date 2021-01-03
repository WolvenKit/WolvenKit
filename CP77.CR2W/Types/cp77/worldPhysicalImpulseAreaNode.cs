using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class worldPhysicalImpulseAreaNode : worldPhysicalTriggerAreaNode
	{
		[Ordinal(0)]  [RED("impulse")] public Vector3 Impulse { get; set; }
		[Ordinal(1)]  [RED("impulseRadius")] public CFloat ImpulseRadius { get; set; }

		public worldPhysicalImpulseAreaNode(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
