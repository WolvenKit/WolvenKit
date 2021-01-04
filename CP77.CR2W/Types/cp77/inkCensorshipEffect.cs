using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class inkCensorshipEffect : inkGlitchEffect
	{
		[Ordinal(0)]  [RED("censorshipFlags")] public CEnum<CensorshipFlags> CensorshipFlags { get; set; }

		public inkCensorshipEffect(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
