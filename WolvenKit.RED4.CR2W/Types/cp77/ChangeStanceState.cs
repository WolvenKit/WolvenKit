using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ChangeStanceState : ChangeStanceStateAbstract
	{
		[Ordinal(1)] [RED("newState")] public CEnum<gamedataNPCStanceState> NewState { get; set; }

		public ChangeStanceState(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
