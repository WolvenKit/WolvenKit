using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameinteractionsChoiceLookAtDescriptor : CVariable
	{
		[Ordinal(0)] [RED("type")] public CEnum<gameinteractionsChoiceLookAtType> Type { get; set; }
		[Ordinal(1)] [RED("slotName")] public CName SlotName { get; set; }
		[Ordinal(2)] [RED("offset")] public Vector3 Offset { get; set; }
		[Ordinal(3)] [RED("orbId")] public gameinteractionsOrbID OrbId { get; set; }

		public gameinteractionsChoiceLookAtDescriptor(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
