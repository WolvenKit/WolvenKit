using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameGodModeData : CVariable
	{
		[Ordinal(0)] [RED("type")] public CEnum<gameGodModeType> Type { get; set; }
		[Ordinal(1)] [RED("source")] public CName Source { get; set; }

		public gameGodModeData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
