using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class meshDestructionBond : CVariable
	{
		[Ordinal(0)]  [RED("bondHealth")] public CUInt8 BondHealth { get; set; }
		[Ordinal(1)]  [RED("bondIndex")] public CUInt16 BondIndex { get; set; }

		public meshDestructionBond(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
