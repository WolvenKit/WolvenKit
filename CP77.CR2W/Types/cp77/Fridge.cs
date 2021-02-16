using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class Fridge : InteractiveDevice
	{
		[Ordinal(93)] [RED("animFeature")] public CHandle<AnimFeature_SimpleDevice> AnimFeature { get; set; }
		[Ordinal(94)] [RED("factOnDoorOpened")] public CName FactOnDoorOpened { get; set; }

		public Fridge(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
