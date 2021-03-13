using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class cpPlayerDetector_PseudoDevice : gameObject
	{
		[Ordinal(40)] [RED("playerDetector")] public NodeRef PlayerDetector { get; set; }

		public cpPlayerDetector_PseudoDevice(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
