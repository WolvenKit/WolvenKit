using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class gameStatusEffectTDBPicker : CVariable
	{
		[Ordinal(0)]  [RED("statusEffect")] public TweakDBID StatusEffect { get; set; }

		public gameStatusEffectTDBPicker(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
