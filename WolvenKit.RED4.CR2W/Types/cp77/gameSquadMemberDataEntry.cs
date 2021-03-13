using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameSquadMemberDataEntry : CVariable
	{
		[Ordinal(0)] [RED("squadName")] public CName SquadName { get; set; }
		[Ordinal(1)] [RED("squadType")] public CEnum<AISquadType> SquadType { get; set; }

		public gameSquadMemberDataEntry(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
