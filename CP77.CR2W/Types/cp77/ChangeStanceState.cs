using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class ChangeStanceState : ChangeStanceStateAbstract
	{
		[Ordinal(0)]  [RED("newState")] public CEnum<gamedataNPCStanceState> NewState { get; set; }

		public ChangeStanceState(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
