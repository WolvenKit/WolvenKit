using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class entHardTransformBinding : entITransformBinding
	{
		[Ordinal(3)] [RED("slotName")] public CName SlotName { get; set; }

		public entHardTransformBinding(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
