using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ChangeJuryrigTrapState : redEvent
	{
		[Ordinal(0)] [RED("newState")] public CEnum<EJuryrigTrapState> NewState { get; set; }

		public ChangeJuryrigTrapState(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
