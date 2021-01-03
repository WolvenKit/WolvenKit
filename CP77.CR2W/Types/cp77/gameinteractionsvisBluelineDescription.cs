using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class gameinteractionsvisBluelineDescription : IScriptable
	{
		[Ordinal(0)]  [RED("logicOperator")] public CEnum<ELogicOperator> LogicOperator { get; set; }
		[Ordinal(1)]  [RED("parts")] public CArray<CHandle<gameinteractionsvisBluelinePart>> Parts { get; set; }

		public gameinteractionsvisBluelineDescription(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
