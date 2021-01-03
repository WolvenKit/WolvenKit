using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class gameMuppetAbility : CVariable
	{
		[Ordinal(0)]  [RED("blocks")] public CInt32 Blocks { get; set; }
		[Ordinal(1)]  [RED("value")] public CInt32 Value { get; set; }

		public gameMuppetAbility(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
