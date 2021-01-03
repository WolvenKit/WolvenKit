using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class gameGodModeEntityData : CVariable
	{
		[Ordinal(0)]  [RED("base")] public CArray<gameGodModeData> Base { get; set; }
		[Ordinal(1)]  [RED("overrides")] public CArray<gameGodModeData> Overrides { get; set; }

		public gameGodModeEntityData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
