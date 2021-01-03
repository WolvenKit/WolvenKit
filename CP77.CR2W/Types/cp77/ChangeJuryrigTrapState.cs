using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class ChangeJuryrigTrapState : redEvent
	{
		[Ordinal(0)]  [RED("newState")] public CEnum<EJuryrigTrapState> NewState { get; set; }

		public ChangeJuryrigTrapState(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
