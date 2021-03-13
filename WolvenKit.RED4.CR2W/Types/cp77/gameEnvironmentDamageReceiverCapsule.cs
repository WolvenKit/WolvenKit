using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameEnvironmentDamageReceiverCapsule : gameEnvironmentDamageReceiverShape
	{
		[Ordinal(1)] [RED("radius")] public CFloat Radius { get; set; }
		[Ordinal(2)] [RED("height")] public CFloat Height { get; set; }

		public gameEnvironmentDamageReceiverCapsule(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
