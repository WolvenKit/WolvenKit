using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class gameinteractionsChoiceLookAtDescriptor : CVariable
	{
		[Ordinal(0)]  [RED("offset")] public Vector3 Offset { get; set; }
		[Ordinal(1)]  [RED("orbId")] public gameinteractionsOrbID OrbId { get; set; }
		[Ordinal(2)]  [RED("slotName")] public CName SlotName { get; set; }
		[Ordinal(3)]  [RED("type")] public CEnum<gameinteractionsChoiceLookAtType> Type { get; set; }

		public gameinteractionsChoiceLookAtDescriptor(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
