using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class OutlineRequestManager : IScriptable
	{
		[Ordinal(0)]  [RED("dbgRequests")] public CArray<CHandle<OutlineRequest>> DbgRequests { get; set; }
		[Ordinal(1)]  [RED("isBlocked")] public CBool IsBlocked { get; set; }
		[Ordinal(2)]  [RED("owner")] public wCHandle<gameObject> Owner { get; set; }
		[Ordinal(3)]  [RED("requestsList")] public CArray<CHandle<OutlineRequest>> RequestsList { get; set; }

		public OutlineRequestManager(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
