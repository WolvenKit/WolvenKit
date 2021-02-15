using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class RevealRequestsStorage : IScriptable
	{
		[Ordinal(0)] [RED("currentRequestersAmount")] public CInt32 CurrentRequestersAmount { get; set; }
		[Ordinal(1)] [RED("requestersList")] public CArray<entEntityID> RequestersList { get; set; }

		public RevealRequestsStorage(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
