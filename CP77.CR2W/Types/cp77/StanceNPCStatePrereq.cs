using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class StanceNPCStatePrereq : NPCStatePrereq
	{
		[Ordinal(0)]  [RED("valueToListen")] public CEnum<gamedataNPCStanceState> ValueToListen { get; set; }

		public StanceNPCStatePrereq(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
