using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameActionPrereqs : CVariable
	{
		[Ordinal(0)] [RED("actionName")] public CName ActionName { get; set; }
		[Ordinal(1)] [RED("prereqs")] public CArray<CHandle<gameIPrereq>> Prereqs { get; set; }

		public gameActionPrereqs(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
