using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class gameStatModifierData : IScriptable
	{
		[Ordinal(0)]  [RED("modifierType")] public CEnum<gameStatModifierType> ModifierType { get; set; }
		[Ordinal(1)]  [RED("statType")] public CEnum<gamedataStatType> StatType { get; set; }

		public gameStatModifierData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
