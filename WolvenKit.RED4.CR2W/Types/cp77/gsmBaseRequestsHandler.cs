using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gsmBaseRequestsHandler : inkISystemRequestsHandler
	{
		[Ordinal(6)] [RED("SavingComplete")] public gsmSavingRequesResult SavingComplete { get; set; }

		public gsmBaseRequestsHandler(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
