using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gamePrereqData : CVariable
	{
		[Ordinal(0)] [RED("bAndValues")] public CBool BAndValues { get; set; }
		[Ordinal(1)] [RED("prereqList")] public CArray<gamePrereqCheckData> PrereqList { get; set; }

		public gamePrereqData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
